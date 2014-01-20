using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Versaler.Model
{
    static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(this string text)
        {
            int input;

            Regex _reg = new Regex("[A-ZÅÄÖ]");
            input = _reg.Matches(text).Count;
            return input;
        }

    }
}