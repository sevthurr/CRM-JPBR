using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class TopNavBar : UserControl
    {
        private ContextMenuStrip userMenu; // dropdown for chevron

        public TopNavBar()
        {
            InitializeComponent();
            // Attach click and hover events
            dashboardBtn.Click += (s, e) => NavigateTo("Dashboard");
            bookingsBtn.Click += (s, e) => NavigateTo("BookingManagement");
            guestsBtn.Click += (s, e) => NavigateTo("ContactManagement");
            marketingBtn.Click += (s, e) => NavigateTo("Marketing");
            supportBtn.Click += (s, e) => NavigateTo("Support");

            dashboardBtn.MouseEnter += (s, e) => HoverEffect(dashboardBtn, true);
            dashboardBtn.MouseLeave += (s, e) => HoverEffect(dashboardBtn, false);
            bookingsBtn.MouseEnter += (s, e) => HoverEffect(bookingsBtn, true);
            bookingsBtn.MouseLeave += (s, e) => HoverEffect(bookingsBtn, false);
            guestsBtn.MouseEnter += (s, e) => HoverEffect(guestsBtn, true);
            guestsBtn.MouseLeave += (s, e) => HoverEffect(guestsBtn, false);
            marketingBtn.MouseEnter += (s, e) => HoverEffect(marketingBtn, true);
            marketingBtn.MouseLeave += (s, e) => HoverEffect(marketingBtn, false);
            supportBtn.MouseEnter += (s, e) => HoverEffect(supportBtn, true);
            supportBtn.MouseLeave += (s, e) => HoverEffect(supportBtn, false);

            InitUserMenu();
        }

        private void InitUserMenu()
        {
            userMenu = new ContextMenuStrip();
            var accountInfoItem = new ToolStripMenuItem("Account Information");
            accountInfoItem.Click += (s, e) => OpenForm(new Account_Information());
            var accountItem = new ToolStripMenuItem("Account Management");
            accountItem.Click += (s, e) => OpenForm(new AccountManagement());
            var listItem = new ToolStripMenuItem("List Management");
            listItem.Click += (s, e) => OpenForm(new ListManagement());
            var logoutItem = new ToolStripMenuItem("Logout");
            logoutItem.Click += (s, e) => Logout();
            userMenu.Items.AddRange(new ToolStripItem[] { accountInfoItem, accountItem, listItem, logoutItem });

            var bg = Color.FromArgb(40, 75, 83);
            var hover = Color.FromArgb(235, 197, 149); // requested hover color
            userMenu.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userMenu.BackColor = bg;
            userMenu.ForeColor = Color.White;
            userMenu.ShowImageMargin = false;
            foreach (ToolStripItem it in userMenu.Items)
            {
                it.BackColor = bg;
                it.ForeColor = Color.White;
            }
            userMenu.Renderer = new CustomRenderer(bg, hover);
            userMenu.Opening += (s, e) =>
            {
                foreach (ToolStripItem it in userMenu.Items)
                {
                    it.BackColor = bg;
                    it.ForeColor = Color.White;
                }
            };

            chevronDownBtn.Cursor = Cursors.Hand;
            chevronDownBtn.Click += (s, e) => ShowUserMenu();
        }

        // Custom renderer to control hover background strictly
        private class CustomRenderer : ToolStripProfessionalRenderer
        {
            private readonly Color _bg;
            private readonly Color _hover;
            public CustomRenderer(Color bg, Color hover) : base(new CustomColorTable(bg))
            {
                _bg = bg;
                _hover = hover;
            }
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                var g = e.Graphics;
                Rectangle rect = new Rectangle(Point.Empty, e.Item.Bounds.Size);
                if (e.Item.Selected)
                {
                    using (var b = new SolidBrush(_hover)) g.FillRectangle(b, rect);
                }
                else
                {
                    using (var b = new SolidBrush(_bg)) g.FillRectangle(b, rect);
                }
            }
        }

        private class CustomColorTable : ProfessionalColorTable
        {
            private readonly Color _bg;
            public CustomColorTable(Color bg) { _bg = bg; }
            public override Color ToolStripDropDownBackground => _bg;
            public override Color ImageMarginGradientBegin => _bg;
            public override Color ImageMarginGradientMiddle => _bg;
            public override Color ImageMarginGradientEnd => _bg;
            public override Color MenuBorder => _bg;
        }

        private void ShowUserMenu()
        {
            if (userMenu == null) return;
            var screenPoint = chevronDownBtn.PointToScreen(new Point(0, chevronDownBtn.Height));
            userMenu.Show(screenPoint);
        }

        private void Logout()
        {
            var login = new LogIn();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
            var parentForm = this.FindForm();
            parentForm?.Close();
        }

        private void OpenForm(Form form)
        {
            var parentForm = this.FindForm();
            if (parentForm != null && parentForm.GetType() == form.GetType())
            {
                form.Dispose();
                return;
            }
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            parentForm?.Hide();
        }

        public void SetActive(string formName)
        {
            ResetNavStyles();
            switch (formName)
            {
                case "Dashboard":
                    SetActiveStyle(dashboardBtn);
                    break;
                case "BookingManagement":
                    SetActiveStyle(bookingsBtn);
                    break;
                case "ContactManagement":
                    SetActiveStyle(guestsBtn);
                    break;
                case "Marketing":
                    SetActiveStyle(marketingBtn);
                    break;
                case "Support":
                    SetActiveStyle(supportBtn);
                    break;
            }
        }

        private void SetActiveStyle(Label btn)
        {
            btn.Font = new Font(btn.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void ResetNavStyles()
        {
            dashboardBtn.Font = new Font(dashboardBtn.Font, FontStyle.Regular);
            bookingsBtn.Font = new Font(bookingsBtn.Font, FontStyle.Regular);
            guestsBtn.Font = new Font(guestsBtn.Font, FontStyle.Regular);
            marketingBtn.Font = new Font(marketingBtn.Font, FontStyle.Regular);
            supportBtn.Font = new Font(supportBtn.Font, FontStyle.Regular);
        }

        private void HoverEffect(Label btn, bool hover)
        {
            if ((btn.Font.Style & FontStyle.Bold) == FontStyle.Bold && (btn.Font.Style & FontStyle.Underline) == FontStyle.Underline)
                return;
            btn.Font = new Font(btn.Font, hover ? FontStyle.Underline : FontStyle.Regular);
            btn.ForeColor = hover ? Color.FromArgb(83, 169, 181) : Color.White;
        }

        private void NavigateTo(string formName)
        {
            var parentForm = this.FindForm();
            if (parentForm == null || parentForm.GetType().Name == formName)
                return;
            Form newForm = null;
            switch (formName)
            {
                case "Dashboard":
                    newForm = new Dashboard();
                    break;
                case "BookingManagement":
                    newForm = new BookingManagement();
                    break;
                case "ContactManagement":
                    newForm = new ContactManagement();
                    break;
                case "Marketing":
                    newForm = new Marketing();
                    break;
                case "Support":
                    newForm = new Support();
                    break;
            }
            if (newForm != null)
            {
                newForm.WindowState = FormWindowState.Maximized;
                newForm.Show();
                parentForm.Hide();
            }
        }

        private void topnav_Paint(object sender, PaintEventArgs e) { }
    }
}
