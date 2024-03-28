using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo.Models
{
    internal sealed class Car<T> : FourWheeler<T> where T : class
    {
        public string ModelNumber { get; set; }
        public string Brand { get; set; }

        public Car() { }

        public Car(string model, string brand) : base()
        {
            ModelNumber = model;
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Car Information:");
            Console.WriteLine("Model Number: " + ModelNumber);
            Console.WriteLine("Brand: " + Brand);
            base.DisplayInfo();
        }
    }
}
