using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ChatBot
{
    public class chatFunc
    {
        static readonly string pattern1 = @"(сум\w||cev\w||'+')";
        static readonly string pattern2 = @"(произв\w||множ\w||'*'||'x'||'vyj;')";
        static readonly string pattern3 = @"(разн\w||минус\w||'-')";

        Regex regexSum = new Regex(pattern1, RegexOptions.IgnoreCase);
        Regex regexMult = new Regex(pattern2, RegexOptions.IgnoreCase);
        Regex regexMinus = new Regex(pattern3, RegexOptions.IgnoreCase);
    }
}
