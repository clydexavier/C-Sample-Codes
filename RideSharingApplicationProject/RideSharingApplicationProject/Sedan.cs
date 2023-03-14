using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    public class Sedan : Vehicle
    {
        public bool IsAvailable { get; set; }
        public Sedan(int maxCapacity, Driver driver) : base(maxCapacity, driver)
        {
            this.IsAvailable = true;
        }
    }
}
