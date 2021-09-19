using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3md
{
    public class Prece
    {

        public Prece(double height, double width, double depth, double weight)
        {
            Height = height;
            Width = width;
            Depth = depth;
            Weight = weight;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        private double Height;

        private double Width;

        private double Depth;

        private double Weight;

        public void Paramaters() {
            Console.WriteLine("Parameters: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Depth: {Depth}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Weight: {Weight}");
        }
    }
}
