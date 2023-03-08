using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    public abstract class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Point Location { get; set; }
        public string Contact { get; set; }

        public User(string name, DateTime birthDate, string contact)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Location = Point.Empty;
            this.Contact = contact;
        }
    }
}
