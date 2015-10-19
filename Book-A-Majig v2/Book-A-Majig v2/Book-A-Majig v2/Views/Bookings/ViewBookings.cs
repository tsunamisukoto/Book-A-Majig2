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
    public partial class ViewBookings : Form
    {
        public Employee User { get; set; }
        public ViewBookings()
        {
            InitializeComponent();
        }
        private void ViewBookings_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            if (User != null)
            {
                Rebind();
            }

        }
        List<Booking> ListOfBookings = new List<Booking>();
        UnitOfWork unitOfWork = new UnitOfWork();
        public void Rebind()
        {

            ListOfBookings = unitOfWork.BookingRepository.Get(x =>
             x.BookingDate.Year == dateTimePicker1.Value.Year &&
             x.BookingDate.Month == dateTimePicker1.Value.Month &&
             x.BookingDate.Day == dateTimePicker1.Value.Day, y => y.OrderBy(q => q.BookingDate), "Employee,BookingClasification,BookingNotes.Employee").ToList();
            dataGridView1.DataSource = ListOfBookings.Select(x =>
                new
                {
                    Name = x.Name,
                    TakenBy = x.Employee.FirstName,
                    ContactNumber = x.ContactNumber,
                    Classification = x.BookingClasification != null ? x.BookingClasification.ClassificationName : "",
                    Time = x.BookingDate
                }).ToList();

            lblNumBookings.Text = ListOfBookings.Count.ToString();
            lblNumCovers.Text = ListOfBookings.Sum(x=> x.Adults+ x.Children).ToString();
            lblMoreDetails.Text = "";
            dataGridView1.ClearSelection();

        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/
            AddEditBooking c = new AddEditBooking();
            c.user = User;
            c.ShowDialog();
            if (c.DialogResult == DialogResult.OK)
            {
                Rebind();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int workingIndex = dataGridView1.SelectedRows[0].Index;
                AddEditBooking c = new AddEditBooking();
                c.user = User;
                c.currentBookingID = ListOfBookings[workingIndex].Id;

                c.ShowDialog();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Rebind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var unitOfWork = new UnitOfWork();
                foreach (var row in dataGridView1.SelectedRows)
                {
                    int workingIndex = dataGridView1.SelectedRows[0].Index;
                    var booking = ListOfBookings[workingIndex];
                    booking.DateInactive = DateTime.Now;
                    booking.DeletedByID= User.Id;

                }
                unitOfWork.Save();

                Rebind();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var unitOfWork = new UnitOfWork();
                foreach (var row in dataGridView1.SelectedRows)
                {
                    int workingIndex = dataGridView1.SelectedRows[0].Index;
                    var booking = ListOfBookings[workingIndex];
                    booking.BookingConfirmations.Add(new BookingConfirmation() { ConfirmationDate = DateTime.Today, EmployeeId= User.Id });

                }
                unitOfWork.Save();

                Rebind();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                var workingBooking = ListOfBookings[dataGridView1.SelectedRows[0].Index];
                lblMoreDetails.Text = "";
                lblMoreDetails.AppendBoldLine( "Booking Name:");
                lblMoreDetails.AppendLine( workingBooking.Name);
                lblMoreDetails.AppendBoldLine("Taken By:");
                lblMoreDetails.AppendLine(workingBooking.Employee.FullName + ", " + workingBooking.DateCreated.ToShortDateString());
                lblMoreDetails.AppendBoldLine("Booking Classification");
                lblMoreDetails.AppendLine( workingBooking.BookingClasification.ClassificationName);
                lblMoreDetails.AppendLine("");
                if (!string.IsNullOrEmpty(workingBooking.ContactNumber))
                {
                    lblMoreDetails.AppendBoldLine("Phone Number: ");
                    lblMoreDetails.AppendLine(workingBooking.ContactNumber);
                   

                }
                if (!string.IsNullOrEmpty(workingBooking.Email))
                {
                    lblMoreDetails.AppendBoldLine("Email: ");

                    lblMoreDetails.AppendLine(workingBooking.ContactNumber);

                }
                var lastConfirmation = workingBooking.BookingConfirmations.LastOrDefault();
                if (lastConfirmation != null)
                {
                    lblMoreDetails.AppendBoldColoredLine("Confirmed By: ",Color.Blue);
                    lblMoreDetails.AppendLine(lastConfirmation.Employee.FullName + " On " + lastConfirmation.ConfirmationDate.Value.ToShortDateString());
                }
                if(workingBooking.DateInactive!= null)
                {
                    lblMoreDetails.AppendBoldColoredLine("Deleted By: ", Color.Red);
                    lblMoreDetails.AppendLine(workingBooking.DeletedBy.FullName + " On " + workingBooking.DateInactive);
                }

                foreach (var note in workingBooking.BookingNotes)
                {
                    lblMoreDetails.AppendLine(note.Note+" "+ note.Employee.FullName+ " " + note.DateAdded.ToShortDateString() );


                }

            }
        }

        private void ShownClassificationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
