using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    public class Passenger : User, ICloneable
    {
        private static int PASSENGER_COUNTER = 1;
        private int id;
        public double Mileage { get; private set; }

        public Passenger(string name, DateTime birthDate, string contact) : base(name, birthDate, contact) 
        {
            this.id = PASSENGER_COUNTER++;
            this.Mileage = 0;
        }

        private Passenger(Passenger p) : base(p.Name, p.BirthDate, p.Contact)
        {
            this.id = p.id;
            this.Mileage = p.Mileage;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && obj is Passenger && ((Passenger)obj).id == this.id;
        }

        public object Clone()
        {
            return new Passenger(this);
        }
    }
}
