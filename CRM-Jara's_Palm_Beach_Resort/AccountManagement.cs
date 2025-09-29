using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
            this.Load += AccountManagement_Load;
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            accountsTable.EnableHeadersVisualStyles = false;
            accountsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            accountsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            accountsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            accountsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            accountsTable.DefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Regular);
            accountsTable.DefaultCellStyle.ForeColor = Color.Black;
            accountsTable.DefaultCellStyle.SelectionForeColor = Color.Black;

            accountsTable.RowHeadersVisible = false;
            accountsTable.MultiSelect = false;
            accountsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Load sample data only if table is empty to avoid duplicate entries
            if (accountsTable.Rows.Count == 0)
            {
                accountsTable.Rows.Add("A001", "Ballerina Capuccina", "Staff", "bcapuccina", "mm/dd/yyyy", "Active");
                accountsTable.Rows.Add("A002", "Tung Tung Sahur", "Admin", "tsahur", "mm/dd/yyyy", "Active");
                accountsTable.Rows.Add("A003", "Tralalelo Tralala", "Staff", "ttralala", "mm/dd/yyyy", "Disabled");
            }
        }
    }
}
