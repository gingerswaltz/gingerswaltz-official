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
            userInputBox = new TextBox();
            buttonApply = new Button();
            label_Input = new Label();
            SuspendLayout();
            // 
            // userInputBox
            // 
            userInputBox.Location = new Point(22, 85);
            userInputBox.Margin = new Padding(6, 6, 6, 6);
            userInputBox.Name = "userInputBox";
            userInputBox.Size = new Size(266, 39);
            userInputBox.TabIndex = 0;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(56, 147);
            buttonApply.Margin = new Padding(6, 6, 6, 6);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(204, 105);
            buttonApply.TabIndex = 1;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // label_Input
            // 
            label_Input.AutoSize = true;
            label_Input.Location = new Point(22, 19);
            label_Input.Margin = new Padding(6, 0, 6, 0);
            label_Input.Name = "label_Input";
            label_Input.Size = new Size(187, 32);
            label_Input.TabIndex = 2;
            label_Input.Text = "Input username:";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 278);
            Controls.Add(label_Input);
            Controls.Add(buttonApply);
            Controls.Add(userInputBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(6, 6, 6, 6);
            Name = "formLogin";
            Text = "Login";
            FormClosed += formLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInputBox;
        private Button buttonApply;
        private Label label_Input;
    }
}