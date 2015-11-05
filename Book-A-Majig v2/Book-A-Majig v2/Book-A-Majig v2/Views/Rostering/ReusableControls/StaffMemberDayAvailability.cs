using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Rostering.ReusableControls
{
    public partial class StaffMemberDayAvailability : UserControl
    {
        public StaffMemberDayAvailability()
        {
            InitializeComponent();
        }

        private void StaffMemberDayAvailability_Load(object sender, EventArgs e)
        {

        }
        public Button btnModify { get { return this.button1; } }
        public RichTextBox rtbDetails { get { return this.richTextBox1; } }
        public String Label { set { this.lblDayOfWeek.Text=value; } }
    }
}
