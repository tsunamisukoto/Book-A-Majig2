using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Bookings;
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
        List<BookingNote> existingbookingnotes = new List<BookingNote>();
        List<BookingNote> allbookingnotes = new List<BookingNote>();
        private void AddEditBooking_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

            cbType.DataSource = unitOfWork.BookingClassificationRepository.Get().ToList();
            cbType.DisplayMember = "ClassificationName";
            cbType.ValueMember = "Id";
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

                cbType.SelectedValue = currentBooking.BookingClasification.Id;
                newbookingNotes = currentBooking.BookingNotes.Where(x => x.DateInactive == null).ToList();
            }
            RebindNotes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        private Booking GetFields(Booking b)
        {
            b.BookingDate = dtpBookingTime.Value;
            b.Name = tbName.Text;
            b.ContactNumber = tbContactNumber.Text.Replace(" ","" );
            b.Email = tbEmail.Text;
            b.BookingClasification = (BookingClasification)cbType.SelectedItem;
            b.Restaurant = new Restaurant() { Capacity = 3, Location = "CHILL", Name = "Whispers" };
            foreach (var note in newbookingNotes.Where(x=> x.DateInactive==null))
                b.BookingNotes.Add(note);
            return b;
        }
        public void RebindNotes()
        {
            var unitOfWork = new UnitOfWork();
            if(currentBooking!=null)
            existingbookingnotes = unitOfWork.BookingNotesRepository.Get(y => y.Booking_Id == currentBooking.Id, null, "Employee").ToList();
            allbookingnotes = existingbookingnotes.Union(newbookingNotes).Where(x=> x.DateInactive== null).ToList();
            dataGridView1.DataSource = allbookingnotes.Select(x => new { Severity = x.Severity, Note = x.Note }).ToList();



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
                currentBooking.BookingNotes.Add(new BookingNote() { EmployeeId= user.Id, Severity=0, Note="Modified By: " + user.FullName, DateAdded=DateTime.Now });
                unitOfWork.BookingRepository.Update(currentBooking);
                DialogResult = DialogResult.OK;

            }
        }
        private void dtpBookingTime_ValueChanged(object sender, EventArgs e)
        {
            tbDateInformation.Text = "";
            new DateService().DateNotesForDate(tbDateInformation, dtpBookingTime.Value.Date, false, true);
            new DateService().BookingLockoutsForDate(richTextBox1, dtpBookingTime.Value.Date);
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddEditBookingNote aebn = new AddEditBookingNote();
            aebn.UserId = user.Id;
            
            aebn.ShowDialog();
            if(aebn.DialogResult==DialogResult.OK)
            {
           
                newbookingNotes.Add(aebn.WorkingNote);



                RebindNotes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                AddEditBookingNote aebn = new AddEditBookingNote();
                aebn.UserId = user.Id;
                int workingindex = dataGridView1.SelectedRows[0].Index;
                if(allbookingnotes[workingindex].Id!=0)
                {
                    aebn.noteID = allbookingnotes[workingindex].Id;

                }
                else
                {
                    aebn.WorkingNote = allbookingnotes[workingindex];
                }
                aebn.ShowDialog();
                if (aebn.DialogResult == DialogResult.OK)
                {





                    RebindNotes();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
              
                int workingindex = dataGridView1.SelectedRows[0].Index;

                var unitOfWork = new UnitOfWork();
            
                    allbookingnotes[workingindex].DateInactive = DateTime.Now;
                
                RebindNotes();
            }
        }
    }
}
