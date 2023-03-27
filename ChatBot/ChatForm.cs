/// <summary>
///  author: Georgy Purtov
/// <summary>

namespace ChatBot;
using ChatBotFunc;
using System.Windows.Forms;

public partial class ChatForm : Form
{

    public static string username = formLogin.UserName; // Юзернейм


    public ChatForm()
    {
        if (string.IsNullOrEmpty(formLogin.UserName))              // Если закрыли окно логина на крестик
        {
            Environment.Exit(0);
        }
        InitializeComponent();
        chatTalkBox.Text = chatFunc.LoadFile("History.txt");
        chatTalkBox.AppendText($"Доброго времени суток, {username}!");
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length;
        // scroll it automatically
        chatTalkBox.ScrollToCaret();
    }

    private void talkBotButton_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки
    {
        string s1 = chatTextBox.Text; // ввод запроса
        if (string.IsNullOrEmpty(s1))
        {
            s1 = "???"; // Если ничего не ввели, то покажем это на форме..
            chatTalkBox.AppendText($"\n{username} says: " + s1 + "\n");
        }
        else
        
        chatTalkBox.AppendText($"\n{username} says: " + s1 + "\n");

        chatTalkBox.AppendText(chatFunc.GetAnswer(s1) + "\n");

    }

    private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        chatFunc.ToFile(chatTalkBox.Text + $"\n***LAST SESSION END***\n", "History.txt");
    }



   
    private void chatTalkBox_TextChanged(object sender, EventArgs e)
    {
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length;
        // scroll it automatically
        chatTalkBox.ScrollToCaret();
    }
}