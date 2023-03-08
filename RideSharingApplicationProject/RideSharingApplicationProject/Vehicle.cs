using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    public abstract class Vehicle
    {
        public int MaxCapacity { get; private set; }
        private Passenger[] passengers;
        private int currentPassengerCount;
        public Driver driver;
        public int CurrentNumberOfPassengers
        {
            get 
            { 
                return currentPassengerCount;
            }
        }
        public Passenger[] Passengers
        {
            get
            {
                return (Passenger[])passengers.Clone();
            }
        }

        public Vehicle(int maxCapacity, Driver driver)
        {
            this.MaxCapacity = maxCapacity;
            this.passengers = new Passenger[maxCapacity];
            this.currentPassengerCount = 0;
            this.driver = driver;
        }

        public bool AddPassenger(Passenger passenger) 
        {
            if (this.currentPassengerCount < this.MaxCapacity)
            {
                this.passengers[this.currentPassengerCount++] = passenger;
                return true;
            }
            else
                return false;
        }
    }
}
