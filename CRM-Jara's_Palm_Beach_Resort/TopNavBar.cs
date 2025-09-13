using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class TopNavBar : UserControl
    {
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
        }

        // Call this from the parent form to set the active nav
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
                return; // Don't override active style
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
    }
}
