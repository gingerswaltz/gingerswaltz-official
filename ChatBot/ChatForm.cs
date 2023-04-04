/// <summary>
///  author: Georgy Purtov
/// <summary>

namespace ChatBot;
using ChatBotFunc;
using System.Windows.Forms;

public partial class ChatForm : Form
{

    public string username = chatFunc.GetUserName(); // Юзернейм
    chatFunc botObject = new();


    public ChatForm()
    {
        if (string.IsNullOrEmpty(username))              // Если закрыли окно логина на крестик
        {
            Environment.Exit(0);                         // Убьем всю программу
        }
        InitializeComponent();
        chatTalkBox.Text = botObject.getHistory(); // Получаем историю бота с оперативной памяти из листа
        botObject.botHistory.Add($"Доброго времени суток, {username}!"); // Добавим в ячейку листа фразу приветствия
        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]); // Потом добавим из листа уже на форму
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length;
        // scroll it automatically
        chatTalkBox.ScrollToCaret();
    }

    private void talkBotButton_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки
    {
        string s1 = chatTextBox.Text; // ввод запроса
        botObject.botHistory.Add($"\n{username} says: " + s1 + "\n");
        if (string.IsNullOrEmpty(s1))
        {
            s1 = "???"; // Если ничего не ввели, то покажем это на форме..
            botObject.botHistory.Add($"\n{username} says: " + s1 + "\n");
            chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
        }
        else
            chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
        botObject.botHistory.Add(chatFunc.GetAnswer(s1) + "\n");
        chatTalkBox.AppendText(botObject.botHistory[botObject.botHistory.Count - 1]);
    }

    private void ChatForm_FormClosing(object sender, FormClosingEventArgs e) // Событие перед закрытием формы
    {
        chatFunc.ToFile(chatTalkBox.Text + $"\n***LAST SESSION END***\n", "History.txt"); // Закинем в файл историю бота 
    }




    private void chatTalkBox_TextChanged(object sender, EventArgs e) // Событие изменения текста и автоскролла вниз
    {
        chatTalkBox.SelectionStart = chatTalkBox.Text.Length; // Каретку указателя на конец текст бокса
        // scroll it automatically
        chatTalkBox.ScrollToCaret();                           
    }
}