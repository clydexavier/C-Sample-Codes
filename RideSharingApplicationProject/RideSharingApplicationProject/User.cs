using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    [Serializable]
    public abstract class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Point Location { get; set; }
        public string Contact { get; set; }
        protected string username;
        protected string password;

        public User(string name, DateTime birthDate, string contact, string username, string password)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Location = Point.Empty;
            this.Contact = contact;
            this.username = username;
            this.password = password;
        }

        public bool CanLogin(string username, string password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }

        public override string ToString()
        {
            return this.Name + " " + this.username + " " + this.Contact + " ";
        }
    }
}
