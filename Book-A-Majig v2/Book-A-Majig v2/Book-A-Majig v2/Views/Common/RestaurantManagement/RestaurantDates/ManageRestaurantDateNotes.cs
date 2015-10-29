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
namespace Book_A_Majig_v2.Views.Common.RestaurantManagement
{
    public partial class ManageRestaurantDateNotes : Form
    {
        public ManageRestaurantDateNotes()
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
            DateNotes = unitOfWork.DateNoteRepository.Get(x => x.InactiveDate == null && x.EndDate > DateTime.Now).ToList();
            dgvNotes.DataSource = DateNotes.Select(x => new {  Note= x.Note, AppearOnBookings= x.AppearOnAddingBooking, AppearOnRostering= x.AppearOnRoster, StartDate = x.StartDate.ToShortDateString(), EndDate=x.EndDate.ToShortDateString()}).ToList();
            

        }
        void RebindDateLockouts()
        {
            var unitOfWork = new UnitOfWork();
            DateLockouts = unitOfWork.LockedOutDateRepository.Get(x => x.EndDate > DateTime.Now, includeProperties: "LockOutTimes").ToList();
            dgvLocked.DataSource = DateLockouts.Select(x => new {Name=x.Name, StartDate = x.StartDate.ToShortDateString(), EndDate = x.EndDate.ToShortDateString(), Times= string.Join(",",x.LockOutTimes.Select(y=> y.StartTime.ToShortTimeString()+ "- " + y.EndTime.ToShortTimeString()) )}).ToList();

        }
    }
}
