namespace DatabaseApp
{
    partial class InputQueryForm
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
            InputBox_Textbox = new TextBox();
            buttonOk = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // InputBox_Textbox
            // 
            InputBox_Textbox.Location = new Point(12, 38);
            InputBox_Textbox.Name = "InputBox_Textbox";
            InputBox_Textbox.Size = new Size(208, 23);
            InputBox_Textbox.TabIndex = 0;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(12, 81);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(208, 37);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += OkButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Запрос:";
            // 
            // InputQueryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 130);
            Controls.Add(label1);
            Controls.Add(buttonOk);
            Controls.Add(InputBox_Textbox);
            Name = "InputQueryForm";
            Text = "Input Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputBox_Textbox;
        private Button buttonOk;
        private Label label1;
    }
}