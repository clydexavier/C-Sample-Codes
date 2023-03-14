using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RideSharingApplicationProject
{
    public class ProjectData
    {
        public static List<User> AllUsers = new List<User>();
        public static List<Vehicle> AllVehicles = new List<Vehicle>();

        public static bool Save()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                using (var stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "AllUsers.xml", FileMode.OpenOrCreate))
                {
                    xs.Serialize(stream, new List<User>(ProjectData.AllUsers));
                    stream.Close();
                }
                /*fs = File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "AllVehicles.master");
                xs.Serialize(fs, new List<Vehicle>(ProjectData.AllVehicles));
                fs.Close();*/
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static bool Load()
        {
            /*try
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<User>));
                FileStream fs = File.OpenWrite(AppDomain.CurrentDomain.BaseDirectory + "AllUsers.master");
                fs.Close();
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "AllUsers.master"))
                {
                    fs = File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + "AllUsers.master");
                    ProjectData.AllUsers = xs.Deserialize(fs) as List<User>;
                    fs.Close();
                }

                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "AllVehicles.master"))
                {
                    fs = File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + "AllVehicles.master");
                    ProjectData.AllVehicles = xs.Deserialize(fs) as List<Vehicle>;
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
            }*/
            return true;
        }
    }
}
