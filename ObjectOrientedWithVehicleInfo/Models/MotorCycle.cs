using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo.Models
{
    internal sealed class Motorcycle<T> : TwoWheeler<T> where T : class
    {
        public string ModelNumber { get; set; }
        public string Brand { get; set; }

        public Motorcycle() { }

        public Motorcycle(string model, string brand) : base()
        {
            ModelNumber = model;
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Motorcycle Information:");
            Console.WriteLine("Model Number: " + ModelNumber);
            Console.WriteLine("Brand: " + Brand);
            base.DisplayInfo();
        }
    }
}
