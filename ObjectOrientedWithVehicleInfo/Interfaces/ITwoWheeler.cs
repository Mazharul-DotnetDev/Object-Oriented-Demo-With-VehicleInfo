using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo.Interfaces
{
    internal interface ITwoWheeler<T> where T : class
    {
        List<T> ExteriorDesign { get; set; }

        void AddExteriorDesign(params T[] exteriorDesign);
        void DisplayInfo();
        IEnumerator<T> GetEnumerator();
    }
}
