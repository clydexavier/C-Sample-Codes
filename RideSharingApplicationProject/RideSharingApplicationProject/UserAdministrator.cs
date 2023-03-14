using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharingApplicationProject
{
    [Serializable]
    public class UserAdministrator : User
    {
        public UserAdministrator(string name, DateTime birthDate, string contact, string username, string password) : base(name, birthDate, contact, username, password)
        {

        }
    }
}
