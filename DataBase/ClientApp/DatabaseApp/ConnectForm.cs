namespace DatabaseApp
{
    public partial class ConnectForm : Form
    {
        public event DbConnectionChangedEventHandler DbConnectionChanged;

        public delegate void DbConnectionChangedEventHandler(object sender, DBFunc db);

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text;
            string port = textBox2.Text;
            string dbname = textBox3.Text;
            string user = textBox4.Text;
            string password = textBox5.Text;

            DBFunc db = null;
            if (!String.IsNullOrEmpty(ip) && !String.IsNullOrEmpty(port) && !String.IsNullOrEmpty(dbname) && !String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(password))
            {
                db = new DBFunc(ip, port, dbname, user, password);
            }
            else
            {
                db = new DBFunc();
            }

            DbConnectionChanged?.Invoke(this, db);
            this.Close();
            
        }
    }
}
