namespace ChatBot;
using ChatBotFunc;
using System.Net;

public partial class ChatForm : Form
{
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
    }

    private void talkBotButton_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки
    {
        int result = 0;

        string s1 = Microsoft.VisualBasic.Interaction.InputBox("Введите ваш запрос: ", "Chat Bot Input"); // Вызов инпут бокса ввода запроса
        if (string.IsNullOrEmpty(s1)) s1 = "???"; // Если ничего не ввели, то покажем это на форме..
        chatTalkBox.AppendText($"\n{username} says: " + s1 + "\n");

        if (chatFunc.CheckRegexHello(s1)) chatTalkBox.AppendText($"{bot} replies: Hello!" + "\n"); // Если поздоровались, то поздороваемся в ответ
        else



            while (true) // Бесконечный цикл..
            {
                if (chatFunc.CheckRegexTime(s1)) // Если запрос пользователя время, покажем время
                {
                    chatTalkBox.AppendText($"{bot} replies: {DateTime.Now}" + '\n');
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
                            result = -1;
                            break;
                        }
                        Uri uri = new Uri(link); // если всё ок, то из инпут бокса получаем ссылку на файл

                        client.DownloadFileAsync(uri, "pic.jpg");                                                                                                // Скачиваем файл по ссылке асинхронно
                        chatTalkBox.AppendText($"{bot} replies: Successfully Downloaded File \"{fileName}\" from \"{link}\"" + '\n');                           // Покажем на форме что и откуда скачали
                        chatTalkBox.AppendText($"{bot} replies: Downloaded file saved in the following file system folder: {Application.StartupPath}" + '\n'); // Покажем куда
                    }
                    if (result == -1)
                    {
                        chatTalkBox.AppendText($"{bot} replies: Кажется, вы отменили скачку. " + '\n'); 
                        break;
                    }
                }
                else
                {

                }
                result = chatFunc.CheckRegexDigit(s1); // Получаем результат расчётов..
                if (result == -1)
                {
                    chatTalkBox.AppendText($"{bot} replies: Я не понимаю вас.. " + '\n');
                    break;
                }
                else
                if (chatFunc.regexSum.IsMatch(s1))
                {
                    chatTalkBox.AppendText($"{bot} replies: Summa= {result}\n");
                    break;
                }
                else
                if (chatFunc.regexMult.IsMatch(s1))
                {
                    chatTalkBox.AppendText($"{bot} replies: Multiply= {result}" + '\n');
                    break;
                }
                else
                            if (chatFunc.regexMinus.IsMatch(s1))
                {
                    chatTalkBox.AppendText($"{bot} replies: Разность= {result}" + '\n');
                    break;


                }


            }





    }


}
