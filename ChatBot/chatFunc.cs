/// <summary>
///  author: Georgy Purtov
///  сумма, умножение, разность, приветствия, загрузки картинки, получения текущего времени
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;


namespace ChatBotFunc
{
    // Класс чатбота
    public class chatFunc 
    {
        string path = "History.txt";
        
        
        public List<string> botHistory = new(); // История общения бота

        public void loadHistory(string path = "History.txt") // Метод загрузки истории общения с ботом
        {

  
            
                LoadFile(path);
         

        }
        public string getHistory() // Получаем историю бота
        {
            return botHistory[botHistory.Count - 1];
        }

        public chatFunc() // Конструктор объекта бота
        {
            loadHistory(path);
            botNameGen();
        }


        /// <summary>
        ///  Переменные:
        ///  имя бота
        ///  набор приветствий
        ///  набор ответов на вопрос "как дела"
        /// </summary>
        static readonly string[] 
       robotNames = { "R2D2", "C3-PO", "WALL-E", "EVA", "JARVIS", "INERTAN", "KHRAZ", "T-800", "PIP-BOY", "CHAPPIE", "ROBOCOP" };
        static readonly string[]
       helloNames = { "Hola", "Hello", "Привет", "Hiya" };
        static readonly string[]
       howruNames = { "Все отлично", "Alright Bro", "I'm fine", "Всё супер", "I'm OK" };

        public static readonly string patternSum = @"(сум|cev|\+)";
        public static readonly string patterMult = @"(произв|множ|\*|x|vyj;)";
        public static readonly string patternMinus = @"(разн|минус|\-)";
        public static readonly string patternHello = @"(прив|хай|здарова|здорова|йоу|хэй|hello|hi|hey)";
        public static readonly string patternHowRU = @"(дела|как ты|wassup|whats up)";
        public static readonly string patternPicUpload = @"(кач|груз|load|pic|изобр)";
        public static readonly string patternGetTime = @"(время|дата|час|time)";
        public static readonly string patternGetUrl = @"(?i)\b(?:https?://|www\d{0,3}[.]|[a-z0-9.\-]+[.][a-z]{2,4}/)(?:[^\s()<>]+|\(([^\s()<>]+|(\([^\s()<>]+\)))*\))+(?:\(([^\s()<>]+|(\([^\s()<>]+\)))*\)|[^\s`!()\[\]{};:'"".,<>?«»“”‘’])";
        public static readonly string patternClearHistory = @"(чист|удал|del)";
        public string bot = botNameGen();   // Ботнейм
        public string? username = "";       // Юзернейм, с возможностью хранить null("?").

        public void SetUserName(string s1) // Сеттер юзернейма
        {
            username = s1;
        }

        public string GetUserName() { return username; }  // Геттер юзернейма


        public string GetBotName() { return bot; }
        /// <summary>
        ///  Паттерны для регулярных выражений:
        ///  сумма, умножение, разность, приветствия, загрузки картинки, получения текущего времени
        /// </summary>
        public static Regex regexSum = new Regex(patternSum, RegexOptions.IgnoreCase);
        public static Regex regexMult = new Regex(patterMult, RegexOptions.IgnoreCase);
        public static Regex regexMinus = new Regex(patternMinus, RegexOptions.IgnoreCase);
        public static Regex regexHello = new Regex(patternHello, RegexOptions.IgnoreCase);
        public static Regex regexUpload = new Regex(patternPicUpload, RegexOptions.IgnoreCase);
        public static Regex regexTime = new Regex(patternGetTime, RegexOptions.IgnoreCase);
        public static Regex regexUrl = new Regex(patternGetUrl, RegexOptions.IgnoreCase);
        public static Regex regexClear = new Regex(patternClearHistory, RegexOptions.IgnoreCase);
        public static Regex regexHowRU = new Regex(patternHowRU, RegexOptions.IgnoreCase);
        //можно было бы сделать два списка, один хранит regex, другой хранит адреса методов соответствующие им
        
        public static string botNameGen() // Метод генерации рандомного имени бота
        {
            Random random = new Random();
            int Index = random.Next(robotNames.Length);
            return robotNames[Index];
        }


        public static void FindMatch(List<int> mas1, string s1)
        {

            foreach (char s in s1) // для каждого символа в полученной строке
            {
                int i = 0;
                int[] matches = Regex.Matches(s1, "\\d+") // формируем массив из совпадений, ищем только цифры
                    .Cast<Match>()                        // приводим к другому типу
                    .Select(x => int.Parse(x.Value))      // затем получаем целочисленное значение
                    .ToArray();                           // затем возвращаем их в массив
                if (i == matches.Length) break;           // проверка на выход из диапазона
                else
                    mas1.Add(matches[i]);                 // если всё ок, добавляем в лист..
                i++;
            }
            
        }

        /// todo: перебор матчей в отдельную процедуру, попробовать лямбду функцию (переменная типа sum и элемент массива)
        public static string CheckRegexSum(string s1) // Метод проверки арифметической операции
        {
            chatFunc bot1 = new();
            List<int> mas1 = new(); // В этот лист будем закидывать числа для выражений..
            var sum = 0;
            // проверка запроса на сумму
            if (regexSum.IsMatch(s1))
            {
                FindMatch(mas1, s1);
                for (int j = 0; j < mas1.Count; j++)
                {
                    sum += mas1[j];                           // суммируем..
                }
                mas1.Clear();                                 // очищаем массив на всякий случай
                return $"{bot1.GetBotName()} at {DateTime.Now}:Сумма: {sum}";  // возвращаем результат в контроллер
            }
            else return null;



            
          
        }


        /// Комментарии к проверке на сумму применимы к умножению и разности..

        public static string CheckRegexMult(string s1)
        {
            chatFunc bot1 = new();
            List<int> mas1 = new(); // В этот лист будем закидывать числа для выражений..
            var sum = 0;
            if (regexMult.IsMatch(s1))
            {
                FindMatch(mas1, s1);
                sum = mas1[0];
                for (int j = 1; j < mas1.Count; j++)
                {
                    sum *= mas1[j];
                }
                mas1.Clear();
                return $"{bot1.GetBotName()} at {DateTime.Now}:Умножение:{sum}";

            }
            else return null;
        }
    

        public static string CheckRegexMinus(string s1)
        {
            chatFunc bot1 = new();
            List<int> mas1 = new(); // В этот лист будем закидывать числа для выражений..
            var sum = 0;
            int i = 0;
            if (regexMinus.IsMatch(s1))
            {
                FindMatch(mas1, s1);
                sum = mas1[0];
                for (int j = 1; j < mas1.Count; j++)
                {
                    sum -= mas1[j];
                }

                mas1.Clear();
                return $"{bot1.GetBotName()} at {DateTime.Now}:Разность:{sum}";

            }

            else return null;

        }
    
        
        public static string CheckRegexHello(string s1) // Проверка запроса юзера на приветствие
        {
            chatFunc bot1 = new();
            Random random = new Random();
            int Index = random.Next(helloNames.Length);
            var result = $"{bot1.GetBotName()} at {DateTime.Now}: {helloNames[Index]}!";
            return result;
        }

        public static string CheckRegexUpload(string s1) // Проверка  запроса юзера на загрузку чего либо
        {
            chatFunc bot1 = new();
            WebClient client = new(); // создадим объект взаимодействия с сетью
            string fileName = "file";  // название файла
                                      //   string link = regexUrl.Matches(s1).ToString();
            var link = regexUrl.Matches(s1) // переменная link, явно приводится к типу Match, затем оттуда выбирается ссылка, и заносится в строковый массив
   .Cast<Match>()
   .Select(m => m.Value)
   .ToArray();


            if (link.Length == 0) {return $"{bot1.GetBotName()} at {DateTime.Now}:Ссылка некорректна";}
            string result = "";
            if (string.IsNullOrEmpty(link[0]) || link[0].ToUpper() == " " || !regexUrl.IsMatch(s1)) // Если строка пустая или ссылка не та
            {
                return $"{bot1.GetBotName()} at {DateTime.Now}:Ссылка некорректна";
            }

            try
            {
                Uri uri = new Uri(link[0]);
                client.DownloadFileAsync(uri, fileName);
            }
            catch(WebException ex) { 
                return $"{bot1.GetBotName()} at {DateTime.Now}:{ex.Message}"; 
            }
                                                                                         
            result += ($"{bot1.GetBotName()} at {DateTime.Now}: Успешно загружен файл \"{fileName}\" из \"{link[0]}\"" + '\n');                           // Покажем на форме что и откуда скачали
            result += ($"{bot1.GetBotName()} at {DateTime.Now}: Загруженный файл сохранен в следующей папке: {Application.StartupPath}" + '\n'); // Покажем куда

            return result;


        }

        public static string CheckRegexTime(string s1) // Проверка  запроса юзера на получение текущей даты
        {
            chatFunc bot1 = new();
            return $"{bot1.GetBotName()} replies: {DateTime.Now}";
        }


        public static string CheckRegexHowRU(string s1) // Проверка запроса на вопрос Как дела
        {
            chatFunc bot1 = new();
            Random random = new Random();
            int Index = random.Next(howruNames.Length);
            return $"{bot1.GetBotName()} at {DateTime.Now}: {howruNames[Index]}";
        }



        public static string CheckClearHistory(string s1, string path) // Проверка запроса на очистку истории
        {
            chatFunc bot1 = new();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(string.Empty);
            }
            return $"{bot1.GetUserName()} at {DateTime.Now}: Файл истории очищен";
        }



        // todo: from list , nonstatic
        public void ToFile() // Загрузка истории в файл
        {
            if (!File.Exists(path)) { File.Create(path); }

            List<string> text = botHistory;

            // добавление в файл
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("***LAST SESSION***\n" + $"{DateTime.Now}\n" + text[text.Count-1]);
            }

        }
       
       // to list , nonstatic
        public void LoadFile(string path) // Загрузка истории из файла
        {
            if (!File.Exists(path)) { File.Create(path); }

            // чтение
            using (StreamReader reader = new StreamReader(path))
            {
                botHistory.Add(reader.ReadToEnd());
            }
            
        }


        /// todo: добавлять в историю , обращаясь к предпоследнему(запрос юзера) и последнему(ответ)
        public string GetAnswer(string s1) // "Умный" метод, определяющий что нужно пользователю
        {
            if (string.IsNullOrEmpty(s1)) return $"{bot} at {DateTime.Now}:Я не понимаю вас...";
            else 
            if (regexHello.IsMatch(s1)) return CheckRegexHello(s1);
            else
                if (regexHowRU.IsMatch(s1)) return CheckRegexHowRU(s1);
            else
                if (regexTime.IsMatch(s1)) return CheckRegexTime(s1);
            else
                if (regexUpload.IsMatch(s1)) return CheckRegexUpload(s1);
            else
                if (regexSum.IsMatch(s1)) return CheckRegexSum(s1);
            else
                if (regexMult.IsMatch(s1)) return CheckRegexMult(s1);   
            else 
                if (regexMinus.IsMatch(s1)) return CheckRegexMinus(s1);
            else 
                if (regexClear.IsMatch(s1)) return CheckClearHistory(s1, "History.txt");
            else return $"{bot} at {DateTime.Now}:Я не знаю как это делать...";

        }

    }
}