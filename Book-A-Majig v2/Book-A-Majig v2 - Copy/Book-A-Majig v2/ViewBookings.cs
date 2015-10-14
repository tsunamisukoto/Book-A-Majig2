using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2
{
    public partial class ViewBookings : Form
    {
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Model1Container())
            {
                db.Restaurants.AddObject(new Restaurant() { Name=tbName.Text, Capacity=(int)tbCapacity.Value,Location=tbLocation.Text});
                db.SaveChanges();
            }
        }
    }
}
