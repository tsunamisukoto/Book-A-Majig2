using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Bookings.Administration;
using LinqKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Documents;
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
        bool[] states = new bool[6];
        bool[] classes;
        List<BookingClasification> allclassifications;
        bool firstLoad = true;
        private void ViewBookings_Load(object sender, EventArgs e)
        {

            checkedListBox1.SetItemChecked(0, true);
            states[0] = true;
            checkedListBox1.SetItemChecked(1, true);
            states[1] = true;

            checkedListBox1.SetItemChecked(2, false);
            states[2] = false;

            checkedListBox1.SetItemChecked(3, true);
            states[3] = true;

            checkedListBox1.SetItemChecked(4, false);
            states[4] = false;

            checkedListBox1.SetItemChecked(5, true);
            states[5] = true;
            var unitofWork = new UnitOfWork();
            allclassifications = unitofWork.BookingClassificationRepository.Get().ToList();
            classes = new bool[allclassifications.Count];

            for (int i = 0; i < classes.Count(); i++)
            {
                classes[i] = true;
            }
            allclassifications.ForEach(x => ShownClassificationListBox.Items.Add(x.ClassificationName, true));
            if (User != null)
            {
                userInformation1.UserID = User.Id;
            }
            firstLoad = false;
            dateTimePicker1.Value = DateTime.Now;
        }
        List<Booking> ListOfBookings = new List<Booking>();
        UnitOfWork unitOfWork = new UnitOfWork();
        private bool SatisfiesWheres(Booking b)
        {
            if (checkedListBox1.CheckedIndices.Contains(0))
            {
                if (b.BookingConfirmations.Count == 0)
                    return false;
            }
            return true;
        }

        public void Rebind()
        {
            if (!firstLoad)
            {
                var searchPredicate = PredicateBuilder.False<Booking>();
                for (int j = 0; j < classes.Count(); j++)
                {
                    if (classes[j])
                    {
                        string s = allclassifications[j].ClassificationName;
                        searchPredicate = searchPredicate.Or(y => y.BookingClasification.ClassificationName == s);
                    }
                }
                ListOfBookings = unitOfWork.BookingRepository.Get(x =>
                 x.BookingDate.Year == dateTimePicker1.Value.Year &&
                 x.BookingDate.Month == dateTimePicker1.Value.Month &&
                 x.BookingDate.Day == dateTimePicker1.Value.Day, y => y.OrderBy(q => q.BookingDate), "Employee,BookingClasification,BookingNotes.Employee").ToList();

                ListOfBookings = ListOfBookings.AsQueryable().Where(searchPredicate).ToList();
                if (states[0] && !states[1])
                {
                    ListOfBookings = ListOfBookings.Where(x => x.BookingConfirmations.LastOrDefault() != null).ToList();
                }
                if (states[1] && !states[0])
                {
                    ListOfBookings = ListOfBookings.Where(x => x.BookingConfirmations.LastOrDefault() == null).ToList();

                }
                if (!states[1] && !states[0])
                {
                    ListOfBookings = new List<Booking>();
                }
                if (states[2] && !states[3])
                {
                    ListOfBookings = ListOfBookings.Where(x => x.DateInactive != null).ToList();

                }
                if (states[3] && !states[2])
                {
                    ListOfBookings = ListOfBookings.Where(x => x.DateInactive == null).ToList();

                }

                if (!states[2] && !states[3])
                {
                    ListOfBookings = new List<Booking>();
                }
                if (states[4] && !states[5])
                {
                    ListOfBookings = ListOfBookings.Where(x => x.ArrivedDate != null).ToList();

                }
                if (states[5] && !states[4])
                {
                    ListOfBookings = ListOfBookings.Where(x => x.ArrivedDate == null).ToList();

                }

                if (!states[4] && !states[5])
                {
                    ListOfBookings = new List<Booking>();
                }
                dataGridView1.DataSource = ListOfBookings.Select(x =>
                    new
                    {
                        Name = x.Name,
                        TakenBy = x.Employee.FirstName,
                        ContactNumber = x.ContactNumber,
                        Classification = x.BookingClasification != null ? x.BookingClasification.ClassificationName : "",
                        Time = x.BookingDate.ToShortTimeString()
                    }).ToList();
                dataGridView1.Columns["Name"].HeaderText = "Booking Name";
                dataGridView1.Columns["Name"].Width = 350;
                dataGridView1.Columns["TakenBy"].Width = 100;
                dataGridView1.Columns["TakenBy"].HeaderText = "Taken By";
                dataGridView1.Columns["ContactNumber"].Width = 100;
                dataGridView1.Columns["ContactNumber"].HeaderText = "Contact Number";
                dataGridView1.Columns["Time"].Width = 100;
                dataGridView1.Columns["Time"].HeaderText = "Booking Time";

                //dataGridView1.AutoResizeColumn();
                lblNumBookings.Text = ListOfBookings.Count.ToString();
                lblNumCovers.Text = ListOfBookings.Sum(x => x.Adults + x.Children).ToString();
                lblMoreDetails.Text = "";
                dataGridView1.ClearSelection();


            }
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
                if (c.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Rebind();
            new DateService().DateNotesForDate(richTextBox1, dateTimePicker1.Value, false, true);
            new DateService().BookingLockoutsForDate(richTextBox2, dateTimePicker1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today.Date;
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
                    if(booking.DateInactive==null)
                    {
                        booking.DateInactive = DateTime.Now;
                        booking.DeletedByID = User.Id;
                    }
                   

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
                    if(booking.BookingConfirmations.Count==0)
                    booking.BookingConfirmations.Add(new BookingConfirmation() { ConfirmationDate = DateTime.Today, EmployeeId = User.Id });

                }
                unitOfWork.Save();

                Rebind();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var workingBooking = ListOfBookings[dataGridView1.SelectedRows[0].Index];
                lblMoreDetails.Text = "";
                lblMoreDetails.AppendBoldLine("Booking Name:");
                lblMoreDetails.AppendLine(workingBooking.Name);
                lblMoreDetails.AppendBoldLine("Taken By:");
                lblMoreDetails.AppendLine(workingBooking.Employee.FullName + ", " + workingBooking.DateCreated.ToShortDateString());
                lblMoreDetails.AppendBoldLine("Booking Classification");
                lblMoreDetails.AppendLine(workingBooking.BookingClasification.ClassificationName);
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
                    lblMoreDetails.AppendBoldColoredLine("Confirmed By: ", Color.Blue);
                    lblMoreDetails.AppendLine(lastConfirmation.Employee.FullName + " On " + lastConfirmation.ConfirmationDate.Value.ToShortDateString());
                }
                if (workingBooking.DateInactive != null)
                {
                    lblMoreDetails.AppendBoldColoredLine("Deleted By: ", Color.Red);
                    lblMoreDetails.AppendLine(workingBooking.DeletedBy.FullName + " On " + workingBooking.DateInactive);
                }
                lblMoreDetails.AppendLine("");
                lblMoreDetails.AppendBoldLine("Notes:");

                foreach (var note in workingBooking.BookingNotes)
                {
                    lblMoreDetails.AppendLine(note.Note + " " + note.Employee.FullName + " " + note.DateAdded.ToShortDateString());


                }

            }
        }

        private void ShownClassificationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var unitOfWork = new UnitOfWork();
                foreach (var row in dataGridView1.SelectedRows)
                {
                    int workingIndex = dataGridView1.SelectedRows[0].Index;
                    var booking = ListOfBookings[workingIndex];
                    if(booking.ArrivedDate==null)
                    booking.ArrivedDate = DateTime.Now;

                }
                unitOfWork.Save();

                Rebind();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            states[e.Index] = (e.NewValue == CheckState.Checked);
            Rebind();
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {

        }

        private void ShownClassificationListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            classes[e.Index] = (e.NewValue == CheckState.Checked);
            Rebind();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            BookingAdministrationHome v = new BookingAdministrationHome() { User = User };
            v.ShowDialog();
        }
    }
}
