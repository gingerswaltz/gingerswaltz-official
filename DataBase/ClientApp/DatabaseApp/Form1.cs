using System.Data;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class DBForm : Form
    {
        DBFunc db = new();
        public DBForm()
        {
            InitializeComponent();
            dbGridView.AutoGenerateColumns = true; // установить свойство AutoGenerateColumns в true

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
            InputForm inputForm = new InputForm();
            inputForm.DataEntered += InputForm_DataEntered;
            inputForm.Show();
            db.GetDataFromSQL();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Georgy Purtov. 2023");
        }
    }
}