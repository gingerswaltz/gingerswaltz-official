/// <summary>
///  author: Georgy Purtov
/// <summary>

namespace ChatBot;
using ChatBotFunc;
using System.Windows.Forms;

public partial class ChatForm : Form
{
    chatFunc botObject = new();
    
    public string username => botObject.GetUserName(); // ��������

    // ����������� �����
    public ChatForm()
    {
        //if (string.IsNullOrEmpty(username))              // ���� ������� ���� ������ �� �������
      //  {
        //    Environment.Exit(0);                         // ����� ��� ���������
      //  }
        InitializeComponent();
        chatTalkBox.Text = botObject.getHistory(); // �������� ������� ���� � ����������� ������ �� �����
        botObject.botHistory.Add($"������� ������� �����, {username}!"); // ������� � ������ ����� ����� �����������
        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]); // ����� ������� �� ����� ��� �� �����
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length;
        // scroll it automatically
        chatTalkBox.ScrollToCaret();
    }
    
    // ���������� ������� ������� ������
    private void talkBotButton_Click(object sender, EventArgs e) 
    {
        string s1 = chatTextBox.Text; // ���� �������
        botObject.botHistory.Add($"\n{username} says: " + s1 + "\n");
        if (string.IsNullOrEmpty(s1))
        {
            s1 = "???"; // ���� ������ �� �����, �� ������� ��� �� �����..
            botObject.botHistory.Add($"\n{username} says: " + s1 + "\n");
            chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
        }
        else // ����� ������� ������ � ����� �� ���� � ����������� ������, � � ������ �� �����

        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
        botObject.botHistory.Add(botObject.GetAnswer(s1) + "\n");
        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
    }

    // ������� �������� �����
    private void ChatForm_FormClosing(object sender, FormClosingEventArgs e) 
    {
        
        botObject.ToFile(); // ������� � ���� ������� ���� 
    }



    // ����� ����������� ��� ����� �������
    private void chatTalkBox_TextChanged(object sender, EventArgs e) // ������� ��������� ������ � ����������� ����
    {
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length; // ������� ��������� �� ����� ����� �����
        // scroll it automatically
        chatTalkBox.ScrollToCaret();
    }

    // ����� �������� enter
    private void chatTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter) { talkBotButton_Click(sender, e); }
    }
}