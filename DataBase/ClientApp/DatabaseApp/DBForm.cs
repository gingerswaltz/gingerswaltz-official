// todo: doc
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class DBForm : Form
    {
        DBFunc db = new();

        public DBForm()
        {
            InitializeComponent();
            KeyPreview = true;
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
            setConnect_button_Click(sender, e); // делаем повторный селект и получаем актуальные данные
        }


        // установка первоначального соединения, рефреш данных на гриде
        private void setConnect_button_Click(object sender, EventArgs e)
        {

            try
            {
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
                db.SaveToCsv(dt, "output.txt");
                SetLabelColor() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SetLabelColor(ex);

            }
        }

        private void SetLabelColor(Exception ex=null)
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


        // метод-обработчик события IdEntered, переданным из QueryForm
        private void InputForm_IdEntered(object sender, int id)
        {
            // Выполнение действий с использованием полученного id

            try
            {
                db.DeleteRecordById(id);
                
                // Удаление записи с заданным id из DataGridView
                foreach (DataGridViewRow row in dbGridView.Rows)
                {
                    int rowId = (int)row.Cells["id"].Value;
                    if (rowId == id)
                    {
                        dbGridView.Rows.Remove(row);
                        break;
                    }
                }
                SetLabelColor();
            }
            catch (Exception ex) 
            {
                SetLabelColor(ex);
                MessageBox.Show(ex.Message);
            }

        }





        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                db.LoadDataFromCsvToPostgres("output.csv");
                // MessageBox.Show("Successfully updated grid!");
                setConnect_button_Click(sender, e);
                SetLabelColor() ;
            }
            catch (Exception ex) {

                SetLabelColor(ex);
                MessageBox.Show(ex.Message);
            }


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
        }
    }
}