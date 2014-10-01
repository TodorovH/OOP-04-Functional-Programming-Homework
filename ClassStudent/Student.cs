using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get 
            {
                return this.firstName; 
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        { 
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty.");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be negative.");
                }
                this.age = value;
            }
        }

        public int FacultyNumber
        { 
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The faculty number cannot be negative.");
                }
                this.facultyNumber = value;
            }
        }

        public string Phone
        { 
            get
            {
                return this.phone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The phone number cannot be empty.");
                }
                this.phone = value;
            }
        }

        public string Email 
        { 
            get
            {
                return this.email;
            }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Invalid Email.");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The email cannot be empty.");
                }
                this.email = value;
            }
        }

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("Invalid argument.");
                }
                this.marks = value;
            }
        }

        public int GroupNumber 
        { 
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The group number cannot be negative.");
                }
                this.groupNumber = value;
            }
        }
    }
}
