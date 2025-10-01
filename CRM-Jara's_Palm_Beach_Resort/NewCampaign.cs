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
    public partial class NewCampaign : Form
    {
        private readonly AccountManager accountManager = new AccountManager();

        public NewCampaign()
        {
            InitializeComponent();
            addCampaignBtn.Click += addCampaignBtn_Click;
        }

        private void addCampaignBtn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(campaignHeadlineTb.Text))
            {
                MessageBox.Show("Campaign headline is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (campaignTypeCb.SelectedItem == null)
            {
                MessageBox.Show("Campaign type is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(campaignDescTb.Text))
            {
                MessageBox.Show("Campaign description is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(emailMessageTb.Text))
            {
                MessageBox.Show("Email message is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (startDateDtp.Value > endDateDtp.Value)
            {
                MessageBox.Show("Start date must be before or equal to end date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect tags from checkboxes
            var tags = new List<string>();
            if (familyCb.Checked) tags.Add("Family");
            if (groupCb.Checked) tags.Add("Group");
            if (coupleCb.Checked) tags.Add("Couple");
            if (soloCb.Checked) tags.Add("Solo");
            string tagString = string.Join(",", tags);
            if (string.IsNullOrEmpty(tagString))
            {
                MessageBox.Show("At least one tag must be selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? promoCodeID = null;
            bool hasPromo = !string.IsNullOrWhiteSpace(promoCodeTb.Text);

            if (hasPromo)
            {
                // Validate promo fields
                if (!int.TryParse(usageLimitTb.Text, out int usageLimit) || usageLimit <= 0)
                {
                    MessageBox.Show("Usage limit must be a positive integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(discountValueTb.Text, out decimal discountValue) || discountValue <= 0)
                {
                    MessageBox.Show("Discount value must be a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create promo code (assuming DiscountType = "Percentage" by default)
                promoCodeID = accountManager.CreatePromoCode(
                    promoCodeTb.Text,
                    "Percentage",
                    usageLimit,
                    endDateDtp.Value,  // Use campaign end date as expiry
                    discountValue
                );

                if (!promoCodeID.HasValue)
                {
                    MessageBox.Show("Failed to create promo code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Create campaign
            int? campaignID = accountManager.CreateCampaign(
                campaignHeadlineTb.Text,
                campaignDescTb.Text,
                campaignTypeCb.SelectedItem.ToString(),
                emailMessageTb.Text,
                promoCodeID,
                startDateDtp.Value,
                endDateDtp.Value,
                "Active",  // Default status
                tagString
            );

            if (!campaignID.HasValue)
            {
                MessageBox.Show("Failed to create campaign.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assign guests to campaign based on tags and marketing consent
            bool success = accountManager.AssignGuestsToCampaign(campaignID.Value, tags.ToArray());

            if (!success)
            {
                MessageBox.Show("Campaign created, but failed to assign guests.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Campaign created successfully and assigned to eligible guests.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}