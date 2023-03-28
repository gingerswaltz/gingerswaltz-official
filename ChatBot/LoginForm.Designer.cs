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
            userInputBox.Location = new Point(12, 40);
            userInputBox.Name = "userInputBox";
            userInputBox.Size = new Size(145, 23);
            userInputBox.TabIndex = 0;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(30, 69);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(110, 49);
            buttonApply.TabIndex = 1;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // label_Input
            // 
            label_Input.AutoSize = true;
            label_Input.Location = new Point(12, 9);
            label_Input.Name = "label_Input";
            label_Input.Size = new Size(93, 15);
            label_Input.TabIndex = 2;
            label_Input.Text = "Input username:";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(171, 130);
            Controls.Add(label_Input);
            Controls.Add(buttonApply);
            Controls.Add(userInputBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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