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
            Regex reg = new Regex("[A-ZÅÄÖ]");
            return reg.Matches(text).Count;
        }

    }
}