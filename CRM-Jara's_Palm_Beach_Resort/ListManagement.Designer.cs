using System.Drawing;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class ListManagement : Form
    {
        private void InitializeComponent()
        {
            topNavBar1 = new TopNavBar();
            contactManagementLbl = new Label();
            SuspendLayout();
            // 
            // topNavBar1
            // 
            topNavBar1.Location = new Point(0, 0);
            topNavBar1.Name = "topNavBar1";
            topNavBar1.Size = new Size(2394, 72);
            topNavBar1.TabIndex = 0;
            // 
            // contactManagementLbl
            // 
            contactManagementLbl.AutoSize = true;
            contactManagementLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactManagementLbl.Location = new Point(55, 101);
            contactManagementLbl.Name = "contactManagementLbl";
            contactManagementLbl.Size = new Size(329, 60);
            contactManagementLbl.TabIndex = 6;
            contactManagementLbl.Text = "List Management";
            // 
            // ListManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 977);
            Controls.Add(contactManagementLbl);
            Controls.Add(topNavBar1);
            Name = "ListManagement";
            Text = "List Management";
            ResumeLayout(false);
            PerformLayout();
        }
        private TopNavBar topNavBar1;
        private Label contactManagementLbl;
    }
}
