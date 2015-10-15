using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.Objects;
using System.Windows.Forms;
using Book_A_Majig_v2.DatabaseEntities;

namespace Book_A_Majig_v2
{
    public partial class AddEditRestaurant : Form
    {
        public AddEditRestaurant()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (var v = new DatabaseEntities.DatabaseEntities())
            {
                v.Restaurants.Add(new Restaurant() {  Location=tbLocation.Text, Name=tbName.Text, Capacity=(int)tbCapacity.Value});
                
                v.SaveChanges();
            }
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            using (var v = new DatabaseEntities.DatabaseEntities())
            {
                var rest = v.Restaurants.FirstOrDefault();

            }
        }
    }
}
