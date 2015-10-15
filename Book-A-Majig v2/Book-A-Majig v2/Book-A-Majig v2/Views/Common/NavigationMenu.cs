using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Views.Common.RestaurantManagement;
using Book_A_Majig_v2.Views.EmployeeCommendations;
using Book_A_Majig_v2.Views.Rostering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Common
{
    public partial class NavigationMenu : Form
    {

        public Employee User { get; set; }
        public NavigationMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBookings v = new ViewBookings() { User = User };
            v.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewRosters v = new ViewRosters() { User = User };
            v.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewCommendations v = new ViewCommendations() { User = User };
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewRestaurants v = new ViewRestaurants() { User = User };
            v.ShowDialog();
        }
    }
}
