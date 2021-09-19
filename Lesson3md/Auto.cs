using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3md
{
    public class Auto
    {
        public Auto(string marka, double speed, string numurzime)
        {
            Numurzime = numurzime;
            Speed = speed;
            Marka = marka;
        }

        public string Marka { get; set; }

        public string Numurzime { get; set; }

        public double Speed { get; set; }

        public double Width { get; set; }

        public string GetSize()
        {
            return $"Phone size is {Height} in height, {Width} in width, {Depth} in depth";
        }

        public string GetNaming()
        {
            return $"Phone is made by {Marka} and called {Modelis}";
        }

        public double IncreasseSpeed(double speedNow, double speedNeeded)
        {
            double speed = speedNeeded - speedNow;
            Console.WriteLine("Pushing accelerator pedal");
            Console.WriteLine("Increasing speed for {0} km/h", speed);
            return speedNow += speed;
        }
        public double DecreasseSpeed(double speed)
        {
            Console.WriteLine("Pushing break pedal");
            return --speed;
        }

        
        public void StartMoving(double needSpeed)
        {
            double startSpeed = 0;
            startSpeed = IncreasseSpeed(0, needSpeed);
            Console.WriteLine("Car started movement and took {0} km/h speed", startSpeed);
        }

        public void StopMoving(double speedNow)
        {
            if (speedNow>0) { 
                speedNow = DecreasseSpeed(speedNow);
            }
            Console.WriteLine("Car stoped moving");
        }

        public void Horn() 
        {
            Console.WriteLine("Beep beep");
        }      
     }
}
