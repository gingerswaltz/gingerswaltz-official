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
        }

        private void setConnect_button_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dataTable = db.GetDataFromSQL();
                dbGridView.DataSource = dataTable;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }



        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Georgy Purtov. 2023");
        }
    }
}