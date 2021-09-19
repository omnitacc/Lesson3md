using System;

namespace Lesson3md
{
    class Program
    {
        static void Main(string[] args)
        {
            //some code
            var phone = new Telefons(70.5, 30.2, 5.4);

            phone.Marka = "Samsung";
            phone.Modelis = "Galaxy S20+";
            phone.Height = 71.1;
            phone.Width = 25.5;
            phone.Depth = 5.5;

            Console.WriteLine(phone.GetNaming()+" and "+ phone.GetSize());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" ");

            var auto = new Auto("AUDI", 0, "LV-1234");
            auto.Marka = "AUDI";
            auto.Numurzime = "LV-4321";
            auto.Speed = 100;

            auto.StartMoving(50);
            auto.Horn();
            auto.IncreasseSpeed(50, 70);
            auto.StopMoving(70);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" ");

            var prece = new Prece(0.25, 12, 12, 25);
            prece.Name = "Kaut kas";
            prece.Price = 10.20;
            prece.Paramaters();

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" ");

            //var person = new Person("Testa","Persona", true);
            var person = new Person("Testa", "Persona","10/09/1990", true);

            person.Name = "Vards";
            person.Surname = "Surname";
            person.DateOfBirth = "03/03/1994";
            person.IsMale = false;
 
            Console.WriteLine(person.SayHello() + ", "+ person.SayAge()+" is male: {0}", person.IsMale);


        }
    }
}
