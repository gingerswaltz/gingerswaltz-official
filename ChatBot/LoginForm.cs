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
        public static string UserName { get; set; }
        public formLogin()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            
           
            UserName = userInputBox.Text;

           

            this.Close();
            Form chatform = new ChatForm();
            chatform.Show();

        }
    }
}
