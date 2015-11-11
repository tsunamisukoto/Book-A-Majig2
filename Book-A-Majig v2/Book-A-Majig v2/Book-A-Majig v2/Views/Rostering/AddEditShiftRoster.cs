﻿using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Rostering
{
    public partial class AddEditShiftRoster : Form
    {
        public Employee User { get; set; }
        public int DayOfWeek { get;  set; }
        public int RosterId { get;  set; }
        private Shift WorkingShift;
        private List<Employee> AvailableEmployees;
        public AddEditShiftRoster()
        {
            InitializeComponent();
           
        }
        List<EmployeeShift> ShiftSlots=new List<EmployeeShift>();
        private void button4_Click(object sender, EventArgs e)
        {
            var newshift = new EmployeeShift() { StartTime = dateTimePicker1.Value, EmployeeShiftCategory = new EmployeeLevelCategory() { MinLevelStaffMember = 5, Name = "SSS" } };
            if(checkBox1.Checked)
            {
                newshift.EndTime = dateTimePicker3.Value;
            }
            else
            {
                newshift.EndTime = null;
            }
            ShiftSlots.Add(newshift);
            RebindShiftSlots();
        }

        private void RebindShiftSlots()
        {
            dgvSlotsToFill.DataSource = ShiftSlots.Select(x => new {StartTime = x.StartTime, EndTime=x.EndTime, Employee = x.Employee!=null? x.Employee.FullName:"" }).ToList();
        }

        private void AddEditShiftRoster_Load(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            WorkingShift = unitofwork.ShiftRepository.Get(x => x.DayOfTheWeek == DayOfWeek && x.RosterId == RosterId, includeProperties: "EmployeeShifts").FirstOrDefault();

            if(WorkingShift!=null)
            {
                ShiftSlots = WorkingShift.EmployeeShifts.ToList();
                txtNotes.Text = WorkingShift.Notes;
                RebindShiftSlots();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Enabled = checkBox1.Checked;
        }
        public Shift GetFields(Shift s)
        {
            s.DayOfTheWeek = DayOfWeek;
            s.ShiftCategory = new ShiftCategory() {  CategoryName="SSSS"};
            s.EmployeeShifts = ShiftSlots;
            s.Notes = txtNotes.Text;
            s.RosterId = RosterId;
            return s;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            if(WorkingShift==null)
            {
                unitofwork.ShiftRepository.Insert(GetFields(new Shift()));
            }
            else
            {
                unitofwork.ShiftRepository.Update(GetFields(WorkingShift));
            }
            unitofwork.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void dgvAvailableUsers_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvSlotsToFill_SelectionChanged(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();

            var listofemployeeidsinuse = ShiftSlots.Where(y => y.Employee != null).Select(y => y.Employee.Id).ToList();
            AvailableEmployees = unitofwork.EmpoyeeRepository.Get(x=>!listofemployeeidsinuse.Contains(x.Id) ).ToList();
            dgvAvailableUsers.DataSource = AvailableEmployees.Select(x => new { EmployeeName = x.FullName, Suitability = 0 }).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(dgvAvailableUsers.SelectedRows.Count>0&& dgvSlotsToFill.SelectedRows.Count>0)
            {
                ShiftSlots[dgvSlotsToFill.SelectedRows[0].Index].Employee=AvailableEmployees[dgvAvailableUsers.SelectedRows[0].Index];
                RebindShiftSlots();
            }
        }
    }
}
