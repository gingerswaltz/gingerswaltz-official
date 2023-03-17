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
            this.talkBotButton = new System.Windows.Forms.Button();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chatTalkBox
            // 
            this.chatTalkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatTalkBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chatTalkBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatTalkBox.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatTalkBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chatTalkBox.Location = new System.Drawing.Point(0, 0);
            this.chatTalkBox.Name = "chatTalkBox";
            this.chatTalkBox.ReadOnly = true;
            this.chatTalkBox.Size = new System.Drawing.Size(283, 339);
            this.chatTalkBox.TabIndex = 0;
            this.chatTalkBox.TabStop = false;
            this.chatTalkBox.Text = "";
            this.chatTalkBox.TextChanged += new System.EventHandler(this.chatTalkBox_TextChanged);
            // 
            // talkBotButton
            // 
            this.talkBotButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.talkBotButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.talkBotButton.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.talkBotButton.Location = new System.Drawing.Point(0, 403);
            this.talkBotButton.Name = "talkBotButton";
            this.talkBotButton.Size = new System.Drawing.Size(283, 65);
            this.talkBotButton.TabIndex = 2;
            this.talkBotButton.Text = "&Поговорить с ботом";
            this.talkBotButton.UseVisualStyleBackColor = false;
            this.talkBotButton.Click += new System.EventHandler(this.talkBotButton_Click);
            // 
            // chatTextBox
            // 
            this.chatTextBox.AcceptsReturn = true;
            this.chatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatTextBox.Location = new System.Drawing.Point(0, 335);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chatTextBox.Size = new System.Drawing.Size(283, 71);
            this.chatTextBox.TabIndex = 3;
            this.chatTextBox.Text = "Привет!";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 470);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.chatTalkBox);
            this.Controls.Add(this.talkBotButton);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChatForm";
            this.Text = "ЧатБот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox chatTalkBox;
        private Button talkBotButton;
        private TextBox chatTextBox;
    }
}