using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    [Serializable]
    public class Driver : User
    {
        public string DriversLicense { get; private set; }
        public Driver(string name, DateTime birthDate, string contact, string username, string password, string driversLicense) : base(name, birthDate, contact, username, password)
        {
            this.DriversLicense = driversLicense;
        }
    }
}
