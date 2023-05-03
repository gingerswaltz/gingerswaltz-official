using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabaseApp
{
    public partial class InputQueryForm : Form
    {
        public InputQueryForm()
        {
            InitializeComponent();
        }

        public event EventHandler<int> IdEntered;


        private void OkButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(InputBox_Textbox.Text);

            // Вызываем событие с передачей id
            IdEntered?.Invoke(this, id);

            // Закрываем форму
            this.Close();
        }
    }
}
