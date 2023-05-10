/// AUTHOR: GEORGE PURTOV

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
            string ip = textBox1.Text; // получаем ip
            string port = textBox2.Text; //  получаем port
            string dbname = textBox3.Text; // имя бд
            string user = textBox4.Text; // юзернейм
            string password = textBox5.Text; // пароль

            DBFunc db = null;
            // если всё поля заполнены, то 
            if (!String.IsNullOrEmpty(ip) && !String.IsNullOrEmpty(port) && !String.IsNullOrEmpty(dbname) && !String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(password))
            {
                db = new DBFunc(ip, port, dbname, user, password); // подключаемся по указанным данным
            }
            else
            {
                db = new DBFunc(); // создаем подключение к  бд по умолчанию
            }

            DbConnectionChanged?.Invoke(this, db); // делегируем объект бд в мэин форму
            this.Close();
            
        }
    }
}
