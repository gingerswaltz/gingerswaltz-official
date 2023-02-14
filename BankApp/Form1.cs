using BankDeposit;

namespace BankApp
{
    public partial class BankApp_Main : Form
    {

    protected  List<BankDepos> Deposit = new List<BankDepos>();

        public BankApp_Main()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            int _code=0;
            int _lic = 0;
            double _money = 0;
            double _proc = 0;

            int.TryParse(codeTextBox.Text, out _code);
            int.TryParse(licTextBox.Text, out _lic);
            double.TryParse(moneyTextBox.Text, out _money);
            double.TryParse(procTextBox.Text, out _proc);

            Deposit.Add(new BankDepos(_money, _proc, (uint)_code, (uint)_lic));
            dataGridView1.Rows.Add(_code, _lic, _money, _proc);
        }
    }
}