using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AggregationService.Implementation
{
    class BaseApi :IDisposable
    {
        internal static string ToSafeXmlString(string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                inputString = inputString.Replace("&", "&amp;");
                inputString = inputString.Replace("\"", "&quot;");
                inputString = inputString.Replace("<", "&lt;");
                inputString = inputString.Replace(">", "&gt;");
                inputString = inputString.Replace("'", "&#146;");
            }
            return inputString;

        }

        internal static string ToOrignalString(string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                inputString = inputString.Replace("&amp;", "&");
                inputString = inputString.Replace("&quot;", "\"");
                inputString = inputString.Replace("&lt;", "<");
                inputString = inputString.Replace("&gt;", ">");
                inputString = inputString.Replace("&nbsp;", " ");
                inputString = inputString.Replace("&#146;", "'");
            }

            return inputString;
        }
    }
}
