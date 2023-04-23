namespace DatabaseApp
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Arendator = new TextBox();
            textBox_Adress = new TextBox();
            textBox_Phone = new TextBox();
            textBox_Req = new TextBox();
            textBox_Contact = new TextBox();
            buttonAdd = new Button();
            label_Arendator = new Label();
            label_Adress = new Label();
            label_Phone = new Label();
            label_Req = new Label();
            label_Contact = new Label();
            SuspendLayout();
            // 
            // textBox_Arendator
            // 
            textBox_Arendator.Location = new Point(13, 31);
            textBox_Arendator.Name = "textBox_Arendator";
            textBox_Arendator.Size = new Size(100, 23);
            textBox_Arendator.TabIndex = 0;
            // 
            // textBox_Adress
            // 
            textBox_Adress.Location = new Point(13, 82);
            textBox_Adress.Name = "textBox_Adress";
            textBox_Adress.Size = new Size(100, 23);
            textBox_Adress.TabIndex = 1;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(13, 136);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(100, 23);
            textBox_Phone.TabIndex = 2;
            // 
            // textBox_Req
            // 
            textBox_Req.Location = new Point(13, 189);
            textBox_Req.Name = "textBox_Req";
            textBox_Req.Size = new Size(100, 23);
            textBox_Req.TabIndex = 3;
            // 
            // textBox_Contact
            // 
            textBox_Contact.Location = new Point(13, 237);
            textBox_Contact.Name = "textBox_Contact";
            textBox_Contact.Size = new Size(100, 23);
            textBox_Contact.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(13, 277);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(101, 39);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label_Arendator
            // 
            label_Arendator.AutoSize = true;
            label_Arendator.Location = new Point(12, 13);
            label_Arendator.Name = "label_Arendator";
            label_Arendator.Size = new Size(66, 15);
            label_Arendator.TabIndex = 7;
            label_Arendator.Text = "Арендатор";
            // 
            // label_Adress
            // 
            label_Adress.AutoSize = true;
            label_Adress.Location = new Point(12, 64);
            label_Adress.Name = "label_Adress";
            label_Adress.Size = new Size(40, 15);
            label_Adress.TabIndex = 8;
            label_Adress.Text = "Адрес";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Location = new Point(13, 118);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(55, 15);
            label_Phone.TabIndex = 9;
            label_Phone.Text = "Телефон";
            // 
            // label_Req
            // 
            label_Req.AutoSize = true;
            label_Req.Location = new Point(12, 171);
            label_Req.Name = "label_Req";
            label_Req.Size = new Size(65, 15);
            label_Req.TabIndex = 10;
            label_Req.Text = "Реквизиты";
            // 
            // label_Contact
            // 
            label_Contact.AutoSize = true;
            label_Contact.Location = new Point(12, 219);
            label_Contact.Name = "label_Contact";
            label_Contact.Size = new Size(101, 15);
            label_Contact.TabIndex = 11;
            label_Contact.Text = "Контактное лицо";
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(132, 332);
            Controls.Add(label_Contact);
            Controls.Add(label_Req);
            Controls.Add(label_Phone);
            Controls.Add(label_Adress);
            Controls.Add(label_Arendator);
            Controls.Add(buttonAdd);
            Controls.Add(textBox_Contact);
            Controls.Add(textBox_Req);
            Controls.Add(textBox_Phone);
            Controls.Add(textBox_Adress);
            Controls.Add(textBox_Arendator);
            Name = "InputForm";
            Text = "Input data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Arendator;
        private TextBox textBox_Adress;
        private TextBox textBox_Phone;
        private TextBox textBox_Req;
        private TextBox textBox_Contact;
        private Button buttonAdd;
        private Label label_Arendator;
        private Label label_Adress;
        private Label label_Phone;
        private Label label_Req;
        private Label label_Contact;
    }
}