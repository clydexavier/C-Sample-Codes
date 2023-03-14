using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RideSharingApplicationProject
{
    public partial class AvailableCars : Form
    {
        public AvailableCars()
        {
            InitializeComponent();
        }

        private void AvailableCars_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Passenger)LoginForm.LoggedInUser) + "");
        }
    }
}
