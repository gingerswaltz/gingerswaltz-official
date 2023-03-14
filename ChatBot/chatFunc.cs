using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ChatBotFunc
{
    //
    public static class chatFunc
    {

        static string bot = botNameGen();   // Ботнейм

        static readonly
            string[]
            robotNames = { "R2D2", "C3-PO", "WALL-E", "EVA", "JARVIS", "INERTAN", "KHRAZ", "T-800", "PIP-BOY", "CHAPPIE", "ROBOCOP" };
        static readonly string[]
       helloNames = { "Hola", "Hello", "Привет", "Hiya" };
        public static readonly string patternSum = @"(сум|cev|\+)";
        public static readonly string patterMult = @"(произв|множ|\*|x|vyj;)";
        public static readonly string patternMinus = @"(разн|минус|\-)";
        public static readonly string patternHello = @"(прив|хай|здарова|здорова|йоу|хэй|hello|hi|hey)";
        public static readonly string patternPicUpload = @"(кач|груз|load|pic|изобр)";
        public static readonly string patternGetTime = @"(время|дата|час|time)";


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
                    if (matches.Length < 2) return $"{bot} at { DateTime.Now}:Я не понимаю вас.." ;        // если цифра одна, нечего считать, возвращаем -1
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
                return $"{bot} at { DateTime.Now}:Сумма: {sum}";  // возвращаем результат в контроллер
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
                    if (matches.Length < 2) return $"{bot} at { DateTime.Now}:Я не понимаю вас..";
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
                return $"{bot} at { DateTime.Now}:Умножение:{sum}";

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
                    if (matches.Length < 2) return $"{bot} at { DateTime.Now}:Я не понимаю вас..";
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
                return $"{bot} at { DateTime.Now}:Разность:{sum}";

            }

            else return $"{bot} at { DateTime.Now}:Я не понимаю вас..."; // Если ни умножение, ни сумма, ни разность не подошли под запрос пользователя : вернем -1

        }
        public static (bool,string) CheckRegexHello(string s1) // Проверка запроса юзера на приветствие
        {
            Random random = new Random();
            int Index = random.Next(helloNames.Length);
            var result = (true, $"{bot} at { DateTime.Now}: {helloNames[Index]}!");
            return result;
        }

        public static bool CheckRegexUpload(string s1) // Проверка  запроса юзера на загрузку картинки
        {
            return (regexUpload.IsMatch(s1));
        }

        public static (bool, string) CheckRegexTime(string s1) // Проверка  запроса юзера на получение текущей даты
        {
            return (true, $"{bot} replies: {DateTime.Now}");
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
                writer.WriteLine("***LAST SESSION***\n" +$"{DateTime.Now}\n" +text);
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

    }
}
