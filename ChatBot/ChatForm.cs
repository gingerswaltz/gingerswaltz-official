namespace ChatBot;
using ChatBotFunc;
using System.Net;

public partial class ChatForm : Form
{
    string username = formLogin.UserName;
    string bot = chatFunc.botNameGen();


    public ChatForm()
    {
        if (string.IsNullOrEmpty(formLogin.UserName))
        {
            MessageBox.Show("Wrong name. Choose right next time");
            throw new Exception("Empty username");

        }

        InitializeComponent();
    }

    private void talkBotButton_Click(object sender, EventArgs e)
    {
        int result = 0;
        string s1 = Microsoft.VisualBasic.Interaction.InputBox("Введите ваш запрос: ", "Chat Bot Input");
        if (string.IsNullOrEmpty(s1)) s1 = "???";
        chatTalkBox.AppendText($"\n{username} says: " + s1 + "\n");

        if (chatFunc.CheckRegexHello(s1)) chatTalkBox.AppendText($"{bot} replies: Hello!" + "\n");
        else



            while (true)
            {
                if (chatFunc.CheckRegexTime(s1))
                {
                    chatTalkBox.AppendText($"{bot} replies: {DateTime.Now}" + '\n');
                    break;
                }
                else

                if (chatFunc.CheckRegexUpload(s1))
                {
                    WebClient client = new();
                    string fileName = "pic";
                    while (true)
                    {
                        string link = Microsoft.VisualBasic.Interaction.InputBox("Введите URL на картинку или оставьте пустой строку чтобы отменить операцию : ", "URL Input");
                        if (string.IsNullOrEmpty(link) || link.ToUpper() == " ")
                        {
                            result = -1;
                            break;
                        }
                        Uri uri = new Uri(link);

                        client.DownloadFileAsync(uri, "pic.jpg");
                        chatTalkBox.AppendText($"{bot} replies: Successfully Downloaded File \"{fileName}\" from \"{link}\"" + '\n');
                        chatTalkBox.AppendText($"{bot} replies: Downloaded file saved in the following file system folder: {Application.StartupPath}" + '\n');
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
                result = chatFunc.CheckRegexDigit(s1);
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
