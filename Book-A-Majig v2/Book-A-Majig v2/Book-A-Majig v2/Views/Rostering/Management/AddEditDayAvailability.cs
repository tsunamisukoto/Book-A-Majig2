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

namespace Book_A_Majig_v2.Views.Rostering.Management
{
    public partial class AddEditDayAvailability : Form
    {
        public AddEditDayAvailability()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        public int EditedUserID { get; set; }
        public int DayOfWeek { get; set; }

        private void AddEditDayAvailability_Load(object sender, EventArgs e)
        {
            AvailabilityService aservice = new AvailabilityService();

            var mostRecentIterationOfDay = aservice.AvailabilityForDay(EditedUserID, DayOfWeek, d: DateTime.Today);
            if(mostRecentIterationOfDay!=null)
            {
                tbNotes.Text = mostRecentIterationOfDay.Notes;
                dtpStartTime.Value = mostRecentIterationOfDay.StartTime;
                if (mostRecentIterationOfDay.FinishTime.HasValue)
                    dtpEndTime.Value = mostRecentIterationOfDay.FinishTime.Value;
            }
            else
            {
                dtpStartDate.Value = DateTime.Now;
            }

         

        }
        private EmployeeAvailabilityDay GetFields(EmployeeAvailabilityDay ead)
        {
            ead.DayOfWeek = DayOfWeek;
            ead.StartDate = dtpStartDate.Value;
            ead.StartTime = dtpStartTime.Value;
            if (!cbEndTime.Checked)
                ead.FinishTime = dtpEndTime.Value;
            else
                ead.FinishTime = null;
            if (cbEndDate.Checked)
                ead.EndDate = dtpEndTime.Value;
            ead.Notes = tbNotes.Text;
            ead.DateAdded = DateTime.Now;
            var unitOfWork = new UnitOfWork();
            ead.Employee = unitOfWork.EmpoyeeRepository.GetByID(EditedUserID);
            return ead;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            unitofwork.EmployeeAvailabilityRepository.Insert(GetFields(new EmployeeAvailabilityDay()));
            unitofwork.Save();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void rbFromToday_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = !rbFromToday.Checked;
        }

        private void cbEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = cbEndDate.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndTime.Enabled = cbEndTime.Checked;
        }
    }
}
