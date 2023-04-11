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
            

            if ((userInputBox.Text == null) || (userInputBox.Text == "")) // Если строка ввода имени пустая
            {
                MessageBox.Show("Type your name");                        // Выведем сообщение и заставим заново ввести имя
            }
            else                                                          // иначе закроем эту форму, и создадим окно общения с ботом
            {
                ChatForm chatform = new ChatForm(userInputBox.Text); // Формируем ссылку на окно чат формы
               
                this.Hide();
                chatform.Show();                // Открываем окно чат формы
                // association
            }



        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e) // событие после закрытия формы 
        {
         //   if (e.CloseReason == CloseReason.UserClosing && bot1.GetUserName() == "") ;  // Если юзер закрыл форму на крестик и не ввел имя (не хочет работать)
//botObject.SetUserName(null); // вернем null значение в форму общения, и при инициализации оно его словит и завершит всю программу

        }
    }
}
