using ObjectOrientedWithVehicleInfo.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo.Models
{
    internal class FourWheeler<T> : Vehicle, IEnumerable<T>, IFourWheeler<T> where T : class
    {
        public List<T> InteriorDesign { get; set; } = new List<T>();

        public FourWheeler() : base()
        {
            base.VehicleType = VehicleType.FourWheeler;
        }

        public virtual void AddInteriorDesign(params T[] interiorDesing)
        {
            this.InteriorDesign.AddRange(interiorDesing);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Interior Designs:");
            foreach (var item in InteriorDesign)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)InteriorDesign).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)InteriorDesign).GetEnumerator();
        }
    }
}
