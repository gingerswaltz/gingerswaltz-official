using BankDeposit;

namespace BankApp 
{
    public partial class BankApp_Main : Form // Класс контроллера, наследует методы от класса формы
    {

    protected  List<BankDepos> Deposit = new List<BankDepos>(); // Коллекция Deposit ссылок на объекты BankDepos

        public BankApp_Main()
        {
            InitializeComponent(); // Вызывается метод инициализации компонентов формы
        }

        

        private void BankFormLoad(object sender, EventArgs e) // Событие загрузки формы
        {
            MessageBox.Show("Author: Purtov Georgy VMK-22"); // Покажем сообщение об авторе
        }

        private void add_ButtonClick(object sender, EventArgs e)
        {
           
            /// Переменные для инициализации значений с textbox
            int _code=0; 
            int _lic = 0;
            double _money = 0;
            double _proc = 0;

            /// Парсинг текста в числовые значения...
            int.TryParse(codeTextBox.Text, out _code);
            int.TryParse(licTextBox.Text, out _lic);
            double.TryParse(moneyTextBox.Text, out _money);
            double.TryParse(procTextBox.Text, out _proc);
            /// ..затем добавляем новый ссылку на объект в коллекцию
            Deposit.Add(new BankDepos(_money, _proc, (uint)_code, (uint)_lic));
            dataGridView1.Rows.Add(_code, _lic, _money, _proc); // добавляем в стринг грид
        }
    }
}