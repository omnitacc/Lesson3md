using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3md
{
    public class Person
    {
        private DateTime dateOfBirth;
        public Person(string name, string surname, string dateOfBirthText, bool isMale)
        {
            IsMale = isMale;
            DateOfBirth = dateOfBirthText;
            dateOfBirth = Convert.ToDateTime(DateOfBirth);
            Name = name;
            Surname = surname;
        }
        public Person(string name, string surname, bool isMale)
        {
            IsMale = isMale;
            Name = name;
            Surname = surname;
            dateOfBirth = Convert.ToDateTime(DateOfBirth);
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

        public string DateOfBirth { get; set; }


        public string SayDateOFBirth() 
        {
            return DateOfBirth;
        }
        

        public bool IsMale { get; set; }




        public int Age()
        {
            dateOfBirth = Convert.ToDateTime(DateOfBirth);
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }


        public string SayHello()
        {
            return $"Hello, may Name is {Name} {Surname}";
        }

        public string SayAge()
        {
            return $"My age is {Age()}";
        }
    }
}
