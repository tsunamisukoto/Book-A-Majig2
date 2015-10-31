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
    public partial class AddEditLockedDate : Form
    {
        public AddEditLockedDate()
        {
            InitializeComponent();
        }
        public Employee user { get; set; }
        public int? LockedDateID { get; set; }
        private LockOutDate workinglockedDate { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                dataGridView1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                dateTimePicker3.Visible = false;
                dateTimePicker4.Visible = false;
                button3.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                dateTimePicker3.Visible = true;
                dateTimePicker4.Visible = true;
                button3.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtpEnd.Visible = !radioButton1.Checked;
            dtpEnd.Enabled = !radioButton1.Checked;
            label7.Visible = !radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();

            if (LockedDateID.HasValue)
            {
                unitofwork.LockedOutDateRepository.Update(GetFields(workinglockedDate));
            }
            else
            {
                unitofwork.LockedOutDateRepository.Insert(GetFields(new LockOutDate()));
            }
            unitofwork.Save();
            this.DialogResult = DialogResult.OK;
        }
        private LockOutDate GetFields(LockOutDate d)
        {
            d.StartDate = dtpStart.Value;
            d.EndDate = dtpEnd.Value;
            d.Name = tbTitle.Text;
            d.Reason = tbDescription.Text;
            return d;
        }
        private void AddEditLockedDate_Load(object sender, EventArgs e)
        {
            if(LockedDateID.HasValue)
            {
                var unitofwork = new UnitOfWork();
                workinglockedDate = unitofwork.LockedOutDateRepository.Get(x => x.Id == LockedDateID.Value, includeProperties:"LockOutTimes").FirstOrDefault();
                tbTitle.Text = workinglockedDate.Name;
                tbDescription.Text = workinglockedDate.Reason;
                dtpStart.Value = workinglockedDate.StartDate;
                dtpEnd.Value = workinglockedDate.EndDate;
            }
        }
    }
}
