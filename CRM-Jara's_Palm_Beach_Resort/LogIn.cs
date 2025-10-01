namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            linkLabel1.MouseEnter += (s, e) => linkLabel1.LinkColor = Color.FromArgb(83, 169, 181);
            linkLabel1.MouseLeave += (s, e) => linkLabel1.LinkColor = Color.White;
            linkLabel1.Click += (s, e) =>
            {
                using (var forgot = new ForgotPassword())
                {
                    forgot.StartPosition = FormStartPosition.CenterParent;
                    forgot.FormBorderStyle = FormBorderStyle.FixedDialog;
                    forgot.MaximizeBox = false;
                    forgot.MinimizeBox = false;
                    forgot.ShowDialog(this);
                }
            };

            //DatabaseHelper.TestConnection();

            if (!DatabaseHelper.TestConnection())
            {
                Application.Exit(); // Close the program if connection fails
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountManager manager = new AccountManager();
            string userName = usernameTb.Text;
            string password = passwordTb.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var (success, userID, position, firstName, lastName) = manager.Authenticate(userName, password);
            if (success)
            {
                Session.CurrentUserID = userID;
                Session.CurrentPosition = position;
                manager.LogAction(userID, "Login", $"User {userName} logged in successfully");

                var dashboard = new Dashboard(firstName, lastName, position);
                dashboard.StartPosition = FormStartPosition.CenterScreen;
                dashboard.WindowState = FormWindowState.Maximized;
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
