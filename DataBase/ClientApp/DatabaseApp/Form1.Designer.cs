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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addDataToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dbGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dbGridView
            // 
            dbGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dbGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbGridView.Location = new Point(1, 27);
            dbGridView.Name = "dbGridView";
            dbGridView.ReadOnly = true;
            dbGridView.RowTemplate.Height = 25;
            dbGridView.Size = new Size(642, 325);
            dbGridView.TabIndex = 0;
            // 
            // setConnect_button
            // 
            setConnect_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            setConnect_button.Location = new Point(693, 167);
            setConnect_button.Name = "setConnect_button";
            setConnect_button.Size = new Size(116, 45);
            setConnect_button.TabIndex = 1;
            setConnect_button.Text = "Set Connection";
            setConnect_button.UseVisualStyleBackColor = true;
            setConnect_button.Click += setConnect_button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(847, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addDataToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addDataToolStripMenuItem
            // 
            addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            addDataToolStripMenuItem.Size = new Size(122, 22);
            addDataToolStripMenuItem.Text = "Add data";
            addDataToolStripMenuItem.Click += addDataToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 355);
            Controls.Add(menuStrip1);
            Controls.Add(setConnect_button);
            Controls.Add(dbGridView);
            MainMenuStrip = menuStrip1;
            Name = "DBForm";
            Text = "Data Base";
            ((System.ComponentModel.ISupportInitialize)dbGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dbGridView;
        private Button setConnect_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addDataToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}