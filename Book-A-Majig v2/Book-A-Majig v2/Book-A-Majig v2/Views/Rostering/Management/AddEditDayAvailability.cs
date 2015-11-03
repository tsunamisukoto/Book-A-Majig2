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
    public partial class AddEditDayAvailability : Form
    {
        public AddEditDayAvailability()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        public int EditedUserID { get; set; }
        public int DayOfWeek { get; set; }
        private void AddEditDayAvailability_Load(object sender, EventArgs e)
        {

        }
    }
}
