using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class ClassStudentTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Petar", "Petrov", 19, 123414, "+359 2 77 888 888", "email@gfg.bg", new List<int>{5, 2, 5, 4}, 2),
                new Student("Milka", "Mitreva", 32, 123513, "0885 999 888", "email@abv.bg", new List<int>{6, 6, 6, 6}, 3),
                new Student("Krasi", "Angelov", 38, 123613, "0888 902 888", "email@abv.bg", new List<int>{6, 6, 6, 4}, 2),
                new Student("Dimitar", "Angelov", 38, 123714, "+3592 0888 999 888", "email@abv.bg", new List<int>{6, 6, 6, 4}, 1),
                new Student("Ana", "Asenova", 22, 123813, "0888 999 788", "email@qpp.com", new List<int>{5, 2, 2, 5}, 2),
                new Student("Ana", "Genova", 22, 133913, "02 888 999 788", "email@qpp.com", new List<int>{5, 2, 5,}, 2)
            };


            Console.WriteLine("--------------Problem 04. Students by Group");
            Console.WriteLine();

            var studentsByGroup = students.Where(s => s.GroupNumber == 2)
                .OrderBy(s => s.FirstName).Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.GroupNumber));
            foreach (var s in studentsByGroup)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("--------------Problem 05. Students by First and Last Name");
            Console.WriteLine();

            var studentsByFirstAndLastName = students.Where(s => string.Compare(s.FirstName, s.LastName) < 0)
                .Select(s => string.Format("{0} {1}", s.FirstName, s.LastName));
            foreach (var s in studentsByFirstAndLastName)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("--------------Problem 06. Students by Age");
            Console.WriteLine();

            var studentsByAge = students.Where(s => s.Age >= 18 && s.Age <= 24)
                .OrderBy(s => s.Age).Select(s => string.Format("{0} {1}", s.FirstName, s.LastName));
            foreach (var s in studentsByAge)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("--------------Problem 07. Sort Students");
            Console.WriteLine();

            var sortStudents = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName)
                .Select(s => string.Format("{0} {1}", s.FirstName, s.LastName));
            foreach (var s in sortStudents)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("---------------");

            var querySortStudents =
                from s in students
                orderby s.FirstName + s.LastName descending
                select new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age };

            foreach (var s in querySortStudents)
            {
                Console.WriteLine("{0} {1}", s.FirstName, s.LastName);
            }

            Console.WriteLine();

            Console.WriteLine("--------------Problem 08. Filter Students by Email Domain");
            Console.WriteLine();

            var studentsByEmail = students.Where(s => s.Email.Contains("@abv.bg"))
                .Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.Email));
            foreach (var s in studentsByEmail)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("--------------Problem 09. Filter Students by Phone");
            Console.WriteLine();

            var studentsByPhone = students.Where(s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592") || s.Phone.StartsWith("+359 2"))
                .Select(s => string.Format("{0} {1} - {2}", s.FirstName, s.LastName, s.Phone));
            foreach (var s in studentsByPhone)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("--------------Problem 10. Excellent Students");
            Console.WriteLine();

            var excellentStudents = students.Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = s.Marks})
                .Where(s => s.Marks.Contains(6));
            foreach (var s in excellentStudents)
            {
                Console.WriteLine(s.FullName);
            }
            Console.WriteLine();
        }
    }
}
