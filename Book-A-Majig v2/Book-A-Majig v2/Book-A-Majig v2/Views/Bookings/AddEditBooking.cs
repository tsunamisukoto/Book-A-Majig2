using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
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
    public partial class AddEditBooking : Form
    {
        public AddEditBooking()
        {
            InitializeComponent();
        }
        public Booking currentBooking
        {
            get;
            set;

        }
        public Employee user { get; set; }
        List<BookingNote> newbookingNotes = new List<BookingNote>();
        private void AddEditBooking_Load(object sender, EventArgs e)
        {
            using (var db = new DatabaseEntities.DatabaseEntities())
            {
                cbType.DataSource = db.BookingClasifications.ToList() ;
                cbType.DisplayMember = "ClassificationName";
            }
             
            if(currentBooking!=null)
            {
                tbName.Text = currentBooking.Name;
                
                btnSave.Text = "Edit";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbContactNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private Booking GetFields(Booking b)
        {
            b.BookingDate = dtpBookingTime.Value;
            b.Name = tbName.Text;
            b.ContactNumber = tbContactNumber.Text;
            b.Email = tbEmail.Text;
            b.BookingClasification = (BookingClasification)cbType.SelectedItem;
            b.Restaurant = new Restaurant() { Capacity = 3, Location="CHILL", Name="Whispers" };
            return b;
        }
        public void RebindNotes()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                listView1.Items.AddRange(unitOfWork.BookingNotesRepository.Get(y => y.Booking_Id == currentBooking.Id,null,"Employee,BookingClasification").Select(z => z.Note).Select(a => new ListViewItem(a)).ToArray());

            }
           

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Booking booking;
            if(currentBooking==null)
            {
               booking= GetFields(new Booking());
                booking.Employee = user;
                booking.DateCreated = DateTime.Now;
                var unitOfWork = new UnitOfWork();
                
                    unitOfWork.BookingRepository.Insert(booking);
                unitOfWork.Save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                booking= GetFields(currentBooking);
                //Add Edited Record
            }
        }
    }
}
