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
        public formLogin()      // Конструктор
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки принять
        {
            chatFunc bot1 = new();

            bot1.SetUserName(userInputBox.Text);                // Засеттим юзернейм

            if ((userInputBox.Text == null) || (userInputBox.Text == "")) // Если строка ввода имени пустая
            {
                MessageBox.Show("Type your name");                        // Выведем сообщение и заставим заново ввести имя
            }
            else                                                          // иначе закроем эту форму, и создадим окно общения с ботом
            {
                this.Close();
                Form chatform = new ChatForm(); // Формируем ссылку на окно чат формы
                chatform.Show();                // Открываем окно чат формы
                // association
            }



        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e) // событие после закрытия формы 
        {
            chatFunc bot1 = new();
            if (e.CloseReason == CloseReason.UserClosing && userInputBox.Text == "") ; // Если юзер закрыл форму на крестик и не ввел имя (не хочет работать)
          //  bot1.SetUserName(null); // вернем null значение в форму общения, и при инициализации оно его словит и завершит всю программу

        }
    }
}
