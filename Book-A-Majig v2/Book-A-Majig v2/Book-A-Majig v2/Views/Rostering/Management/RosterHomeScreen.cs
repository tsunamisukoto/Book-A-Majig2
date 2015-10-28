using Book_A_Majig_v2.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Rostering.Management
{
    public partial class RosterHomeScreen : Form
    {
        public RosterHomeScreen()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }

        private void RosterHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewRosters v = new ViewRosters() { User = User };
            v.ShowDialog();
        }
    }
}
