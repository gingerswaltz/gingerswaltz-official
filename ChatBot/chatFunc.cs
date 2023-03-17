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
    //
    public static class chatFunc
    {



        static
            string[]
            robotNames = { "R2D2", "C3-PO", "WALL-E", "EVA", "JARVIS", "INERTAN", "KHRAZ", "T-800", "PIP-BOY", "CHAPPIE", "ROBOCOP" };
        static readonly string[]
       helloNames = { "Hola", "Hello", "Привет", "Hiya" };
        static readonly string[]
       howruNames= { "Все отлично", "Alright Bro", "I'm fine", "Всё супер", "I'm OK" };

        public static readonly string patternSum = @"(сум|cev|\+)";
        public static readonly string patterMult = @"(произв|множ|\*|x|vyj;)";
        public static readonly string patternMinus = @"(разн|минус|\-)";
        public static readonly string patternHello = @"(прив|хай|здарова|здорова|йоу|хэй|hello|hi|hey)";
        public static readonly string patternHowRU = @"(дела|как ты|wassup|whats up)";
        public static readonly string patternPicUpload = @"(кач|груз|load|pic|изобр)";
        public static readonly string patternGetTime = @"(время|дата|час|time)";
        public static readonly string patternGetUrl = @"(?i)\b(?:https?://|www\d{0,3}[.]|[a-z0-9.\-]+[.][a-z]{2,4}/)(?:[^\s()<>]+|\(([^\s()<>]+|(\([^\s()<>]+\)))*\))+(?:\(([^\s()<>]+|(\([^\s()<>]+\)))*\)|[^\s`!()\[\]{};:'"".,<>?«»“”‘’])";
        public static readonly string patternClearHistory = @"(чист|удал|del)";
        public static string bot = botNameGen();   // Ботнейм

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

        public static string botNameGen() // Метод генерации рандомного имени бота
        {
            Random random = new Random();
            int Index = random.Next(robotNames.Length);
            return robotNames[Index];
        }
        public static string CheckRegexDigit(string s1) // Метод проверки арифметической операции
        {
            List<int> mas1 = new(); // В этот лист будем закидывать числа для выражений..
            var sum = 0;
            int i = 0;
            if (regexSum.IsMatch(s1)) // проверка запроса на сумму
            {
                foreach (char s in s1) // для каждого символа в полученной строке
                {

                    int[] matches = Regex.Matches(s1, "\\d+") // формируем массив из совпадений, ищем только цифры
                        .Cast<Match>()                        // приводим к другому типу
                        .Select(x => int.Parse(x.Value))      // затем получаем целочисленное значение
                        .ToArray();                           // затем возвращаем их в массив
                    if (matches.Length < 2) return $"{bot} at {DateTime.Now}:Я не понимаю вас..";        // если цифра одна, нечего считать, возвращаем -1
                    else
                    if (i == matches.Length) break;           // проверка на выход из диапазона
                    else
                        mas1.Add(matches[i]);                 // если всё ок, добавляем в лист..
                    i++;
                }

                for (int j = 0; j < mas1.Count; j++)
                {
                    sum += mas1[j];                           // суммируем..
                }
                mas1.Clear();                                 // очищаем массив на всякий случай
                return $"{bot} at {DateTime.Now}:Сумма: {sum}";  // возвращаем результат в контроллер
            }


            /// Комментарии к проверке на сумму применимы к умножению и разности..

            else

            if (regexMult.IsMatch(s1))
            {
                foreach (char s in s1)
                {

                    int[] matches = Regex.Matches(s1, "\\d+")
                        .Cast<Match>()
                        .Select(x => int.Parse(x.Value))
                        .ToArray();
                    if (matches.Length < 2) return $"{bot} at {DateTime.Now}:Я не понимаю вас..";
                    else
                    if (i == matches.Length) break;
                    else
                        mas1.Add(matches[i]);
                    i++;
                }
                sum = mas1[0];
                for (int j = 1; j < mas1.Count; j++)
                {
                    sum *= mas1[j];
                }
                mas1.Clear();
                return $"{bot} at {DateTime.Now}:Умножение:{sum}";

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
                    if (matches.Length < 2) return $"{bot} at {DateTime.Now}:Я не понимаю вас..";
                    else
                    if (i == matches.Length) break;
                    else
                        mas1.Add(matches[i]);
                    i++;
                }
                sum = mas1[0];
                for (int j = 1; j < mas1.Count; j++)
                {
                    sum -= mas1[j];
                }

                mas1.Clear();
                return $"{bot} at {DateTime.Now}:Разность:{sum}";

            }

            else return $"{bot} at {DateTime.Now}:Я не понимаю вас..."; // Если ни умножение, ни сумма, ни разность не подошли под запрос пользователя : вернем -1

        }
        public static string CheckRegexHello(string s1) // Проверка запроса юзера на приветствие
        {
            Random random = new Random();
            int Index = random.Next(helloNames.Length);
            var result = $"{bot} at {DateTime.Now}: {helloNames[Index]}!";
            return result;
        }

        public static string CheckRegexUpload(string s1) // Проверка  запроса юзера на загрузку картинки
        {
            WebClient client = new(); // создадим объект взаимодействия с сетью
            string fileName = "pic";  // название файла
                                      //   string link = regexUrl.Matches(s1).ToString();
            var link = regexUrl.Matches(s1)
   .Cast<Match>()
   .Select(m => m.Value)
   .ToArray();

            if (string.IsNullOrEmpty(link[0]) || link[0].ToUpper() == " " || !regexUrl.IsMatch(s1)) // Если строка пустая или юзер нажал отмена в инпут боксе
            {
                return $"{bot} at {DateTime.Now}:Кажется, вы прервали скачку..";
            }
            Uri uri = new Uri(link[0]); // если всё ок, то из инпут бокса получаем ссылку на файл
            string result = "";
            client.DownloadFileAsync(uri, "pic.jpg");                                                                                                // Скачиваем файл по ссылке асинхронно
            result += ($"{bot} at {DateTime.Now}: Successfully Downloaded File \"{fileName}\" from \"{link[0]}\"" + '\n');                           // Покажем на форме что и откуда скачали
            result += ($"{bot} at {DateTime.Now}: Downloaded file saved in the following file system folder: {Application.StartupPath}" + '\n'); // Покажем куда

            return result;


        }

        public static string CheckRegexTime(string s1) // Проверка  запроса юзера на получение текущей даты
        {
            return $"{bot} replies: {DateTime.Now}";
        }


        public static string CheckRegexHowRU(string s1)
        {
            Random random = new Random();
            int Index = random.Next(howruNames.Length);
            return howruNames[Index];
        }

        public static string CheckClearHistory(string s1)
        {

            using (StreamWriter writer = new StreamWriter("History.txt", false))
            {
                writer.WriteLine(string.Empty);
            }
            return $"{bot} at {DateTime.Now}: Файл истории очищен";
        }

        // tpdp: history to list

        public static void ToFile(string s1)
        {
            if (s1 == null) throw new Exception();

            // todo: to arg
            string path = "History.txt";
            string text = s1;


            // добавление в файл
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("***LAST SESSION***\n" + $"{DateTime.Now}\n" + text);
            }

        }

        public static string LoadFile()
        {
            // todo: to arg
            string path = "History.txt";
            string text = "";
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }



        public static string GetAnswer(string s1)
        {
            if (string.IsNullOrEmpty(s1)) return $"{bot} at {DateTime.Now}:Я не понимаю вас...";

            if (regexHello.IsMatch(s1)) return CheckRegexHello(s1);
            else
            if (regexHowRU.IsMatch(s1)) return CheckRegexHowRU(s1);
                if (regexTime.IsMatch(s1)) return CheckRegexTime(s1);
            else
                if (regexUpload.IsMatch(s1)) return CheckRegexUpload(s1);
            else
                if (regexSum.IsMatch(s1)) return CheckRegexDigit(s1);
            else
                if (regexClear.IsMatch(s1)) return CheckClearHistory(s1);
            else return $"{bot} at {DateTime.Now}:Я не понимаю вас...";






        }

    }
}