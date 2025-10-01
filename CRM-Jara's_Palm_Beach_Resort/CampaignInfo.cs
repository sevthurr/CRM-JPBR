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
    public partial class CampaignInfo : Form
    {
        private readonly int _campaignID;
        private readonly AccountManager _accountManager = new AccountManager();

        public CampaignInfo(int campaignID)
        {
            InitializeComponent();
            _campaignID = campaignID;
            LoadCampaignDetails();
        }

        private void LoadCampaignDetails()
        {
            var campaign = _accountManager.GetCampaignByID(_campaignID);
            if (campaign == null)
            {
                MessageBox.Show("Campaign not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            campaignHeadlineVal.Text = campaign.Headline;
            descriptionVal.Text = campaign.Description;
            campaignTypeVal.Text = campaign.Type;
            targetSegmentVal.Text = campaign.Tag;
            startDateVal.Text = campaign.StartDate.ToString("MM/dd/yyyy");
            endDateVal.Text = campaign.EndDate.ToString("MM/dd/yyyy");
            emailMessageVal.Text = campaign.EmailMessage;
            statusVal.Text = campaign.Status;

            // Update status color
            if (campaign.Status == "Running" || campaign.Status == "Active")
            {
                statusVal.BackColor = Color.FromArgb(38, 176, 112); // Green
            }
            else if (campaign.Status == "Completed")
            {
                statusVal.BackColor = Color.Gray;
            }
            else if (campaign.Status == "Draft")
            {
                statusVal.BackColor = Color.Orange;
            }
            else
            {
                statusVal.BackColor = Color.Red; // For other statuses like "Paused" or errors
            }
        }
    }
}