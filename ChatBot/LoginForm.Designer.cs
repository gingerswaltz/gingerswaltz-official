namespace ChatBot
{
    partial class formLogin : Form
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
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label_Input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInputBox
            // 
            this.userInputBox.Location = new System.Drawing.Point(12, 40);
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(145, 23);
            this.userInputBox.TabIndex = 0;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(30, 69);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(110, 49);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.Location = new System.Drawing.Point(12, 9);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(93, 15);
            this.label_Input.TabIndex = 2;
            this.label_Input.Text = "Input username:";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 130);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.userInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox userInputBox;
        private Button buttonApply;
        private Label label_Input;
    }
}