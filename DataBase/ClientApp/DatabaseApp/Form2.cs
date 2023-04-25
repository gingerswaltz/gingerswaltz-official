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

        public event EventHandler<MyDataEventArgs> DataEntered;

        public class MyDataEventArgs: EventArgs
        {
            public MyData Data { get; set; }    
            public MyDataEventArgs(MyData data)
            {
                Data=data;
            }

        }
        public InputForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MyData myData = new MyData();
            myData.Adress=textBox_Adress.Text;
            myData.ContactPerson=textBox_Contact.Text;
            myData.Requisites = textBox_Req.Text;
            myData.Name=textBox_Arendator.Text;
            myData.Phone=textBox_Phone.Text;
            DataEntered?.Invoke(this, new MyDataEventArgs(myData));
        }
    }
}
