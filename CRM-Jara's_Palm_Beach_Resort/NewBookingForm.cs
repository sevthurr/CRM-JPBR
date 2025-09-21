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
    public partial class NewBookingForm : Form
    {
        public NewBookingForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Attach event handlers for package selection
            packageARBtn.CheckedChanged += packageARBtn_CheckedChanged;
            packageBRbtn.CheckedChanged += packageBRbtn_CheckedChanged;
            packageAPanel.Paint += packageAPanel_Paint;
            packageBPanel.Paint += packageBPanel_Paint;
        }

        private readonly Color highlightColor = Color.FromArgb(235, 197, 149);
        private bool suppressEvents = false;

        private void packageARBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (suppressEvents) return;
            if (packageARBtn.Checked)
            {
                packageAPanel.BorderStyle = BorderStyle.FixedSingle;
                packageBPanel.BorderStyle = BorderStyle.None;
                packageBRbtn.Enabled = false;
            }
            else
            {
                packageAPanel.BorderStyle = BorderStyle.None;
                packageBRbtn.Enabled = true;
            }
            packageAPanel.Invalidate();
            packageBPanel.Invalidate();
        }

        private void packageBRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (suppressEvents) return;
            if (packageBRbtn.Checked)
            {
                packageBPanel.BorderStyle = BorderStyle.FixedSingle;
                packageAPanel.BorderStyle = BorderStyle.None;
                packageARBtn.Enabled = false;
            }
            else
            {
                packageBPanel.BorderStyle = BorderStyle.None;
                packageARBtn.Enabled = true;
            }
            packageBPanel.Invalidate();
            packageAPanel.Invalidate();
        }

        // Custom border color for highlight
        private void packageAPanel_Paint(object sender, PaintEventArgs e)
        {
            if (packageAPanel.BorderStyle == BorderStyle.FixedSingle && packageARBtn.Checked)
            {
                using (Pen p = new Pen(highlightColor, 3))
                {
                    e.Graphics.DrawRectangle(p, 1, 1, packageAPanel.Width - 3, packageAPanel.Height - 3);
                }
            }
        }

        private void packageBPanel_Paint(object sender, PaintEventArgs e)
        {
            if (packageBPanel.BorderStyle == BorderStyle.FixedSingle && packageBRbtn.Checked)
            {
                using (Pen p = new Pen(highlightColor, 3))
                {
                    e.Graphics.DrawRectangle(p, 1, 1, packageBPanel.Width - 3, packageBPanel.Height - 3);
                }
            }
        }

        // Allow unselecting the selected radio button and re-enable the other
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // If click is outside both panels, unselect both
            if (!packageAPanel.Bounds.Contains(PointToClient(MousePosition)) &&
                !packageBPanel.Bounds.Contains(PointToClient(MousePosition)))
            {
                suppressEvents = true;
                packageARBtn.Checked = false;
                packageBRbtn.Checked = false;
                packageARBtn.Enabled = true;
                packageBRbtn.Enabled = true;
                packageAPanel.BorderStyle = BorderStyle.None;
                packageBPanel.BorderStyle = BorderStyle.None;
                packageAPanel.Invalidate();
                packageBPanel.Invalidate();
                suppressEvents = false;
            }
        }

        private void packageAPanel_Click(object sender, EventArgs e)
        {
            if (!packageARBtn.Checked)
            {
                packageARBtn.Checked = true;
            }
            else
            {
                suppressEvents = true;
                packageARBtn.Checked = false;
                packageBRbtn.Enabled = true;
                packageAPanel.BorderStyle = BorderStyle.None;
                packageAPanel.Invalidate();
                suppressEvents = false;
            }
        }

        private void packageBPanel_Click(object sender, EventArgs e)
        {
            if (!packageBRbtn.Checked)
            {
                packageBRbtn.Checked = true;
            }
            else
            {
                suppressEvents = true;
                packageBRbtn.Checked = false;
                packageARBtn.Enabled = true;
                packageBPanel.BorderStyle = BorderStyle.None;
                packageBPanel.Invalidate();
                suppressEvents = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
