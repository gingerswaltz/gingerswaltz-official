namespace DatabaseApp
{
    partial class DBForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dbGridView = new DataGridView();
            setConnect_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dbGridView).BeginInit();
            SuspendLayout();
            // 
            // dbGridView
            // 
            dbGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbGridView.Location = new Point(1, 1);
            dbGridView.Name = "dbGridView";
            dbGridView.RowTemplate.Height = 25;
            dbGridView.Size = new Size(596, 351);
            dbGridView.TabIndex = 0;
            // 
            // setConnect_button
            // 
            setConnect_button.Location = new Point(673, 160);
            setConnect_button.Name = "setConnect_button";
            setConnect_button.Size = new Size(116, 45);
            setConnect_button.TabIndex = 1;
            setConnect_button.Text = "Set Connection";
            setConnect_button.UseVisualStyleBackColor = true;
            setConnect_button.Click += setConnect_button_Click;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 355);
            Controls.Add(setConnect_button);
            Controls.Add(dbGridView);
            Name = "DBForm";
            Text = "Data Base";
            ((System.ComponentModel.ISupportInitialize)dbGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dbGridView;
        private Button setConnect_button;
    }
}