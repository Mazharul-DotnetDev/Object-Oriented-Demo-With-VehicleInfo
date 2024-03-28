using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo.Interfaces
{
    internal interface IFourWheeler<T> where T : class
    {
        List<T> InteriorDesign { get; set; }

        void AddInteriorDesign(params T[] interiorDesing);
        void DisplayInfo();
        IEnumerator<T> GetEnumerator();
    }
}
