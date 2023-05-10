/// AUTHOR: GEORGE PURTOV
using Microsoft.VisualBasic;
using System.Data;
using System.Diagnostics;

namespace DatabaseApp
{
    public partial class DBForm : Form
    {
        private DBFunc db; // объект базы данных без инициализации (просто указатель)
        System.Windows.Forms.Timer autosaveTimer; // указатель на объект таймера
        const string pdfFilePath = "helper.pdf"; // хелпер для юзера
        public DBForm()
        {
            InitializeComponent();
            KeyPreview = true; // свойство обработки нажатия клавиш (шорткатов)

        }
        private void ConnectForm_DbConnectionChanged(object sender, DBFunc db)
        {
            // Сохраняем объект db для использования в главной форме
            this.db = db;
            refreshBaseToolStripMenuItem_Click(sender, new EventArgs());
        }

        // парсим данные из таблицы
        private DataTable GetDataTableFromDataGridView(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // добавляем столбцы в DataTable, кроме первого столбца из DataGridView
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Index != 0) // пропускаем первый столбец
                    dt.Columns.Add(col.Name);
            }

            // добавляем строки в DataTable
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int i = 1; i < dgv.Columns.Count; i++) // начинаем с 1, чтобы пропустить первый столбец
                {
                    dr[i - 1] = row.Cells[i].Value;
                }
                dt.Rows.Add(dr);
            }

            return dt;      // вернем объект DataTable
        }



        // метод-обработчик события DataEntered, переданном от экземпляра InputForm. 
        // sender - объект, инициировавший событие, e - объект типа MyDataEventArgs, в который мы передаем объект myData
        private void InputForm_DataEntered(object sender, InputForm.MyDataEventArgs e)
        {
            ClientData myData = e.Data; // извлечение объекта из делегата
            db.InsertDataToPostgreSQL(myData); // вставляем его в БД
            refreshBaseToolStripMenuItem_Click(sender, e);


        }


        // установка первоначального соединения
        private void setConnect_button_Click(object sender, EventArgs e)
        {
            try
            {
                ShowConnectForm();                     // показать форму подключения
                dbGridView.AutoGenerateColumns = true; // установить свойство AutoGenerateColumns в true
                DataTable dataTable = db.GetDataFromSQL(); // передаем в объект типа DataTable таблицу из БД 
                dbGridView.DataSource = dataTable; // установим источник данных грида - таблица из БД
                SetLabelColor();                  // окрас в зеленый
                refreshBaseToolStripMenuItem_Click(sender, e); // обновить бд
            }
            catch (Exception ex)
            {
                SetLabelColor(ex);          // окрас в красный
                MessageBox.Show(ex.Message);// покажем сообщение об ошибке

            }
        }



        // кнопка меню File-Add data
        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InputForm inputForm = new InputForm();
                inputForm.DataEntered += InputForm_DataEntered; // подписываемся на событие ввода данных из InputForm, начинаем прослушивание
                inputForm.Show();
                SetLabelColor();
            }
            catch (Exception ex)
            {
                SetLabelColor(ex);
                MessageBox.Show(ex.Message);
            }


        }


        // кнопка меню About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Georgy Purtov. 2023");
        }


        // кнопка меню File-Save data
        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                db.SetFilePath(Interaction.InputBox("Введите имя файла для сохранения:", "Имя файла", "")); // задаем имя файла
                toolStripStatusLabel1.Text = $"Данные сохранены в {Application.StartupPath}";  // выводим в статуслейбл куда сохранили
                var dt = GetDataTableFromDataGridView(dbGridView); // считываем данные с datagridview
                db.SaveToCsv(dt); // сохраняем в csv
                SetLabelColor(); // окрашиваем статус бд в зеленый
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // покажем сообщение об ошибке
                SetLabelColor(ex);           // окрасим статус бд в красный

            }
        }



        // окрас состояния БД в красный или зеленый цвет
        private void SetLabelColor(Exception ex = null)
        {
            if (ex == null) // если  исключения не было
            {
                labelState.Text = "OK"; // скажем что с бд всё  в порядке
                labelState.BackColor = ColorTranslator.FromHtml("#94d446"); // окрасим в зеленый
            }
            else
            {
                labelState.Text = "NOT OK"; // скажем что с бд не всё хорошо
                labelState.BackColor = ColorTranslator.FromHtml("#c75842"); // окрасим в красный
            }
        }

        // метод окраса в зелёный цвет найденных совпадений
        public void ShowSearchResult(List<DataRow> result)
        {
            // Очистить выделение в DataGridView
            dbGridView.ClearSelection();

            // Пройти по каждой строке результата поиска
            foreach (var row in result)
            {
                // Найти строку с данными этой строки в DataGridView
                var index = dbGridView.Rows.Cast<DataGridViewRow>()
                    .ToList()
                    .FindIndex(r => r.Cells["name"].Value.ToString().Equals(row["name"].ToString(), StringComparison.OrdinalIgnoreCase));

                // Если строка найдена, переместить ее вверх и покрасить в зеленый цвет
                if (index >= 0)
                {
                    dbGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

            dbGridView.Refresh();
        }



        // метод-обработчик события NameEntered, переданным из QueryForm
        private void InputQueryForm_NameEntered(object sender, string name)
        {
            try
            {
                ShowSearchResult(db.Search(name)); // в метод окраса рез-тов поиска закинем результаты, полученные из метода поиска по бд
                SetLabelColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // покажем сообщение об ошибке
                SetLabelColor(ex);           // окрас в красный
            }


        }




        // загрузка данных из файла
        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // инициализируем opendialog

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK) // если выбрали файл
                {
                    db.SetFilePath(Path.GetFileNameWithoutExtension(openFileDialog.FileName)); // получим его имя
                    db.LoadDataFromCsvToPostgres(); // загрузим данные
                    refreshBaseToolStripMenuItem_Click(sender, e); // обновим бд
                } else {
                   
                    refreshBaseToolStripMenuItem_Click(sender, e); // просто обновим бд
                }

            }
            catch (Exception ex)
            {

                SetLabelColor(ex);          // окрас в красный цвет
                MessageBox.Show(ex.Message);// покажем сообщение об ошибке
            }


        }

        // метод открытия формы для подключения к бд
        private void ShowConnectForm()
        {
            var connectForm = new ConnectForm(); // создаем форму коннекта
            connectForm.DbConnectionChanged += ConnectForm_DbConnectionChanged; // подпись на делегата
            connectForm.ShowDialog();   // показываем форму
        }


        // обработка нажатия клавиши Delete в таблице
        private void dbGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewCell selectedCell = dbGridView.CurrentCell; // выделенная строка
                if (selectedCell != null) // если выбрана
                {
                    int rowIndex = selectedCell.RowIndex; // получаем индексы строки и столбца выделенныъ
                    int columnIndex = selectedCell.ColumnIndex;
                    if (columnIndex == dbGridView.Columns["Id"].Index) // берём оттуда айдишник
                    {
                        int id = Convert.ToInt32(selectedCell.Value); // парсим его в Int
                        db.DeleteRecordById(id); // удаляем из БД по айди
                        dbGridView.Rows.RemoveAt(rowIndex); // удаляем эту строку
                    }
                }
            }
        }




        // шорткаты
        private void DBForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Вызываем метод сохранения данных
                saveToToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true; // Предотвращаем дальнейшую обработку нажатия клавиши
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                // Вызываем метод обновления
                refreshBaseToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true; // Предотвращаем дальнейшую обработку нажатия клавиши
            }
            if (e.Control && e.KeyCode == Keys.T)
            {
                // Вызываем метод добавления данных
                addDataToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true; // Предотвращаем дальнейшую обработку нажатия клавиши
            }
        }


        // на щагрузке формы
        private void DBForm_Load(object sender, EventArgs e)
        {
            ShowConnectForm(); // показать форму подключения

            // Создание таймера и настройка интервала на 3 минуты (180000 миллисекунд)
            autosaveTimer = new System.Windows.Forms.Timer();
            autosaveTimer.Interval = 180000; // 3 минуты
            autosaveTimer.Tick += AutosaveTimer_Tick;
            autosaveTimer.Start();
        }
        
        // метод автосохранения
        private void AutosaveTimer_Tick(object sender, EventArgs e)
        {
            // Вызов метода сохранения
            try
            {
                var dt = GetDataTableFromDataGridView(dbGridView); // получаем таблицу datagridview
                db.SaveToCsv(dt); // сохраняем бд
                // Отображение сообщения об успешном сохранении в Label
                toolStripStatusLabel1.Text = $"Autosaved at {DateTime.Now}";
                toolStripStatusLabel1.BackColor = ColorTranslator.FromHtml("#94d446");
            }
            catch (Exception ex)
            { SetLabelColor(ex); } // окрас в красный


        }

        // метод поиска данных
        private void findDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshBaseToolStripMenuItem_Click(sender, e); // обновим данные
            var queryForm = new InputQueryForm(); // показываем форму запроса
            queryForm.NameEntered += InputQueryForm_NameEntered; // начинаем слушать имя с формы
            queryForm.Show(); // показываем форму
        }

        // обновление данных в табл
        private void refreshBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dbGridView.ClearSelection(); // убираем выделения строк
                dbGridView.AutoGenerateColumns = true; // установить свойство AutoGenerateColumns в true
                dbGridView.AutoSize = true;  // автоподгонка размеров
                DataTable dataTable = db.GetUpdatedDataFromPostgres(); // передаем в объект типа DataTable таблицу из БД 
                dbGridView.DataSource = dataTable; // установим источник данных грида - таблица из БД
                SetLabelColor();
            }
            catch (Exception ex)
            {
                SetLabelColor(ex);           // окрас в красный
                MessageBox.Show(ex.Message); // покажем сообщение об ошибке

            }
        }

        // на закрытии формы
        private void DBForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            autosaveTimer.Stop(); // остановка таймера
        }

        // метод вызова хелпера
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              
                ProcessStartInfo psi = new ProcessStartInfo(); // объект исполнения процессов
                psi.FileName = pdfFilePath; // передаём имя файла который хотим открыть
                psi.UseShellExecute = true; // разрешаем открывать программой по умолчанию для данного формата файлов
                Process.Start(psi); // открываем файл
                SetLabelColor();    // окрасим лейбл в зеленый

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // покажем сообщение об ошибке
                SetLabelColor();             // окрас в красный
            }
        }
    }
}