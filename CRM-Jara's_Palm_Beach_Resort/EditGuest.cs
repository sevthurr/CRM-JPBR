using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CRM_Jara_s_Palm_Beach_Resort
{
    public partial class EditGuest : Form
    {
        // Expose edited values so calling form can read them after dialog
        public string GuestFullName => GetFullName();
        public string FirstName => firstNameTb.Text?.Trim();
        public string LastName => lastNameTb.Text?.Trim();
        public string MiddleName => middleNameTb.Text?.Trim();
        public string ContactNumber => contactNumberTb.Text?.Trim();
        public List<string> Socials => socialsListBox.Items.Cast<string>().ToList();
        public bool MarketingConsent => marketingOnRb.Checked;
        public List<string> Tags => GetSelectedTags();
        public Image GuestImage => guestImagePictureBox.Image;

        public EditGuest()
        {
            InitializeComponent();
            
            // Wire event handlers
            uploadImageBtn.Click += UploadImageBtn_Click;
            addSocialBtn.Click += AddSocialBtn_Click;
            saveEditBtn.Click += SaveEditBtn_Click;
            
            // Enable double-click to remove socials
            socialsListBox.DoubleClick += SocialsListBox_DoubleClick;
        }

        // Convenience constructor to pre-fill fields from existing guest data
        public EditGuest(string firstName = "", string lastName = "", string middleName = "", 
                        string contactNumber = "", List<string> socials = null, bool marketingConsent = false, 
                        List<string> tags = null, Image guestImage = null) : this()
        {
            firstNameTb.Text = firstName ?? string.Empty;
            lastNameTb.Text = lastName ?? string.Empty;
            middleNameTb.Text = middleName ?? string.Empty;
            contactNumberTb.Text = contactNumber ?? string.Empty;
            
            // Set marketing consent radio buttons
            marketingOnRb.Checked = marketingConsent;
            marketingOffRb.Checked = !marketingConsent;

            // Load socials
            if (socials != null)
            {
                foreach (var social in socials)
                {
                    socialsListBox.Items.Add(social);
                }
            }

            // Set tags
            if (tags != null)
            {
                familyCheckBox.Checked = tags.Contains("Family");
                groupCheckBox.Checked = tags.Contains("Group");
                coupleCheckBox.Checked = tags.Contains("Couple");
                soloCheckBox.Checked = tags.Contains("Solo");
            }

            // Set guest image
            if (guestImage != null)
            {
                guestImagePictureBox.Image = guestImage;
            }
        }

        private void UploadImageBtn_Click(object? sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select Guest Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load and resize image to fit the picture box
                        var originalImage = Image.FromFile(openFileDialog.FileName);
                        var resizedImage = ResizeImage(originalImage, guestImagePictureBox.Size);
                        guestImagePictureBox.Image = resizedImage;
                        originalImage.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Image Upload Error", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddSocialBtn_Click(object? sender, EventArgs e)
        {
            using (var socialDialog = new AddSocialDialog())
            {
                if (socialDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var socialInfo = socialDialog.SocialInfo;
                    if (!string.IsNullOrWhiteSpace(socialInfo))
                    {
                        socialsListBox.Items.Add(socialInfo);
                    }
                }
            }
        }

        private void SocialsListBox_DoubleClick(object? sender, EventArgs e)
        {
            if (socialsListBox.SelectedItem != null)
            {
                var result = MessageBox.Show($"Remove '{socialsListBox.SelectedItem}'?", 
                                           "Remove Social", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    socialsListBox.Items.Remove(socialsListBox.SelectedItem);
                }
            }
        }

        private void SaveEditBtn_Click(object? sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(firstNameTb.Text) && string.IsNullOrWhiteSpace(lastNameTb.Text))
            {
                MessageBox.Show("Please provide at least a first or last name.", "Validation", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show confirmation dialog
            using (var confirmDialog = new SaveConfirmDialog())
            {
                var result = confirmDialog.ShowDialog(this);
                if (result != DialogResult.OK)
                {
                    // User cancelled or chose not to save
                    return;
                }
            }

            // Success - close with OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string GetFullName()
        {
            var first = firstNameTb.Text?.Trim();
            var last = lastNameTb.Text?.Trim();
            if (string.IsNullOrEmpty(first) && string.IsNullOrEmpty(last)) return string.Empty;
            if (string.IsNullOrEmpty(last)) return first;
            if (string.IsNullOrEmpty(first)) return last;
            return first + " " + last;
        }

        private List<string> GetSelectedTags()
        {
            var tags = new List<string>();
            if (familyCheckBox.Checked) tags.Add("Family");
            if (groupCheckBox.Checked) tags.Add("Group");
            if (coupleCheckBox.Checked) tags.Add("Couple");
            if (soloCheckBox.Checked) tags.Add("Solo");
            return tags;
        }

        private Image ResizeImage(Image image, Size newSize)
        {
            var resized = new Bitmap(newSize.Width, newSize.Height);
            using (var graphics = Graphics.FromImage(resized))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newSize.Width, newSize.Height);
            }
            return resized;
        }
    }

    // Simple dialog for adding social media information
    public partial class AddSocialDialog : Form
    {
        private TextBox platformTb;
        private TextBox handleTb;
        private Button okBtn;
        private Button cancelBtn;

        public string SocialInfo { get; private set; } = string.Empty;

        public AddSocialDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Add Social Media";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(350, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var platformLbl = new Label()
            {
                Text = "Platform:",
                Location = new Point(20, 20),
                Size = new Size(80, 23),
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };

            platformTb = new TextBox()
            {
                Location = new Point(20, 45),
                Size = new Size(300, 27),
                PlaceholderText = "e.g., Facebook, Instagram, Twitter",
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };

            var handleLbl = new Label()
            {
                Text = "Handle/Username:",
                Location = new Point(20, 80),
                Size = new Size(150, 23),
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };

            handleTb = new TextBox()
            {
                Location = new Point(20, 105),
                Size = new Size(300, 27),
                PlaceholderText = "Username or profile link",
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };

            okBtn = new Button()
            {
                Text = "OK",
                Location = new Point(165, 140),
                Size = new Size(75, 30),
                BackColor = Color.FromArgb(82, 169, 181),
                ForeColor = Color.White,
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };
            okBtn.Click += OkBtn_Click;

            cancelBtn = new Button()
            {
                Text = "Cancel",
                Location = new Point(245, 140),
                Size = new Size(75, 30),
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };
            cancelBtn.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.AddRange(new Control[] { platformLbl, platformTb, handleLbl, handleTb, okBtn, cancelBtn });
        }

        private void OkBtn_Click(object? sender, EventArgs e)
        {
            var platform = platformTb.Text?.Trim();
            var handle = handleTb.Text?.Trim();

            if (string.IsNullOrWhiteSpace(platform) || string.IsNullOrWhiteSpace(handle))
            {
                MessageBox.Show("Please enter both platform and handle.", "Validation", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SocialInfo = $"{platform}: {handle}";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    // Confirmation dialog for saving edits
    public partial class SaveConfirmDialog : Form
    {
        private Label msgLbl;
        private Button confirmBtn;
        private Button cancelBtn;

        public SaveConfirmDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Confirm Changes";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(400, 180);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            msgLbl = new Label()
            {
                AutoSize = false,
                Location = new Point(20, 20),
                Size = new Size(350, 60),
                Text = "Are you sure you want to save these changes to the guest information?",
                Font = new Font("Poppins", 9F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            confirmBtn = new Button()
            {
                Text = "Confirm",
                Location = new Point(120, 100),
                Size = new Size(80, 35),
                BackColor = Color.FromArgb(82, 169, 181),
                ForeColor = Color.White,
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };
            confirmBtn.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

            cancelBtn = new Button()
            {
                Text = "Cancel",
                Location = new Point(210, 100),
                Size = new Size(80, 35),
                Font = new Font("Poppins", 8F, FontStyle.Regular)
            };
            cancelBtn.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.AddRange(new Control[] { msgLbl, confirmBtn, cancelBtn });
        }
    }
}