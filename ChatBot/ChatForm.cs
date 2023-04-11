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

    // конструктор чат формы
    public ChatForm()
    {
        if (string.IsNullOrEmpty(username))              // Если логин закрыли на крестик
        {
          Environment.Exit(0);                         // �Убьем весь процесс
       }
        InitializeComponent();
        chatTalkBox.Text = botObject.getHistory(); // Получим историю общения
        botObject.botHistory.Add($"Доброго времени суток, {username}!"); // Выведем приветствие в лист и потом на форму
        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]); 
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length;
        // scroll it automatically
        chatTalkBox.ScrollToCaret();
    }
    
    // Обработчик события нажатия кнопки
    private void talkBotButton_Click(object sender, EventArgs e) 
    {
        string s1 = chatTextBox.Text; // получим текст с формы
        botObject.botHistory.Add($"\n{username} says: " + s1 + "\n");
        if (string.IsNullOrEmpty(s1))
        {
            s1 = "???"; // иначе выведем что мы не понимаем юзера
            botObject.botHistory.Add($"\n{username} says: " + s1 + "\n");
            chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
        }
        else // иначе выведем ответ в форму

        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
        botObject.botHistory.Add(botObject.GetAnswer(s1) + "\n");
        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
    }

    // закрытие формы
    private void ChatForm_FormClosing(object sender, FormClosingEventArgs e) 
    {
        
        botObject.ToFile(); // выведем в файл всю историю
    }



    // автоскролл при вводе текста
    private void chatTalkBox_TextChanged(object sender, EventArgs e) // ������� ��������� ������ � ����������� ����
    {
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length; // ������� ��������� �� ����� ����� �����
        // scroll it automatically
        chatTalkBox.ScrollToCaret();
    }

    // шорткат enter
    private void chatTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter) { talkBotButton_Click(sender, e); }
    }
}