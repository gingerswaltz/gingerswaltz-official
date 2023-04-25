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
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.setConnect_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGridView
            // 
            this.dbGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dbGridView.Location = new System.Drawing.Point(1, 29);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.ReadOnly = true;
            this.dbGridView.RowTemplate.Height = 25;
            this.dbGridView.Size = new System.Drawing.Size(733, 351);
            this.dbGridView.TabIndex = 0;
            // 
            // setConnect_button
            // 
            this.setConnect_button.BackColor = System.Drawing.Color.Snow;
            this.setConnect_button.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setConnect_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.setConnect_button.Location = new System.Drawing.Point(789, 183);
            this.setConnect_button.Name = "setConnect_button";
            this.setConnect_button.Size = new System.Drawing.Size(133, 48);
            this.setConnect_button.TabIndex = 1;
            this.setConnect_button.Text = "Set Connection";
            this.setConnect_button.UseVisualStyleBackColor = false;
            this.setConnect_button.Click += new System.EventHandler(this.setConnect_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem,
            this.sortDataToolStripMenuItem,
            this.findDataToolStripMenuItem,
            this.deleteDataToolStripMenuItem,
            this.saveToToolStripMenuItem,
            this.loadDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addDataToolStripMenuItem.Text = "Add data";
            // 
            // sortDataToolStripMenuItem
            // 
            this.sortDataToolStripMenuItem.Name = "sortDataToolStripMenuItem";
            this.sortDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sortDataToolStripMenuItem.Text = "Sort data";
            // 
            // findDataToolStripMenuItem
            // 
            this.findDataToolStripMenuItem.Name = "findDataToolStripMenuItem";
            this.findDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.findDataToolStripMenuItem.Text = "Find data";
            // 
            // deleteDataToolStripMenuItem
            // 
            this.deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            this.deleteDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteDataToolStripMenuItem.Text = "Delete data";
            // 
            // saveToToolStripMenuItem
            // 
            this.saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToToolStripMenuItem.Text = "Save data";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadDataToolStripMenuItem.Text = "Load data";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(968, 379);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.setConnect_button);
            this.Controls.Add(this.dbGridView);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBForm";
            this.Text = "Data Base";
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dbGridView;
        private Button setConnect_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addDataToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem sortDataToolStripMenuItem;
        private ToolStripMenuItem findDataToolStripMenuItem;
        private ToolStripMenuItem saveToToolStripMenuItem;
        private ToolStripMenuItem deleteDataToolStripMenuItem;
        private ToolStripMenuItem loadDataToolStripMenuItem;
    }
}