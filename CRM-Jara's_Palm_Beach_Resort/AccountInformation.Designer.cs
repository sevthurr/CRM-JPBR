namespace CRM_Jara_s_Palm_Beach_Resort
{
    partial class Account_Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            contactManagementLbl.Size = new Size(391, 60);
            contactManagementLbl.TabIndex = 5;
            contactManagementLbl.Text = "Account Information";
            // 
            // Account_Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 977);
            Controls.Add(contactManagementLbl);
            Controls.Add(topNavBar1);
            Name = "Account_Information";
            Text = "Account Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TopNavBar topNavBar1;
        private Label contactManagementLbl;
    }
}