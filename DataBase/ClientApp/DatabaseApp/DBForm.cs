// Main Form
using Microsoft.VisualBasic;
using System.Data;
using System.Diagnostics;

namespace DatabaseApp
{
    public partial class DBForm : Form
    {
        private DBFunc db; // объект базы данных без инициализации (просто указатель)
        System.Windows.Forms.Timer autosaveTimer; // указатель на объект таймера
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

            return dt;
        }



        // метод-обработчик события DataEntered, переданном от экземпляра InputForm. 
        // sender - объект, инициировавший событие, e - объект типа MyDataEventArgs, в который мы передаем объект myData
        private void InputForm_DataEntered(object sender, InputForm.MyDataEventArgs e)
        {
            MyData myData = e.Data; // извлечение объекта из делегата
            db.InsertDataToPostgreSQL(myData); // вставляем его в БД
            refreshBaseToolStripMenuItem_Click(sender, e);


        }


        // установка первоначального соединения
        private void setConnect_button_Click(object sender, EventArgs e)
        {
            try
            {
                ShowConnectForm();
                dbGridView.AutoGenerateColumns = true; // установить свойство AutoGenerateColumns в true
                DataTable dataTable = db.GetDataFromSQL(); // передаем в объект типа DataTable таблицу из БД 
                dbGridView.DataSource = dataTable; // установим источник данных грида - таблица из БД
                SetLabelColor();
                refreshBaseToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                SetLabelColor(ex);
                MessageBox.Show(ex.Message);

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
                db.SetFilePath(Interaction.InputBox("Введите имя файла для сохранения:", "Имя файла", ""));
                MessageBox.Show($"Данные сохранены в {Application.StartupPath}");
                var dt = GetDataTableFromDataGridView(dbGridView);
                db.SaveToCsv(dt);
                SetLabelColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetLabelColor(ex);

            }
        }



        // окрас состояния БД в красный или зеленый цвет
        private void SetLabelColor(Exception ex = null)
        {
            if (ex == null)
            {
                labelState.Text = "OK";
                labelState.BackColor = ColorTranslator.FromHtml("#94d446");
            }
            else
            {
                labelState.Text = "NOT OK";
                labelState.BackColor = ColorTranslator.FromHtml("#c75842");
            }
        }
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
                ShowSearchResult(db.Search(name));
                SetLabelColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetLabelColor(ex);
            }


        }




        // загрузка данных из файла
        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    db.SetFilePath(Path.GetFileNameWithoutExtension(openFileDialog.FileName));
                    db.LoadDataFromCsvToPostgres();
                    refreshBaseToolStripMenuItem_Click(sender, e);
                }

            }
            catch (Exception ex)
            {

                SetLabelColor(ex);
                MessageBox.Show(ex.Message);
            }


        }

        // метод открытия формы для подключения к бд
        private void ShowConnectForm()
        {
            var connectForm = new ConnectForm();
            connectForm.DbConnectionChanged += ConnectForm_DbConnectionChanged;
            connectForm.ShowDialog();
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
        private void AutosaveTimer_Tick(object sender, EventArgs e)
        {
            // Вызов метода сохранения
            try
            {
                var dt = GetDataTableFromDataGridView(dbGridView);
                db.SaveToCsv(dt);
                // Отображение сообщения об успешном сохранении в Label
                labelState.Text = $"Saved at {DateTime.Now}";
                labelState.BackColor = ColorTranslator.FromHtml("#94d446");
            }
            catch (Exception ex)
            { SetLabelColor(ex); }


        }


        private void findDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshBaseToolStripMenuItem_Click(sender, e);
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
                SetLabelColor(ex);
                MessageBox.Show(ex.Message);

            }
        }

        // на закрытии формы
        private void DBForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            autosaveTimer.Stop(); // остановка таймера
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                string pdfFilePath = "helper.pdf";
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = pdfFilePath;
                psi.UseShellExecute = true;
                Process.Start(psi);
                SetLabelColor() ;

            } catch(Exception ex)   
            {
                MessageBox.Show(ex.Message);
                SetLabelColor();
            }
        }
    }
}