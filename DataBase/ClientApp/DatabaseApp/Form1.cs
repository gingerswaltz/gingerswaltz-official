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
            string connectionString = "Server=127.0.0.1;Port=5432;Database=arenda;User Id=postgres;Password=1;";
            string query = "SELECT * FROM \"клиент\"";  
            try
            {
                DataTable dataTable = db.GetDataFromSQL(connectionString, query);
                dbGridView.DataSource = dataTable;
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
           

        }
    }
}