using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    public class Driver : User
    {
        public string DriversLicense { get; private set; }
        public Driver(string name, DateTime birthDate, string contact, string driversLicense) : base(name, birthDate, contact)
        {
            this.DriversLicense = driversLicense;
        }
    }
}
