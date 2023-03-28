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
            chatTalkBox = new RichTextBox();
            talkBotButton = new Button();
            chatTextBox = new TextBox();
            SuspendLayout();
            // 
            // chatTalkBox
            // 
            chatTalkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatTalkBox.BackColor = SystemColors.ControlLight;
            chatTalkBox.BorderStyle = BorderStyle.None;
            chatTalkBox.Font = new Font("Nirmala UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            chatTalkBox.ForeColor = SystemColors.ActiveCaptionText;
            chatTalkBox.Location = new Point(0, 0);
            chatTalkBox.Name = "chatTalkBox";
            chatTalkBox.ReadOnly = true;
            chatTalkBox.Size = new Size(415, 557);
            chatTalkBox.TabIndex = 0;
            chatTalkBox.TabStop = false;
            chatTalkBox.Text = "";
            chatTalkBox.TextChanged += chatTalkBox_TextChanged;
            // 
            // talkBotButton
            // 
            talkBotButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            talkBotButton.BackColor = Color.PaleTurquoise;
            talkBotButton.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            talkBotButton.Location = new Point(0, 649);
            talkBotButton.Name = "talkBotButton";
            talkBotButton.Size = new Size(415, 174);
            talkBotButton.TabIndex = 2;
            talkBotButton.Text = "&Поговорить с ботом";
            talkBotButton.UseVisualStyleBackColor = false;
            talkBotButton.Click += talkBotButton_Click;
            // 
            // chatTextBox
            // 
            chatTextBox.AcceptsReturn = true;
            chatTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatTextBox.BorderStyle = BorderStyle.FixedSingle;
            chatTextBox.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chatTextBox.Location = new Point(0, 558);
            chatTextBox.Multiline = true;
            chatTextBox.Name = "chatTextBox";
            chatTextBox.RightToLeft = RightToLeft.No;
            chatTextBox.Size = new Size(415, 94);
            chatTextBox.TabIndex = 3;
            chatTextBox.Text = "Привет!";
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(415, 825);
            Controls.Add(chatTextBox);
            Controls.Add(chatTalkBox);
            Controls.Add(talkBotButton);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ChatForm";
            Text = "ЧатБот";
            FormClosing += ChatForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox chatTalkBox;
        private Button talkBotButton;
        private TextBox chatTextBox;
    }
}