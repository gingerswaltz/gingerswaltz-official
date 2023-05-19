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
            this.textBox_Arendator = new System.Windows.Forms.TextBox();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Req = new System.Windows.Forms.TextBox();
            this.textBox_Contact = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label_Arendator = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Req = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Arendator
            // 
            this.textBox_Arendator.Location = new System.Drawing.Point(13, 31);
            this.textBox_Arendator.Name = "textBox_Arendator";
            this.textBox_Arendator.Size = new System.Drawing.Size(100, 23);
            this.textBox_Arendator.TabIndex = 0;
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Location = new System.Drawing.Point(13, 82);
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(100, 23);
            this.textBox_Adress.TabIndex = 1;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(13, 136);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 23);
            this.textBox_Phone.TabIndex = 2;
            // 
            // textBox_Req
            // 
            this.textBox_Req.Location = new System.Drawing.Point(13, 189);
            this.textBox_Req.Name = "textBox_Req";
            this.textBox_Req.Size = new System.Drawing.Size(100, 23);
            this.textBox_Req.TabIndex = 3;
            // 
            // textBox_Contact
            // 
            this.textBox_Contact.Location = new System.Drawing.Point(13, 237);
            this.textBox_Contact.Name = "textBox_Contact";
            this.textBox_Contact.Size = new System.Drawing.Size(100, 23);
            this.textBox_Contact.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(13, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 39);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label_Arendator
            // 
            this.label_Arendator.AutoSize = true;
            this.label_Arendator.Location = new System.Drawing.Point(12, 13);
            this.label_Arendator.Name = "label_Arendator";
            this.label_Arendator.Size = new System.Drawing.Size(66, 15);
            this.label_Arendator.TabIndex = 7;
            this.label_Arendator.Text = "Арендатор";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(12, 64);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(40, 15);
            this.label_Adress.TabIndex = 8;
            this.label_Adress.Text = "Адрес";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Location = new System.Drawing.Point(13, 118);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(55, 15);
            this.label_Phone.TabIndex = 9;
            this.label_Phone.Text = "Телефон";
            // 
            // label_Req
            // 
            this.label_Req.AutoSize = true;
            this.label_Req.Location = new System.Drawing.Point(12, 171);
            this.label_Req.Name = "label_Req";
            this.label_Req.Size = new System.Drawing.Size(65, 15);
            this.label_Req.TabIndex = 10;
            this.label_Req.Text = "Реквизиты";
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Location = new System.Drawing.Point(12, 219);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(101, 15);
            this.label_Contact.TabIndex = 11;
            this.label_Contact.Text = "Контактное лицо";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 332);
            this.Controls.Add(this.label_Contact);
            this.Controls.Add(this.label_Req);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.label_Arendator);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox_Contact);
            this.Controls.Add(this.textBox_Req);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.textBox_Arendator);
            this.Name = "InputForm";
            this.Text = "Input data";
            this.ResumeLayout(false);
            this.PerformLayout();

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