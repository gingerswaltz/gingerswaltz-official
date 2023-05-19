namespace DatabaseApp
{
    partial class ConnectForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            buttonSet = new Button();
            label_IP = new Label();
            label_Port = new Label();
            label_DB = new Label();
            label_Username = new Label();
            label_Pass = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(23, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(23, 248);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(100, 49);
            buttonSet.TabIndex = 5;
            buttonSet.Text = "Set adress";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // label_IP
            // 
            label_IP.AutoSize = true;
            label_IP.Location = new Point(23, 16);
            label_IP.Name = "label_IP";
            label_IP.Size = new Size(17, 15);
            label_IP.TabIndex = 6;
            label_IP.Text = "IP";
            // 
            // label_Port
            // 
            label_Port.AutoSize = true;
            label_Port.Location = new Point(23, 60);
            label_Port.Name = "label_Port";
            label_Port.Size = new Size(29, 15);
            label_Port.TabIndex = 7;
            label_Port.Text = "Port";
            // 
            // label_DB
            // 
            label_DB.AutoSize = true;
            label_DB.Location = new Point(23, 104);
            label_DB.Name = "label_DB";
            label_DB.Size = new Size(57, 15);
            label_DB.TabIndex = 8;
            label_DB.Text = "DB name";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Location = new Point(23, 148);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(60, 15);
            label_Username.TabIndex = 9;
            label_Username.Text = "Username";
            // 
            // label_Pass
            // 
            label_Pass.AutoSize = true;
            label_Pass.Location = new Point(23, 192);
            label_Pass.Name = "label_Pass";
            label_Pass.Size = new Size(57, 15);
            label_Pass.TabIndex = 10;
            label_Pass.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(148, 311);
            Controls.Add(label_Pass);
            Controls.Add(label_Username);
            Controls.Add(label_DB);
            Controls.Add(label_Port);
            Controls.Add(label_IP);
            Controls.Add(buttonSet);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button buttonSet;
        private Label label_IP;
        private Label label_Port;
        private Label label_DB;
        private Label label_Username;
        private Label label_Pass;
    }
}