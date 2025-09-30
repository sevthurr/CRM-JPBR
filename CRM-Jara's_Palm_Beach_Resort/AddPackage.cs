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
    public partial class AddPackage : Form
    {
        public AddPackage()
        {
            InitializeComponent();
            // Use manual positioning after Shown for accurate size-based centering
            this.StartPosition = FormStartPosition.Manual;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CenterRelativeToOwner();
        }

        private void CenterRelativeToOwner()
        {
            if (Owner == null) return;
            int x = Owner.Location.X + (Owner.Width - this.Width) / 2;
            int y = Owner.Location.Y + (Owner.Height - this.Height) / 2;
            if (x < 0) x = 0; if (y < 0) y = 0; // keep on screen (basic)
            this.Location = new Point(x, y);
        }

        private void AddPackage_Load(object sender, EventArgs e)
        {

        }
    }
}
