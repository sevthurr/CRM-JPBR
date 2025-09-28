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
    public partial class Payment : Form
    {
        private readonly AccountManager _accountManager;
        private readonly int _bookingID;

        public Payment(int bookingID)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            _bookingID = bookingID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // Set up columns
            paymentTable.Columns.Clear();
            paymentTable.Columns.Add("PaymentID", "Payment ID");
            paymentTable.Columns.Add("Amount", "Amount");
            paymentTable.Columns.Add("Purpose", "Purpose");
            paymentTable.Columns.Add("PaymentDate", "Payment Date");
            paymentTable.Columns.Add("PaidBy", "Paid By");

            // Style header
            paymentTable.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 9F, FontStyle.Bold);
            paymentTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            paymentTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Style data
            paymentTable.DefaultCellStyle.Font = new Font("Poppins", 8F, FontStyle.Regular);
            paymentTable.DefaultCellStyle.ForeColor = Color.Black;
            paymentTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Resize table to fit data
            paymentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentTable.RowTemplate.Height = 32;
            paymentTable.Size = new Size(750, 120);

            // Load data from database
            DataTable payments = _accountManager.GetPaymentHistory(_bookingID);
            foreach (DataRow row in payments.Rows)
            {
                paymentTable.Rows.Add(
                    row["PaymentID"],
                    $"Php {Convert.ToDecimal(row["Amount"]):N2}",
                    row["Purpose"],
                    Convert.ToDateTime(row["PaymentDate"]).ToString("yyyy-MM-dd"),
                    row["GuestName"]
                );
            }
        }
    }
}
