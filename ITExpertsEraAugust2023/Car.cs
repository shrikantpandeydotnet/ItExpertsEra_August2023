using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class Car
    {

        private int i = 10; 

        // Properties | Data Members

        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
        public int NoOfSeats { get; set; }

        // Data functions or Methods 

        public void Accelerator(int pressure ) // Methods Parameter
        {
            Console.WriteLine("Speed of the car is " + pressure * 10);

        }

        public void Brake(int pressure) // Methods Parameter
        {
            int speed = pressure / 10;
            Console.WriteLine("Speed of the car is " + speed);
        }

        public void Clutch(int pressure) // Methods Parameter
        {
            Console.WriteLine("Speed of the car is " + pressure);
        }
    }
}
