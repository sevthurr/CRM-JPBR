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

            DatabaseHelper.TestConnection();
            DatabaseHelper.GeneratePasswordHash("admin");
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.WindowState = FormWindowState.Maximized;
            dashboard.Show();
            this.Hide();
        }
    }
}
