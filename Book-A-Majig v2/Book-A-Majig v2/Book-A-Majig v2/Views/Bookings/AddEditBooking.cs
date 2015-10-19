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
        private Booking currentBooking
        {
            get;
            set;

        }
        public int? currentBookingID
        {
            get; set;
        }
        public Employee user { get; set; }
        List<BookingNote> newbookingNotes = new List<BookingNote>();
        private void AddEditBooking_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

            cbType.DataSource = unitOfWork.BookingClassificationRepository.Get().ToList();
            cbType.DisplayMember = "ClassificationName";
            var startDate = DateTime.Today;
            startDate.AddSeconds(-startDate.Second);
            startDate.AddMinutes(-startDate.Minute);
            dtpBookingTime.Value = startDate;

            if (currentBookingID != null)
            {
                currentBooking = unitOfWork.BookingRepository.Get(null, null, "Employee,BookingClasification,BookingNotes").Where(x => x.Id == currentBookingID).FirstOrDefault();
                btnSave.Text = "Save Changes";
                dtpBookingTime.Value = currentBooking.BookingDate;
                tbName.Text = currentBooking.Name;
                tbContactNumber.Text = currentBooking.ContactNumber;
                tbEmail.Text = currentBooking.Email;

                cbType.SelectedValue = currentBooking.BookingClasification;
                newbookingNotes = currentBooking.BookingNotes.Where(x => x.DateInactive == null).ToList();
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
            b.Restaurant = new Restaurant() { Capacity = 3, Location = "CHILL", Name = "Whispers" };
            return b;
        }
        public void RebindNotes()
        {
            var unitOfWork = new UnitOfWork();

            listView1.Items.AddRange(unitOfWork.BookingNotesRepository.Get(y => y.Booking_Id == currentBooking.Id, null, "Employee,BookingClasification").Select(z => z.Note).Select(a => new ListViewItem(a)).ToArray());




        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Booking booking;
            var unitOfWork = new UnitOfWork();

            if (currentBooking == null)
            {
                booking = GetFields(new Booking());
                booking.Employee = user;
                booking.DateCreated = DateTime.Now;

                unitOfWork.BookingRepository.Insert(booking);
                unitOfWork.Save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                currentBooking = GetFields(currentBooking);
                unitOfWork.BookingRepository.Update(currentBooking);
                DialogResult = DialogResult.OK;

            }
        }

        private void dtpBookingTime_ValueChanged(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

        }
    }
}
