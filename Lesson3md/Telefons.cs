using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3md
{
    public class Telefons
    {
        public Telefons(double height, double width, double depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }

        public string Marka { get; set; }

        public string Modelis { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public string GetSize()
        {
            return $"Phone size is {Height} in height, {Width} in width, {Depth} in depth";
        }

        public string GetNaming()
        {
            return $"Phone is made by {Marka} and called {Modelis}";
        }

        public void MakeACall()
        {
            Console.WriteLine("Making some call");
        }

        public void SendingSMS()
        {
            Console.WriteLine("Making some SMS sending");
        }

    }
}
