using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Common.RestaurantManagement.RestaurantDates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Book_A_Majig_v2.Views.Common.RestaurantManagement
{
    public partial class ManageRestaurantDates : Form
    {
        public ManageRestaurantDates()
        {
            InitializeComponent();
        }


        public Employee user { get; set; }
        public int? RestaurantID { get; set; }
        private Restaurant Restaurant;
        List<DateNote> DateNotes;
        List<LockOutDate> DateLockouts;
        private void ManageRestaurantDateNotes_Load(object sender, EventArgs e)
        {
            RebindDateLockouts();
            RebindDateNotes();
        }
        void RebindDateNotes()
        {
            var unitOfWork = new UnitOfWork();
            var now = DateTime.Now.Date;
            DateNotes = unitOfWork.DateNoteRepository.Get(x => x.InactiveDate == null && x.EndDate >now ).ToList();
            dgvNotes.DataSource = DateNotes.Select(x => new {  Note= x.Note, AppearOnBookings= x.AppearOnAddingBooking, AppearOnRostering= x.AppearOnRoster, StartDate = x.StartDate.ToShortDateString(), EndDate=x.EndDate.ToShortDateString()}).ToList();
            

        }
        void RebindDateLockouts()
        {
            var unitOfWork = new UnitOfWork();
            DateLockouts = unitOfWork.LockedOutDateRepository.Get(x => x.EndDate > DateTime.Now, includeProperties: "LockOutTimes").ToList();
            dgvLocked.DataSource = DateLockouts.Select(x => new {Name=x.Name, StartDate = x.StartDate.ToShortDateString(), EndDate = x.EndDate.ToShortDateString(), Times= string.Join(",",x.LockOutTimes.Select(y=> y.StartTime.ToShortTimeString()+ "- " + y.EndTime.ToShortTimeString()) )}).ToList();

        }

        private void button6_Click(object sender, EventArgs e)
        {
         
                AddEditDateNote a = new AddEditDateNote();
         
                a.user = user;
                a.ShowDialog();
                if(a.DialogResult==DialogResult.OK)
                {
                    RebindDateNotes();
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                int workingIndex = dgvNotes.SelectedRows[0].Index;
                AddEditDateNote a = new AddEditDateNote();
                a.DateNoteID = DateNotes[workingIndex].Id;
                a.user = user;
                a.ShowDialog();
                if (a.DialogResult == DialogResult.OK)
                {
                    RebindDateNotes();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                var unitOfWork = new UnitOfWork();
                int workingIndex = dgvNotes.SelectedRows[0].Index;
                unitOfWork.DateNoteRepository.Delete(DateNotes[workingIndex]);
                RebindDateNotes();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditLockedDate aeld = new AddEditLockedDate();
            aeld.user = user;
            aeld.ShowDialog();
            if(aeld.DialogResult== DialogResult.OK)
            {
                RebindDateLockouts();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvLocked.SelectedRows.Count > 0)
            {
                int workingIndex = dgvLocked.SelectedRows[0].Index;
                AddEditLockedDate a = new AddEditLockedDate();
                a.LockedDateID = DateLockouts[workingIndex].Id;
                a.user = user;
                a.ShowDialog();
                if (a.DialogResult == DialogResult.OK)
                {
                    RebindDateLockouts();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvLocked.SelectedRows.Count > 0)
            {
                var unitOfWork = new UnitOfWork();
                int workingIndex = dgvLocked.SelectedRows[0].Index;
                unitOfWork.LockedOutDateRepository.Delete(DateLockouts[workingIndex]);
                RebindDateLockouts();
            }
        }
    }
}
