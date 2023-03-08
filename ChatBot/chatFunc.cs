using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

// todo: выгрузка и загрузка из файла

namespace ChatBotFunc
{
   
    public static class chatFunc
    {
        static 
            string[] 
            robotNames = { "R2D2", "C3-PO", "WALL-E", "EVA", "JARVIS", "INERTAN", "KHRAZ", "T-800", "PIP-BOY", "CHAPPIE", "ROBOCOP" };

        public static readonly string patternSum = @"(сум|cev|\+)";
        public static readonly string patterMult = @"(произв|множ|\*|x|vyj;)";
        public static readonly string patternMinus = @"(разн|минус|\-)";
        public static readonly string patternHello = @"(прив|хай|здарова|здорова|йоу|хэй|hello|hi)";
        public static readonly string patternPicUpload = @"(кач|груз|load)";
        public static readonly string patternGetTime= @"(время|дата|час)";



        public static Regex regexSum = new Regex(patternSum, RegexOptions.IgnoreCase);
        public static Regex regexMult = new Regex(patterMult, RegexOptions.IgnoreCase);
        public static Regex regexMinus = new Regex(patternMinus, RegexOptions.IgnoreCase);
        public static Regex regexHello = new Regex(patternHello, RegexOptions.IgnoreCase);
        public static Regex regexUpload = new Regex(patternPicUpload, RegexOptions.IgnoreCase);
        public static Regex regexTime = new Regex(patternGetTime, RegexOptions.IgnoreCase);

        public static string botNameGen()
        {
            Random random = new Random();
            int Index = random.Next(robotNames.Length);
            return robotNames[Index];
        }
        public static int CheckRegexDigit(string s1)
        {
            List<int> mas1 = new();
            var sum = 0;
            int i = 0;

            if (regexSum.IsMatch(s1))
            {
                foreach (char s in s1)
                {

                    int[] matches = Regex.Matches(s1, "\\d+")
                        .Cast<Match>()
                        .Select(x => int.Parse(x.Value))
                        .ToArray();
                    if (matches.Length < 2) return -1;
                    else
                    if (i == matches.Length) break;
                    else
                        mas1.Add(matches[i]);
                    i++;
                }

                for (int j = 0; j < mas1.Count; j++)
                {
                    sum += mas1[j];
                }
                mas1.Clear();
                return sum;
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
                    if (matches.Length < 2) return -1;
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
                return sum;

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
                    if (matches.Length < 2) return -1;
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
                return sum;

            }

            else return -1;

        }
        public static bool CheckRegexHello(string s1)
        {
            return (regexHello.IsMatch(s1));
        }

        public static bool CheckRegexUpload(string s1)
        {
            return (regexUpload.IsMatch(s1));
        }

        public static bool CheckRegexTime(string s1)
        {
            return (regexTime.IsMatch(s1));
        }
    }
}
