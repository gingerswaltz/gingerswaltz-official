namespace ChatBot
{
    partial class ChatForm
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
            this.chatTalkBox = new System.Windows.Forms.RichTextBox();
            this.fileMenu = new System.Windows.Forms.MenuStrip();
            this.talkBotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatTalkBox
            // 
            this.chatTalkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatTalkBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chatTalkBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatTalkBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chatTalkBox.Location = new System.Drawing.Point(0, 0);
            this.chatTalkBox.Name = "chatTalkBox";
            this.chatTalkBox.ReadOnly = true;
            this.chatTalkBox.Size = new System.Drawing.Size(262, 363);
            this.chatTalkBox.TabIndex = 0;
            this.chatTalkBox.TabStop = false;
            this.chatTalkBox.Text = " Доброго времени суток!";
            // 
            // fileMenu
            // 
            this.fileMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.fileMenu.Location = new System.Drawing.Point(0, 0);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fileMenu.Size = new System.Drawing.Size(262, 24);
            this.fileMenu.TabIndex = 1;
            this.fileMenu.Text = "Файл";
            // 
            // talkBotButton
            // 
            this.talkBotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.talkBotButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.talkBotButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.talkBotButton.Location = new System.Drawing.Point(0, 360);
            this.talkBotButton.Name = "talkBotButton";
            this.talkBotButton.Size = new System.Drawing.Size(262, 121);
            this.talkBotButton.TabIndex = 2;
            this.talkBotButton.Text = "Поговорить с ботом";
            this.talkBotButton.UseVisualStyleBackColor = false;
            this.talkBotButton.Click += new System.EventHandler(this.talkBotButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 481);
            this.Controls.Add(this.talkBotButton);
            this.Controls.Add(this.chatTalkBox);
            this.Controls.Add(this.fileMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.fileMenu;
            this.Name = "ChatForm";
            this.Text = "ЧатБот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox chatTalkBox;
        private MenuStrip fileMenu;
        private Button talkBotButton;
    }
}