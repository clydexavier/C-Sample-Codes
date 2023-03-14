namespace RideSharingApplicationProject
{
    public partial class LoginForm : Form
    {
        public static AvailableCars AvailableCarsForm = new();
        public static RequestingPassengers RequestingPassengersForm = new();
        public static UserManagement UserManagementForm = new();
        public static User LoggedInUser = null;

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = loginBtn;
            ProjectData.AllUsers.Add(new UserAdministrator("Admin", DateTime.Now, "5635555", "admin", "admin"));
            ProjectData.AllUsers.Add(new Driver("Driver", DateTime.Now, "5635555", "driver", "driver", "12-1-122344"));
            ProjectData.AllUsers.Add(new Passenger("Arvin", DateTime.Now, "5635555", "passenger", "passenger"));
            ProjectData.Load();
            this.FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_FormClosing1(object? sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool cantLogin = true;
            foreach (User u in ProjectData.AllUsers)
            {
                if (u.CanLogin(usernameTB.Text, passwordTB.Text))
                {
                    LoginForm.LoggedInUser = u;
                    if (u is Passenger)
                    {
                        LoginForm.AvailableCarsForm.ShowDialog(this);
                        this.Show();
                    }
                    else if (u is Driver)
                    {
                        LoginForm.RequestingPassengersForm.ShowDialog(this);
                    }
                    else if (u is UserAdministrator)
                    {
                        LoginForm.UserManagementForm.ShowDialog(this);
                    }

                    cantLogin = false;
                }
            }
            if (cantLogin)
            {
                MessageBox.Show("Enter valid username and password.");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ProjectData.Save())
                MessageBox.Show("Saved to " + AppDomain.CurrentDomain.BaseDirectory);
            else
                MessageBox.Show("Error in saving...");
        }
    }
}