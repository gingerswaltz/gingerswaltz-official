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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            setConnectionToolStripMenuItem = new ToolStripMenuItem();
            refreshBaseToolStripMenuItem = new ToolStripMenuItem();
            addDataToolStripMenuItem = new ToolStripMenuItem();
            saveToToolStripMenuItem = new ToolStripMenuItem();
            loadDataToolStripMenuItem = new ToolStripMenuItem();
            findDataToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            labelState = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dbGridView).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dbGridView
            // 
            dbGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbGridView.BackgroundColor = SystemColors.GradientInactiveCaption;
            dbGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbGridView.GridColor = SystemColors.ButtonFace;
            dbGridView.Location = new Point(0, 24);
            dbGridView.Margin = new Padding(0);
            dbGridView.Name = "dbGridView";
            dbGridView.ReadOnly = true;
            dbGridView.RowTemplate.Height = 25;
            dbGridView.Size = new Size(732, 355);
            dbGridView.TabIndex = 0;
            dbGridView.KeyDown += dbGridView_KeyDown;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(732, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setConnectionToolStripMenuItem, refreshBaseToolStripMenuItem, addDataToolStripMenuItem, saveToToolStripMenuItem, loadDataToolStripMenuItem, findDataToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // setConnectionToolStripMenuItem
            // 
            setConnectionToolStripMenuItem.Name = "setConnectionToolStripMenuItem";
            setConnectionToolStripMenuItem.Size = new Size(155, 22);
            setConnectionToolStripMenuItem.Text = "Set Connection";
            setConnectionToolStripMenuItem.Click += setConnect_button_Click;
            // 
            // refreshBaseToolStripMenuItem
            // 
            refreshBaseToolStripMenuItem.Name = "refreshBaseToolStripMenuItem";
            refreshBaseToolStripMenuItem.Size = new Size(155, 22);
            refreshBaseToolStripMenuItem.Text = "Refresh Base";
            refreshBaseToolStripMenuItem.Click += refreshBaseToolStripMenuItem_Click;
            // 
            // addDataToolStripMenuItem
            // 
            addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            addDataToolStripMenuItem.Size = new Size(155, 22);
            addDataToolStripMenuItem.Text = "Add data";
            addDataToolStripMenuItem.Click += addDataToolStripMenuItem_Click;
            // 
            // saveToToolStripMenuItem
            // 
            saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            saveToToolStripMenuItem.Size = new Size(155, 22);
            saveToToolStripMenuItem.Text = "Save data";
            saveToToolStripMenuItem.Click += saveToToolStripMenuItem_Click;
            // 
            // loadDataToolStripMenuItem
            // 
            loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            loadDataToolStripMenuItem.Size = new Size(155, 22);
            loadDataToolStripMenuItem.Text = "Load data";
            loadDataToolStripMenuItem.Click += loadDataToolStripMenuItem_Click;
            // 
            // findDataToolStripMenuItem
            // 
            findDataToolStripMenuItem.Name = "findDataToolStripMenuItem";
            findDataToolStripMenuItem.Size = new Size(155, 22);
            findDataToolStripMenuItem.Text = "Find name";
            findDataToolStripMenuItem.Click += findDataToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
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
            labelState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelState.BackColor = Color.Lavender;
            labelState.BorderStyle = BorderStyle.FixedSingle;
            labelState.Location = new Point(572, 0);
            labelState.Margin = new Padding(3, 0, 0, 0);
            labelState.MinimumSize = new Size(102, 24);
            labelState.Name = "labelState";
            labelState.Size = new Size(160, 24);
            labelState.TabIndex = 3;
            labelState.TabStop = true;
            labelState.Text = "Состояние БД";
            labelState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 357);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(732, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = Color.Lavender;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // DBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(732, 379);
            Controls.Add(statusStrip1);
            Controls.Add(labelState);
            Controls.Add(menuStrip1);
            Controls.Add(dbGridView);
            Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "DBForm";
            Text = "Data Base";
            FormClosing += DBForm_FormClosing;
            Load += DBForm_Load;
            KeyDown += DBForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dbGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dbGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addDataToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem findDataToolStripMenuItem;
        private ToolStripMenuItem saveToToolStripMenuItem;
        private ToolStripMenuItem loadDataToolStripMenuItem;
        private Label labelState;
        private ToolStripMenuItem setConnectionToolStripMenuItem;
        private ToolStripMenuItem refreshBaseToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}