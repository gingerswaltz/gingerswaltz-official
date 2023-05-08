namespace DatabaseApp
{
    public partial class InputForm : Form
    {
        // делегат, вызывающийся при кнопке нажатия данных
        public event EventHandler<MyDataEventArgs> DataEntered;


        // класс, наследующийся от EventArgs, используется для передачи данных меж формами
        public class MyDataEventArgs : EventArgs
        {
            public MyData Data { get; set; }
            public MyDataEventArgs(MyData data)
            {
                Data = data;
            }

        }


        // Инициализация формы-источника события, которую слушает Main форма
        public InputForm()
        {
            InitializeComponent();
        }

        // обработчик события нажатия кнопки Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MyData myData = new MyData(); // инициализация объекта
            myData.adress = textBox_Adress.Text; // заполнение полей
            myData.contact_name = textBox_Contact.Text;
            myData.requisites = textBox_Req.Text;
            myData.name = textBox_Arendator.Text;
            myData.phone = textBox_Phone.Text;
            DataEntered?.Invoke(this, new MyDataEventArgs(myData)); // объект myData передастся через событие MainForm.DataEntered через метод Invoke 
        }
    }
}
