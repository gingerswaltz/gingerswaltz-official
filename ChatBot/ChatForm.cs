// todo: doc
namespace ChatBot;
using ChatBotFunc;
using System.Net;
public partial class ChatForm : Form
{   

    // todo: to bot
    string username = formLogin.UserName; // Юзернейм
    string bot = chatFunc.botNameGen();   // Ботнейм


    public ChatForm()
    {
        if (string.IsNullOrEmpty(formLogin.UserName))              // Если не ввели имя
        {
            MessageBox.Show("Wrong name. Choose right next time"); // То сообщим и бросим исключение
            throw new Exception("Empty username");
        }

        InitializeComponent();
        

        chatTalkBox.Text = chatFunc.LoadFile();
        chatTalkBox.AppendText($"Доброго времени суток, {username}!");

    }

    // todo: to bot
    private void talkBotButton_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки
    {
        int result = 0;
        string s1 = Microsoft.VisualBasic.Interaction.InputBox("Введите ваш запрос: ", "Chat Bot Input"); // Вызов инпут бокса ввода запроса
        if (string.IsNullOrEmpty(s1)) s1 = "???"; // Если ничего не ввели, то покажем это на форме..
        chatTalkBox.AppendText($"\n{username} says: " + s1 + "\n");

        if (chatFunc.CheckRegexHello(s1)) chatTalkBox.AppendText($"{bot} at {DateTime.Now}: Hello!" + "\n"); // Если поздоровались, то поздороваемся в ответ
        else


            while (true) // Бесконечный цикл..
            {
                if (chatFunc.CheckRegexTime(s1)) // Если запрос пользователя время, покажем время
                {
                    chatTalkBox.AppendText($"{bot} at {DateTime.Now}: Time Now:: {DateTime.Now}" + '\n');
                    break;
                }
                else

                if (chatFunc.CheckRegexUpload(s1)) // Если запрос пользователя  скачать картинку, то
                {
                    WebClient client = new(); // создадим объект взаимодействия с сетью
                    string fileName = "pic";  // название файла
                    while (true)  // бесконечный цикл
                    {
                        string link = Microsoft.
                                      VisualBasic.
                                      Interaction.
                                      InputBox("Введите URL на картинку или оставьте пустой строку чтобы отменить операцию : ", "URL Input");


                        if (string.IsNullOrEmpty(link) || link.ToUpper() == " ") // Если строка пустая или юзер нажал отмена в инпут боксе
                        {
                            result = -1; // флаговая переменная, запишем "ошибку"
                            break;
                        }
                        Uri uri = new Uri(link); // если всё ок, то из инпут бокса получаем ссылку на файл

                        client.DownloadFileAsync(uri, "pic.jpg");                                                                                                // Скачиваем файл по ссылке асинхронно
                        chatTalkBox.AppendText($"{bot} at {DateTime.Now}: Successfully Downloaded File \"{fileName}\" from \"{link}\"" + '\n');                           // Покажем на форме что и откуда скачали
                        chatTalkBox.AppendText($"{bot} at {DateTime.Now}: Downloaded file saved in the following file system folder: {Application.StartupPath}" + '\n'); // Покажем куда
                    }
                    if (result == -1) // если флаг в ошибке
                    {
                        chatTalkBox.AppendText($"{bot} at {DateTime.Now}: Кажется, вы отменили скачку. " + '\n');
                        break;
                    }
                }
                else
                
                chatTalkBox.AppendText($"{bot} at {DateTime.Now}+{chatFunc.CheckRegexDigit(s1)}"); // Получаем результат расчётов..




            }
    }

    private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        chatFunc.ToFile(chatTalkBox.Text + $"\n***LAST SESSION END***\n");
    }

    private void ChatForm_Load(object sender, EventArgs e)
    {


    }
}