// Main Form
using System.Data;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class DBForm : Form
    {
        private DBFunc db;

        public DBForm()
        {
            InitializeComponent();
            KeyPreview = true; // свойство обработки нажатия клавиш (шорткатов)

        }
        private void ConnectForm_DbConnectionChanged(object sender, DBFunc db)
        {
            // Сохраняем объект db для использования в главной форме
            this.db = db;

            // Здесь можно выполнить какие-то действия, которые должны произойти при изменении подключения к БД
        }
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
                var dt = GetDataTableFromDataGridView(dbGridView);
                db.SaveToCsv(dt, "output.csv");
                SetLabelColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetLabelColor(ex);

            }
        }

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
                var foundRow = dbGridView.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["name"].Value.ToString().Equals(row["name"].ToString()));

                // Если строка найдена, переместить ее вверх и покрасить в зеленый цвет
                if (foundRow != null)
                {
                    dbGridView.Rows.Remove(foundRow);
                    dbGridView.Rows.Insert(0, foundRow);
                    foundRow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }


        // метод-обработчик события IdEntered, переданным из QueryForm
        private void InputQueryForm_NameEntered(object sender, string name)
        {
            try
            {
                ShowSearchResult(db.Search(name));
                SetLabelColor();
                refreshBaseToolStripMenuItem_Click(sender, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetLabelColor(ex);
            }


        }





        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                db.LoadDataFromCsvToPostgres();
                refreshBaseToolStripMenuItem_Click(sender, e);
            }
            catch (Exception ex)
            {

                SetLabelColor(ex);
                MessageBox.Show(ex.Message);
            }


        }

        private void ShowConnectForm()
        {
            var connectForm = new ConnectForm();
            connectForm.DbConnectionChanged += ConnectForm_DbConnectionChanged;
            connectForm.ShowDialog();
        }


        private void dbGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewCell selectedCell = dbGridView.CurrentCell;
                if (selectedCell != null)
                {
                    int rowIndex = selectedCell.RowIndex;
                    int columnIndex = selectedCell.ColumnIndex;
                    if (columnIndex == dbGridView.Columns["Id"].Index)
                    {
                        int id = Convert.ToInt32(selectedCell.Value);
                        db.DeleteRecordById(id);
                        dbGridView.Rows.RemoveAt(rowIndex);
                    }
                }
            }
        }



        private void dbGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dbGridView.DataSource = db.SortById();
            }
        }

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
                // Вызываем метод сохранения данных
                refreshBaseToolStripMenuItem_Click(sender, e);
                e.SuppressKeyPress = true; // Предотвращаем дальнейшую обработку нажатия клавиши
            }
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            ShowConnectForm();
        }

        private void findDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryForm = new InputQueryForm();
            queryForm.NameEntered += InputQueryForm_NameEntered;
            queryForm.Show();
        }

        private void refreshBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dbGridView.AutoGenerateColumns = true; // установить свойство AutoGenerateColumns в true
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
    }
}