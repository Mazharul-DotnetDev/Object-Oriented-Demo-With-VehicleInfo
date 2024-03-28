using ObjectOrientedWithVehicleInfo.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo.Models
{
    internal class TwoWheeler<T> : Vehicle, IEnumerable<T>, ITwoWheeler<T> where T : class
    {
        public List<T> ExteriorDesign { get; set; } = new List<T>();

        public TwoWheeler() : base()
        {
            base.VehicleType = VehicleType.TwoWheeler;
        }

        public virtual void AddExteriorDesign(params T[] exteriorDesign)
        {
            this.ExteriorDesign.AddRange(exteriorDesign);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Exterior Designs:");
            foreach (var item in ExteriorDesign)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)ExteriorDesign).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)ExteriorDesign).GetEnumerator();
        }

        
    }

}
