using System;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class ListManagement : Form
    {
        // Track open child forms so multiple instances are not spawned
        private AddPackage _addPackageForm;
        private EditPackage _editPackageForm;

        public ListManagement()
        {
            InitializeComponent();
            this.Text = "List Management";
            this.Load += ListManagement_Load; // Ensure sample data loads

            // Hook button events (designer didn't auto-generate handlers)
            addPackageBtn.Click += addPackageBtn_Click;
            editPackageBtn.Click += editPackageBtn_Click;
        }

        private void addPackageBtn_Click(object sender, EventArgs e)
        {
            if (_addPackageForm == null || _addPackageForm.IsDisposed)
            {
                _addPackageForm = new AddPackage();
                // When closed, release reference so it can be reopened
                _addPackageForm.FormClosed += (_, __) => _addPackageForm = null;
                _addPackageForm.StartPosition = FormStartPosition.CenterParent;
                // Show modeless with this form as owner so it stays on top if needed
                _addPackageForm.Show(this);
            }
            else
            {
                // Bring existing to front
                _addPackageForm.BringToFront();
            }
        }

        private void editPackageBtn_Click(object sender, EventArgs e)
        {
            if (_editPackageForm == null || _editPackageForm.IsDisposed)
            {
                _editPackageForm = new EditPackage();
                _editPackageForm.FormClosed += (_, __) => _editPackageForm = null;
                _editPackageForm.StartPosition = FormStartPosition.CenterParent;
                _editPackageForm.Show(this);
            }
            else
            {
                _editPackageForm.BringToFront();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ListManagement_Load(object sender, EventArgs e)
        {
            packageListTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            packageListTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            packageListTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            packageListTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            packageListTable.DefaultCellStyle.ForeColor = Color.Black;

            // SAMPLE DATA -- REMOVE THIS DURING BACKEND DEVELOPMENT GUYS
            packageListTable.Rows.Add("P01", "Package A", "Php. 15, 000.00", "30");
            packageListTable.Rows.Add("P02", "Package B", "Php. 12, 000.00", "20");

        }
    }
}
