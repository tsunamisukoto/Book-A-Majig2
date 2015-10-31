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

namespace Book_A_Majig_v2.Views.Common.RestaurantManagement.RestaurantDates
{
    public partial class AddEditDateNote : Form
    {
        public AddEditDateNote()
        {
            InitializeComponent();
        }
        public Employee user { get; set; }
        public int? DateNoteID { get; set; }
        private DateNote workingnote { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

            if (DateNoteID.HasValue)
            {
       

                unitOfWork.DateNoteRepository.Update(GetFields(workingnote));
            }
            else
            {
               

                unitOfWork.DateNoteRepository.Insert(GetFields(new DateNote()));

            }
            unitOfWork.Save();
            this.DialogResult = DialogResult.OK;
        }
        private DateNote GetFields(DateNote dnote)
        {

            dnote.Note = tbNote.Text;
            dnote.AppearOnAddingBooking = cbAppearOnBooking.Checked;
            dnote.AppearOnRoster = cbAppearOnRoster.Checked;
            dnote.StartDate = dtpStart.Value;
            dnote.EndDate = dtpEnd.Value;
            dnote.DateCreated = DateTime.Now;
            dnote.Restaurant = new UnitOfWork().RestaurantRepository.Get().FirstOrDefault();
            return dnote;
        }
        private void AddEditDateNote_Load(object sender, EventArgs e)
        {
            if(DateNoteID.HasValue)
            {
                var unitOfWork = new UnitOfWork();
                workingnote = unitOfWork.DateNoteRepository.GetByID(DateNoteID);
                dtpStart.Value = workingnote.StartDate;
                dtpEnd.Value = workingnote.EndDate;
                cbAppearOnBooking.Checked = workingnote.AppearOnAddingBooking;
                cbAppearOnRoster.Checked = workingnote.AppearOnRoster;
                tbNote.Text = workingnote.Note;
            }
        }
    }
}
