namespace BankApp
{
    partial class BankApp_Main
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
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.licTextBox = new System.Windows.Forms.TextBox();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.procTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeTextBox.Location = new System.Drawing.Point(120, 29);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(118, 23);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.Text = "1111";
            // 
            // licTextBox
            // 
            this.licTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.licTextBox.Location = new System.Drawing.Point(120, 58);
            this.licTextBox.Name = "licTextBox";
            this.licTextBox.Size = new System.Drawing.Size(118, 23);
            this.licTextBox.TabIndex = 1;
            this.licTextBox.Text = "2222";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moneyTextBox.Location = new System.Drawing.Point(120, 87);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(118, 23);
            this.moneyTextBox.TabIndex = 2;
            this.moneyTextBox.Text = "1000";
            // 
            // procTextBox
            // 
            this.procTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.procTextBox.Location = new System.Drawing.Point(120, 116);
            this.procTextBox.Name = "procTextBox";
            this.procTextBox.Size = new System.Drawing.Size(118, 23);
            this.procTextBox.TabIndex = 3;
            this.procTextBox.Text = "10";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сode digits";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personal digit";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cash amount";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Procents (<10%)";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(271, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 110);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeNumColumn,
            this.licNumColumn,
            this.moneyColumn,
            this.procColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(446, 162);
            this.dataGridView1.TabIndex = 9;
            // 
            // codeNumColumn
            // 
            this.codeNumColumn.HeaderText = "Code Digits";
            this.codeNumColumn.Name = "codeNumColumn";
            this.codeNumColumn.ReadOnly = true;
            // 
            // licNumColumn
            // 
            this.licNumColumn.HeaderText = "Personal Digits";
            this.licNumColumn.Name = "licNumColumn";
            this.licNumColumn.ReadOnly = true;
            // 
            // moneyColumn
            // 
            this.moneyColumn.HeaderText = "Money";
            this.moneyColumn.Name = "moneyColumn";
            this.moneyColumn.ReadOnly = true;
            // 
            // procColumn
            // 
            this.procColumn.HeaderText = "Procents";
            this.procColumn.Name = "procColumn";
            this.procColumn.ReadOnly = true;
            // 
            // BankApp_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 331);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procTextBox);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.licTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Name = "BankApp_Main";
            this.Text = "Bank Deposit Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox codeTextBox;
        private TextBox licTextBox;
        private TextBox moneyTextBox;
        private TextBox procTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codeNumColumn;
        private DataGridViewTextBoxColumn licNumColumn;
        private DataGridViewTextBoxColumn moneyColumn;
        private DataGridViewTextBoxColumn procColumn;
    }
}