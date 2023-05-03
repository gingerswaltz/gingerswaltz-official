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
            findDataToolStripMenuItem = new ToolStripMenuItem();
            saveToToolStripMenuItem = new ToolStripMenuItem();
            loadDataToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            labelState = new Label();
            ((System.ComponentModel.ISupportInitialize)dbGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dbGridView
            // 
            dbGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dbGridView.BackgroundColor = SystemColors.GradientInactiveCaption;
            dbGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbGridView.GridColor = SystemColors.ButtonFace;
            dbGridView.Location = new Point(0, 24);
            dbGridView.Margin = new Padding(5, 0, 3, 0);
            dbGridView.Name = "dbGridView";
            dbGridView.ReadOnly = true;
            dbGridView.RowTemplate.Height = 25;
            dbGridView.Size = new Size(735, 355);
            dbGridView.TabIndex = 0;
            dbGridView.CellClick += dbGridView_CellClick;
            dbGridView.KeyDown += dbGridView_KeyDown;
            // 
            // setConnect_button
            // 
            setConnect_button.BackColor = Color.Snow;
            setConnect_button.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            setConnect_button.ForeColor = Color.DarkBlue;
            setConnect_button.Location = new Point(789, 173);
            setConnect_button.Name = "setConnect_button";
            setConnect_button.Size = new Size(133, 48);
            setConnect_button.TabIndex = 1;
            setConnect_button.Text = "Set Connection";
            setConnect_button.UseVisualStyleBackColor = false;
            setConnect_button.Click += setConnect_button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(968, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addDataToolStripMenuItem, findDataToolStripMenuItem, saveToToolStripMenuItem, loadDataToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addDataToolStripMenuItem
            // 
            addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            addDataToolStripMenuItem.Size = new Size(126, 22);
            addDataToolStripMenuItem.Text = "Add data";
            addDataToolStripMenuItem.Click += addDataToolStripMenuItem_Click;
            // 
            // findDataToolStripMenuItem
            // 
            findDataToolStripMenuItem.Name = "findDataToolStripMenuItem";
            findDataToolStripMenuItem.Size = new Size(126, 22);
            findDataToolStripMenuItem.Text = "Find data";
            // 
            // saveToToolStripMenuItem
            // 
            saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            saveToToolStripMenuItem.Size = new Size(126, 22);
            saveToToolStripMenuItem.Text = "Save data";
            saveToToolStripMenuItem.Click += saveToToolStripMenuItem_Click;
            // 
            // loadDataToolStripMenuItem
            // 
            loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            loadDataToolStripMenuItem.Size = new Size(126, 22);
            loadDataToolStripMenuItem.Text = "Load data";
            loadDataToolStripMenuItem.Click += loadDataToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // labelState
            // 
            labelState.BackColor = Color.Lavender;
            labelState.Location = new Point(861, 24);
            labelState.Margin = new Padding(3, 0, 0, 0);
            labelState.Name = "labelState";
            labelState.Size = new Size(107, 22);
            labelState.TabIndex = 3;
            labelState.TabStop = true;
            labelState.Text = "Состояние БД";
            labelState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(968, 379);
            Controls.Add(labelState);
            Controls.Add(menuStrip1);
            Controls.Add(setConnect_button);
            Controls.Add(dbGridView);
            Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "DBForm";
            Text = "Data Base";
            KeyDown += DBForm_KeyDown;
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
        private ToolStripMenuItem findDataToolStripMenuItem;
        private ToolStripMenuItem saveToToolStripMenuItem;
        private ToolStripMenuItem loadDataToolStripMenuItem;
        private Label labelState;
    }
}