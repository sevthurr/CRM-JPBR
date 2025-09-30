using System.Drawing;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class ListManagement : Form
    {
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            topNavBar1 = new TopNavBar();
            listManagementLbl = new Label();
            packageListPanel = new Panel();
            addPackageBtn = new Button();
            packageListTable = new DataGridView();
            ticketID = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            deliverTo = new DataGridViewTextBoxColumn();
            ticketType = new DataGridViewTextBoxColumn();
            packageListLbl = new Label();
            packageInfoPanel = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            deletePackageBtn = new Button();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            editPackageBtn = new Button();
            paxPanel = new Panel();
            paxIcon = new FontAwesome.Sharp.IconPictureBox();
            paxVal = new Label();
            packagePanel = new Panel();
            packageIcon = new FontAwesome.Sharp.IconPictureBox();
            packageVal = new Label();
            pricePanel = new Panel();
            priceTagIcon = new FontAwesome.Sharp.IconPictureBox();
            priceVal = new Label();
            amenitiesPanel = new Panel();
            label5 = new Label();
            label3 = new Label();
            label17 = new Label();
            amenitiesLbl = new Label();
            label18 = new Label();
            label21 = new Label();
            label19 = new Label();
            label20 = new Label();
            label4 = new Label();
            packageListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packageListTable).BeginInit();
            packageInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            paxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paxIcon).BeginInit();
            packagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packageIcon).BeginInit();
            pricePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceTagIcon).BeginInit();
            amenitiesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topNavBar1
            // 
            topNavBar1.Location = new Point(0, 0);
            topNavBar1.Name = "topNavBar1";
            topNavBar1.Size = new Size(2394, 72);
            topNavBar1.TabIndex = 0;
            // 
            // listManagementLbl
            // 
            listManagementLbl.AutoSize = true;
            listManagementLbl.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listManagementLbl.Location = new Point(55, 101);
            listManagementLbl.Name = "listManagementLbl";
            listManagementLbl.Size = new Size(329, 60);
            listManagementLbl.TabIndex = 6;
            listManagementLbl.Text = "List Management";
            // 
            // packageListPanel
            // 
            packageListPanel.AutoScroll = true;
            packageListPanel.BackColor = Color.White;
            packageListPanel.Controls.Add(addPackageBtn);
            packageListPanel.Controls.Add(packageListTable);
            packageListPanel.Controls.Add(packageListLbl);
            packageListPanel.Location = new Point(67, 180);
            packageListPanel.Name = "packageListPanel";
            packageListPanel.Size = new Size(876, 748);
            packageListPanel.TabIndex = 7;
            // 
            // addPackageBtn
            // 
            addPackageBtn.BackColor = Color.FromArgb(40, 75, 83);
            addPackageBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPackageBtn.ForeColor = Color.White;
            addPackageBtn.Location = new Point(625, 34);
            addPackageBtn.Name = "addPackageBtn";
            addPackageBtn.Size = new Size(182, 40);
            addPackageBtn.TabIndex = 44;
            addPackageBtn.Text = "+ Add Package";
            addPackageBtn.UseVisualStyleBackColor = false;
            // 
            // packageListTable
            // 
            packageListTable.AllowUserToAddRows = false;
            packageListTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 197, 149);
            packageListTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            packageListTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            packageListTable.BackgroundColor = Color.White;
            packageListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packageListTable.Columns.AddRange(new DataGridViewColumn[] { ticketID, subject, deliverTo, ticketType });
            packageListTable.GridColor = Color.White;
            packageListTable.Location = new Point(61, 95);
            packageListTable.Name = "packageListTable";
            packageListTable.ReadOnly = true;
            packageListTable.RowHeadersWidth = 51;
            packageListTable.Size = new Size(746, 600);
            packageListTable.TabIndex = 43;
            // 
            // ticketID
            // 
            ticketID.HeaderText = "Package ID";
            ticketID.MinimumWidth = 6;
            ticketID.Name = "ticketID";
            ticketID.ReadOnly = true;
            // 
            // subject
            // 
            subject.HeaderText = "Package Name";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // deliverTo
            // 
            deliverTo.HeaderText = "Price";
            deliverTo.MinimumWidth = 6;
            deliverTo.Name = "deliverTo";
            deliverTo.ReadOnly = true;
            // 
            // ticketType
            // 
            ticketType.HeaderText = "Max Persons";
            ticketType.MinimumWidth = 6;
            ticketType.Name = "ticketType";
            ticketType.ReadOnly = true;
            // 
            // packageListLbl
            // 
            packageListLbl.AutoSize = true;
            packageListLbl.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageListLbl.ForeColor = Color.Black;
            packageListLbl.Location = new Point(41, 34);
            packageListLbl.Name = "packageListLbl";
            packageListLbl.Size = new Size(166, 40);
            packageListLbl.TabIndex = 9;
            packageListLbl.Text = "Package List";
            // 
            // packageInfoPanel
            // 
            packageInfoPanel.BackColor = Color.White;
            packageInfoPanel.Controls.Add(iconPictureBox1);
            packageInfoPanel.Controls.Add(deletePackageBtn);
            packageInfoPanel.Controls.Add(iconPictureBox4);
            packageInfoPanel.Controls.Add(editPackageBtn);
            packageInfoPanel.Controls.Add(paxPanel);
            packageInfoPanel.Controls.Add(packagePanel);
            packageInfoPanel.Controls.Add(pricePanel);
            packageInfoPanel.Controls.Add(amenitiesPanel);
            packageInfoPanel.Controls.Add(label4);
            packageInfoPanel.Location = new Point(993, 180);
            packageInfoPanel.Name = "packageInfoPanel";
            packageInfoPanel.Size = new Size(876, 748);
            packageInfoPanel.TabIndex = 8;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Red;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(59, 592);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 28;
            iconPictureBox1.TabStop = false;
            // 
            // deletePackageBtn
            // 
            deletePackageBtn.BackColor = Color.Red;
            deletePackageBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletePackageBtn.ForeColor = Color.Transparent;
            deletePackageBtn.Location = new Point(46, 584);
            deletePackageBtn.Name = "deletePackageBtn";
            deletePackageBtn.Size = new Size(197, 40);
            deletePackageBtn.TabIndex = 27;
            deletePackageBtn.Text = "      Delete Package";
            deletePackageBtn.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(255, 173, 70);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconPictureBox4.IconColor = Color.White;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 30;
            iconPictureBox4.Location = new Point(258, 589);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(30, 30);
            iconPictureBox4.TabIndex = 26;
            iconPictureBox4.TabStop = false;
            // 
            // editPackageBtn
            // 
            editPackageBtn.BackColor = Color.FromArgb(255, 173, 70);
            editPackageBtn.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editPackageBtn.ForeColor = Color.Transparent;
            editPackageBtn.Location = new Point(249, 584);
            editPackageBtn.Name = "editPackageBtn";
            editPackageBtn.Size = new Size(178, 40);
            editPackageBtn.TabIndex = 25;
            editPackageBtn.Text = "     Edit Package";
            editPackageBtn.UseVisualStyleBackColor = false;
            // 
            // paxPanel
            // 
            paxPanel.BackColor = Color.FromArgb(235, 197, 149);
            paxPanel.Controls.Add(paxIcon);
            paxPanel.Controls.Add(paxVal);
            paxPanel.Location = new Point(46, 442);
            paxPanel.Name = "paxPanel";
            paxPanel.Size = new Size(380, 89);
            paxPanel.TabIndex = 24;
            // 
            // paxIcon
            // 
            paxIcon.BackColor = Color.FromArgb(235, 197, 149);
            paxIcon.ForeColor = SystemColors.ControlText;
            paxIcon.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            paxIcon.IconColor = SystemColors.ControlText;
            paxIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            paxIcon.IconSize = 50;
            paxIcon.Location = new Point(57, 22);
            paxIcon.Name = "paxIcon";
            paxIcon.Size = new Size(50, 50);
            paxIcon.TabIndex = 14;
            paxIcon.TabStop = false;
            // 
            // paxVal
            // 
            paxVal.AutoSize = true;
            paxVal.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paxVal.ForeColor = Color.Black;
            paxVal.Location = new Point(161, 27);
            paxVal.Name = "paxVal";
            paxVal.Size = new Size(95, 40);
            paxVal.TabIndex = 13;
            paxVal.Text = "30 Pax";
            // 
            // packagePanel
            // 
            packagePanel.BackColor = Color.FromArgb(235, 197, 149);
            packagePanel.Controls.Add(packageIcon);
            packagePanel.Controls.Add(packageVal);
            packagePanel.Location = new Point(46, 182);
            packagePanel.Name = "packagePanel";
            packagePanel.Size = new Size(380, 89);
            packagePanel.TabIndex = 24;
            // 
            // packageIcon
            // 
            packageIcon.BackColor = Color.FromArgb(235, 197, 149);
            packageIcon.ForeColor = SystemColors.ControlText;
            packageIcon.IconChar = FontAwesome.Sharp.IconChar.Box;
            packageIcon.IconColor = SystemColors.ControlText;
            packageIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            packageIcon.IconSize = 50;
            packageIcon.Location = new Point(59, 20);
            packageIcon.Name = "packageIcon";
            packageIcon.Size = new Size(50, 50);
            packageIcon.TabIndex = 12;
            packageIcon.TabStop = false;
            // 
            // packageVal
            // 
            packageVal.AutoSize = true;
            packageVal.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packageVal.ForeColor = Color.Black;
            packageVal.Location = new Point(134, 26);
            packageVal.Name = "packageVal";
            packageVal.Size = new Size(143, 40);
            packageVal.TabIndex = 11;
            packageVal.Text = "Package A";
            // 
            // pricePanel
            // 
            pricePanel.BackColor = Color.FromArgb(235, 197, 149);
            pricePanel.Controls.Add(priceTagIcon);
            pricePanel.Controls.Add(priceVal);
            pricePanel.Location = new Point(46, 312);
            pricePanel.Name = "pricePanel";
            pricePanel.Size = new Size(380, 89);
            pricePanel.TabIndex = 23;
            // 
            // priceTagIcon
            // 
            priceTagIcon.BackColor = Color.FromArgb(235, 197, 149);
            priceTagIcon.ForeColor = SystemColors.ControlText;
            priceTagIcon.IconChar = FontAwesome.Sharp.IconChar.Tag;
            priceTagIcon.IconColor = SystemColors.ControlText;
            priceTagIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            priceTagIcon.IconSize = 50;
            priceTagIcon.Location = new Point(54, 24);
            priceTagIcon.Name = "priceTagIcon";
            priceTagIcon.Size = new Size(50, 50);
            priceTagIcon.TabIndex = 13;
            priceTagIcon.TabStop = false;
            // 
            // priceVal
            // 
            priceVal.AutoSize = true;
            priceVal.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceVal.ForeColor = Color.Black;
            priceVal.Location = new Point(143, 24);
            priceVal.Name = "priceVal";
            priceVal.Size = new Size(154, 40);
            priceVal.TabIndex = 12;
            priceVal.Text = "Php. 15, 000";
            // 
            // amenitiesPanel
            // 
            amenitiesPanel.AutoScroll = true;
            amenitiesPanel.BackColor = Color.FromArgb(220, 235, 237);
            amenitiesPanel.Controls.Add(label5);
            amenitiesPanel.Controls.Add(label3);
            amenitiesPanel.Controls.Add(label17);
            amenitiesPanel.Controls.Add(amenitiesLbl);
            amenitiesPanel.Controls.Add(label18);
            amenitiesPanel.Controls.Add(label21);
            amenitiesPanel.Controls.Add(label19);
            amenitiesPanel.Controls.Add(label20);
            amenitiesPanel.Location = new Point(458, 128);
            amenitiesPanel.Name = "amenitiesPanel";
            amenitiesPanel.Size = new Size(380, 567);
            amenitiesPanel.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10.2F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(46, 427);
            label5.Name = "label5";
            label5.Size = new Size(143, 30);
            label5.TabIndex = 28;
            label5.Text = "• Swing Garden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10.2F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 378);
            label3.Name = "label3";
            label3.Size = new Size(151, 30);
            label3.TabIndex = 27;
            label3.Text = "• Overview Deck";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Poppins", 10.2F);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(46, 328);
            label17.Name = "label17";
            label17.Size = new Size(239, 30);
            label17.TabIndex = 26;
            label17.Text = "• Dining room with minibar\r\n";
            // 
            // amenitiesLbl
            // 
            amenitiesLbl.AutoSize = true;
            amenitiesLbl.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amenitiesLbl.ForeColor = Color.Black;
            amenitiesLbl.Location = new Point(46, 54);
            amenitiesLbl.Name = "amenitiesLbl";
            amenitiesLbl.Size = new Size(137, 40);
            amenitiesLbl.TabIndex = 11;
            amenitiesLbl.Text = "Amenities";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Poppins", 10.2F);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(46, 275);
            label18.Name = "label18";
            label18.Size = new Size(290, 30);
            label18.TabIndex = 25;
            label18.Text = "• 2 Kitchen (Indoor and Outdoor)\r\n";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Poppins", 10.2F);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(46, 122);
            label21.Name = "label21";
            label21.Size = new Size(251, 30);
            label21.TabIndex = 22;
            label21.Text = "• Casa Keona (main house)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Poppins", 10.2F);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(46, 220);
            label19.Name = "label19";
            label19.Size = new Size(320, 30);
            label19.TabIndex = 24;
            label19.Text = "• 2 Bathrooms (Indoor and Outdoor)\r\n";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Poppins", 10.2F);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(46, 170);
            label20.Name = "label20";
            label20.Size = new Size(222, 30);
            label20.TabIndex = 23;
            label20.Text = "• 2 Airconditioned rooms";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(46, 66);
            label4.Name = "label4";
            label4.Size = new Size(347, 53);
            label4.TabIndex = 11;
            label4.Text = "Package Information";
            // 
            // ListManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 977);
            Controls.Add(packageInfoPanel);
            Controls.Add(packageListPanel);
            Controls.Add(listManagementLbl);
            Controls.Add(topNavBar1);
            Name = "ListManagement";
            Text = "List Management";
            packageListPanel.ResumeLayout(false);
            packageListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)packageListTable).EndInit();
            packageInfoPanel.ResumeLayout(false);
            packageInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            paxPanel.ResumeLayout(false);
            paxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paxIcon).EndInit();
            packagePanel.ResumeLayout(false);
            packagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)packageIcon).EndInit();
            pricePanel.ResumeLayout(false);
            pricePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceTagIcon).EndInit();
            amenitiesPanel.ResumeLayout(false);
            amenitiesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private TopNavBar topNavBar1;
        private Label listManagementLbl;
        private Panel packageListPanel;
        private Panel packageInfoPanel;
        private Label packageListLbl;
        private Label label4;
        private DataGridView packageListTable;
        private DataGridViewTextBoxColumn ticketID;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn deliverTo;
        private DataGridViewTextBoxColumn ticketType;
        private Panel paxPanel;
        private Panel packagePanel;
        private Label packageVal;
        private Panel pricePanel;
        private Label priceVal;
        private Panel amenitiesPanel;
        private Label label17;
        private Label amenitiesLbl;
        private Label label18;
        private Label label21;
        private Label label19;
        private Label label20;
        private FontAwesome.Sharp.IconPictureBox paxIcon;
        private Label paxVal;
        private FontAwesome.Sharp.IconPictureBox packageIcon;
        private FontAwesome.Sharp.IconPictureBox priceTagIcon;
        private Button editPackageBtn;
        private Label label5;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Button addPackageBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button deletePackageBtn;
    }
}
