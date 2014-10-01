using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    public static class StringBuilder
    {
        public static string Substring(this string str, int startIndex, int length)
        {
            if (startIndex+length > str.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid argument.");
            }
            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting index cannot be negative.");
            }

            char[] ch = str.ToCharArray();

            string result = "";

            for (int i = startIndex; i < startIndex+length; i++)
            {
                result += ch[i];
            }

            return result;
        }

        public static string RemoveText(this string str, string text)
        {
            str = str.ToLower();
            text = text.ToLower();
            return str.Replace(text, "");
        }

        public static string AppendAll<T>(this string str, IEnumerable<T> items)
        {
            string temp = "";

            foreach (var item in items)
            {
                temp += item.ToString() + " ";
            }

            temp = temp.Trim(' ', ',');

            return str += " " + temp;
        }
    }
}
