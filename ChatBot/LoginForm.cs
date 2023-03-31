using ChatBotFunc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {


            chatFunc.SetUserName(userInputBox.Text);

            if ((userInputBox.Text == null) || (userInputBox.Text == ""))
            {
                MessageBox.Show("Type your name");
            }
            else
            {
                this.Close();
                Form chatform = new ChatForm(); // Формируем ссылку на окно чат формы
                chatform.Show();                // Открываем окно чат формы
                // association
            }



        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && userInputBox.Text == "")
                chatFunc.SetUserName(null);

        }
    }
}
