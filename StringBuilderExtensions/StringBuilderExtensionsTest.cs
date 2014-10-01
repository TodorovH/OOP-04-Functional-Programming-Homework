using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    class StringBuilderExtensionsTest
    {
        public static void Main(string[] args)
        {
            string str = "StringBuilderTest";
            IEnumerable<int> nums = new List<int>() { 1, 5, 9 };

            string result1 = str.Substring(5, 3);
            Console.WriteLine(result1);
            Console.WriteLine();

            string result2 = str.RemoveText("test");
            Console.WriteLine(result2);
            Console.WriteLine();

            string result3 = str.AppendAll<int>(nums);
            Console.WriteLine(result3);
            Console.WriteLine();
        }
    }
}
