using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtensionMethods
{
    class CustomLINQExtensionMethodsTest
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            string result1 = string.Join(", ", numbers.WhereNot<int>(p => p == 2));
            Console.WriteLine(result1);
            Console.WriteLine();

            string result2 = string.Join(", ", numbers.Repeat<int>(3));
            Console.WriteLine(result2);
            Console.WriteLine();

            IEnumerable<string> items = new List<string>() { "Sofia", "Plovdiv", "Varna", "Bourgas"};
            IEnumerable<string> suffixes = new List<string>() { "a", "v"};

            string result3 = string.Join(", ", items.WhereEndsWith(suffixes));
            Console.WriteLine(result3);
            Console.WriteLine();
        }
    }
}
