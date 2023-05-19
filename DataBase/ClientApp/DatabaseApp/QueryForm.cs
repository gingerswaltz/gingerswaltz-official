
/// AUTHOR: GEORGE PURTOV


namespace DatabaseApp
{
    public partial class InputQueryForm : Form
    {
        public InputQueryForm()
        {
            InitializeComponent();
        }

        public event EventHandler<string> NameEntered; // делегат передающий "имя"


        private void OkButton_Click(object sender, EventArgs e)
        {
            string name = InputBox_Textbox.Text; // передаем введённое значение в переменную 

            NameEntered?.Invoke(this, name);    // делегируем её в мэин форму

            // Закрываем форму
            this.Close();
        }
    }
}
