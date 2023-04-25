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

        }

        private void SaveDataGridViewToCsv(string filePath)
        {
            // Добавляем названия столбцов
            var columnNames = dbGridView.Columns.Cast<DataGridViewColumn>()
                                 .Select(column => column.Name)
                                 .ToList();

            // Перебираем строки в DataGridView
            var data = new List<List<string>>();
            foreach (DataGridViewRow row in dbGridView.Rows)
            {
                // Создаем список строк для текущей строки DataGridView
                var rowData = new List<string>();

                // Перебираем ячейки в текущей строке DataGridView
                for (int i = 0; i < dbGridView.Columns.Count; i++)
                {
                    // Записываем значение ячейки в список строк
                    rowData.Add(row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : "");
                }

                // Добавляем список строк в коллекцию
                data.Add(rowData);
            }

            // Сохраняем данные в CSV файл
            db.SaveToCsv(columnNames, data, filePath);
        }


        private void InputForm_DataEntered(object sender, InputForm.MyDataEventArgs e)
        {
            MyData myData = e.Data;
            db.InsertDataToPostgreSQL(myData);
            setConnect_button_Click(sender, e);
        }


        private void setConnect_button_Click(object sender, EventArgs e)
        {

            try
            {
                dbGridView.AutoGenerateColumns = true; // установить свойство AutoGenerateColumns в true
                DataTable dataTable = db.GetDataFromSQL();
                dbGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InputForm inputForm = new InputForm();
                inputForm.DataEntered += InputForm_DataEntered;
                inputForm.Show();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }

            
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Georgy Purtov. 2023");
        }

        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                SaveDataGridViewToCsv("output.csv");
                MessageBox.Show($"Successfully saved in:{Application.StartupPath}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



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
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }



        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputQueryForm = new InputQueryForm();
            inputQueryForm.IdEntered += InputForm_IdEntered;
            inputQueryForm.Show();
        }
       

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            try
            {
                db.LoadDataFromCsvToPostgres();
                MessageBox.Show("Successfully updated grid!");
                setConnect_button_Click(sender, e);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
           
        }
    }
}