using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3md
{
    public class Person
    {
        public Person(string name, string surname, string dateOfBirth, bool isMale)
        {
            IsMale = isMale;
            DateOfBirthText = dateOfBirth;
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = Math.Abs(_height);
            }
        }

        public DateTime dateOfBirth;
        string DateOfBirthText;
        public string DateOfBirth
        {
            get 
            {
                return DateOfBirthText;
            } 
            set 
            {
                dateOfBirth = Convert.ToDateTime(DateOfBirthText);
            }
        }

        

        public bool IsMale { get; set; }

        public int Age(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }


        public string SayHello()
        {
            return $"Hello, may Name is {Name}{Surname}";
        }

        public string SayAge()
        {
            return $"My age is {Age(DateOfBirth)}";
        }
    }
}
