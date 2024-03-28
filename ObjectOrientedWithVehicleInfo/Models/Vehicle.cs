using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo.Models
{
    public enum VehicleType
    {
        TwoWheeler,
        FourWheeler
    }

    // Base Vehicle class implementing IDisposable
    internal abstract class Vehicle : IDisposable
    {
        public VehicleType VehicleType { get; set; }

        public abstract void DisplayInfo();

        public void Dispose()
        {
            // Dispose implementation if necessary
        }
    }
}
