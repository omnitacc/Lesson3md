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

        }
    }
}
