using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class InputForm : Form
    {
        // делегат, вызывающийся при кнопке нажатия данных
        public event EventHandler<MyDataEventArgs> DataEntered;


        // класс, наследующийся от EventArgs, используется для передачи данных меж формами
        public class MyDataEventArgs: EventArgs
        {
            public MyData Data { get; set; }    
            public MyDataEventArgs(MyData data)
            {
                Data=data;
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
            myData.Adress=textBox_Adress.Text; // заполнение полей
            myData.ContactPerson=textBox_Contact.Text;
            myData.Requisites = textBox_Req.Text;
            myData.Name=textBox_Arendator.Text;
            myData.Phone=textBox_Phone.Text;
            DataEntered?.Invoke(this, new MyDataEventArgs(myData)); // объект myData передастся через событие MainForm.DataEntered через метод Invoke 
        }
    }
}
