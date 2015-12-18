using Book_A_Majig_v2.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Bookings.Administration
{
    public partial class BookingAdministrationHome : Form
    {
        public BookingAdministrationHome()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }

        private void BookingAdministrationHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ViewBookingClassifications v = new ViewBookingClassifications() { User = User };
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ViewBookingNotePresets v = new ViewBookingNotePresets() { User = User };
            v.ShowDialog();
        }
    }
}
