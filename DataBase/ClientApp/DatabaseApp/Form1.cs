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
            }
            catch (Exception ex)
            {
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
            }catch (Exception ex) { MessageBox.Show(ex.Message); }

            
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
                SaveDataGridViewToCsv("output.csv");
                // todo: remove
                //MessageBox.Show($"Successfully saved in:{Application.StartupPath}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        // кнопка меню File-Delete data
        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputQueryForm = new InputQueryForm();
            inputQueryForm.IdEntered += InputForm_IdEntered; // подп
            inputQueryForm.Show();
        }
       

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            try
            {
                db.LoadDataFromCsvToPostgres("output.csv");
                // MessageBox.Show("Successfully updated grid!");
                setConnect_button_Click(sender, e);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
           
        }
    }
}