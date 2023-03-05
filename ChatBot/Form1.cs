namespace ChatBot;
using System.Text.RegularExpressions;

public partial class ChatForm : Form
    {
    static readonly string pattern1 = @"(сум\w||cev\w||'+')";
    static readonly string pattern2 = @"(произв\w||множ\w||'*'||'x'||'vyj;')";
    static readonly string pattern3 = @"(разн\w||минус\w||'-')";

    Regex regexSum = new Regex(pattern1, RegexOptions.IgnoreCase);
    Regex regexMult = new Regex(pattern2, RegexOptions.IgnoreCase);
    Regex regexMinus = new Regex(pattern3, RegexOptions.IgnoreCase);
    /* using System;
 using System.Linq;
 using System.Text.RegularExpressions;

 class Program
 {
     static void Main(string[] args)
     {
         string[] str = { "fdsg123", "234 fgds*s**d*", "SsTyd %377" };

 }*/
    public ChatForm()
        {
            InitializeComponent();


    }

    private void talkBotButton_Click(object sender, EventArgs e)
        {
        var sum = 0;
        int i = 0;
        string s1=Microsoft.VisualBasic.Interaction.InputBox("Введите ваш запрос: ");
        chatTalkBox.AppendText("Введите ваш запрос: " + s1+"\n");
        List<int> mas1 = new();


        if (regexSum.IsMatch(s1))
        {
            foreach (char s in s1)
            {
                
                int[] matches = Regex.Matches(s1, "\\d+")
                    .Cast<Match>()
                    .Select(x => int.Parse(x.Value))
                    .ToArray();
                if (i == matches.Length) break;
                else
                mas1.Add(matches[i]);
                i++;
            }

            for (int j = 0; j < mas1.Count; j++)
            {
                sum += mas1[j];
            }
            chatTalkBox.AppendText($"Summa= {sum}\n");
        }
        else 
        
        if (regexMult.IsMatch(s1))
        {
            foreach (char s in s1)
            {

                int[] matches = Regex.Matches(s1, "\\d+")
                    .Cast<Match>()
                    .Select(x => int.Parse(x.Value))
                    .ToArray();
                if (i == matches.Length) break;
                else
                    mas1.Add(matches[i]);
                i++;
            }

            for (int j = 0; j < mas1.Count; j++)
            {
                sum *= mas1[j];
            }
            chatTalkBox.AppendText($"Multiply= {sum}\n");
        }
        else
        if (regexMinus.IsMatch(s1))
        {
            foreach (char s in s1)
            {

                int[] matches = Regex.Matches(s1, "\\d+")
                    .Cast<Match>()
                    .Select(x => int.Parse(x.Value))
                    .ToArray();
                if (i == matches.Length) break;
                else
                    mas1.Add(matches[i]);
                i++;
            }

            for (int j = 0; j < mas1.Count; j++)
            {
                sum -= mas1[j];
            }
            chatTalkBox.AppendText($"Разность= {sum}\n");
        }

        else  chatTalkBox.AppendText("Я не умею этого делать =(" + "\n");
            
        

        
  
           
        
    }
    }
