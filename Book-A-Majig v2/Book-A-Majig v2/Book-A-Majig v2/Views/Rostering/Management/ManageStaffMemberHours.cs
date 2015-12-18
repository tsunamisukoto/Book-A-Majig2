using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Rostering.ReusableControls;
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
    public partial class ManageStaffMemberHours : Form
    {
        public ManageStaffMemberHours()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        public int EditedUserID { get; set; }
        private void ManageStaffMemberHours_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.Date;
            
            staffMemberDayAvailability1.btnModify.Click += B_Click;
            staffMemberDayAvailability2.btnModify.Click += B_Click;
            staffMemberDayAvailability3.btnModify.Click += B_Click;
            staffMemberDayAvailability4.btnModify.Click += B_Click;
            staffMemberDayAvailability5.btnModify.Click += B_Click;
            staffMemberDayAvailability6.btnModify.Click += B_Click;
            staffMemberDayAvailability7.btnModify.Click += B_Click;
            Rebind();
            RebindEmployeeNAs();
        }
        private void RebindEmployeeNAs()
        {
            var unitOfWork = new UnitOfWork();
            EmployeeNAs = unitOfWork.EmployeeNARepository.Get(x => x.EndDate > DateTime.Today && x.Employee.Id==EditedUserID, x => x.OrderBy(y => y.StartDate), includeProperties: "Employee").ToList();
            dgvNAs.DataSource = EmployeeNAs.Select(x => new { StartDate = x.StartDate, EndDate = x.EndDate, Notes = x.Notes }).ToList();
        }
        List<EmployeeNA> EmployeeNAs = new List<EmployeeNA>();
        private void Rebind()
        {
            var newRestaurant = new Restaurant() { Capacity = 100, Name = "Rebellion", Location = "Sydney", RosteringStartDay = (int)DayOfWeek.Monday, RosteringWeekDuration = 1, RosteringWeekOffset = 0 };

            var unitofwork = new UnitOfWork();
            BuildButton(newRestaurant.RosteringStartDay + 0, staffMemberDayAvailability1);
            BuildButton(newRestaurant.RosteringStartDay + 1, staffMemberDayAvailability2);
            BuildButton(newRestaurant.RosteringStartDay + 2, staffMemberDayAvailability3);
            BuildButton(newRestaurant.RosteringStartDay + 3, staffMemberDayAvailability4);
            BuildButton(newRestaurant.RosteringStartDay + 4, staffMemberDayAvailability5);
            BuildButton(newRestaurant.RosteringStartDay + 5, staffMemberDayAvailability6);
            BuildButton(newRestaurant.RosteringStartDay + 6, staffMemberDayAvailability7);

            lblEmployeeName.Text = unitofwork.EmpoyeeRepository.GetByID(EditedUserID).FullName;
        }
        private void BuildButton( int day, StaffMemberDayAvailability b)
        {
            AvailabilityService aservice = new AvailabilityService();
            if (day > 6)
                day = day % 7;
            b.Label = Enum.GetName(typeof(DayOfWeek), day); 
            var s = "";
            var item = aservice.AvailabilityForDay(EditedUserID, day, dateTimePicker1.Value);
            if(item!=null)
            {
                s += item.StartTime.ToShortTimeString() + (item.FinishTime.HasValue ? " - " + item.FinishTime.Value.ToShortTimeString() : "") + "\n";
              
         
            }
            else
            {
                s += "No Availability Set";
            }
            b.btnModify.Tag = day;
            b.rtbDetails.Text = s;
        } 

        private void B_Click(object sender, EventArgs e)
        {
            int day = (int)(((Button)sender).Tag);
            AddEditDayAvailability aeda = new AddEditDayAvailability();
            aeda.User = User;
            aeda.DayOfWeek = day;
            aeda.EditedUserID = EditedUserID;
            aeda.ShowDialog();
            if(aeda.DialogResult==DialogResult.OK)
            {
             
                Rebind();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Rebind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditNA aena = new AddEditNA() { User = User };
            aena.ShowDialog();
            if (aena.DialogResult == DialogResult.OK)
            {
                RebindEmployeeNAs();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvNAs.SelectedRows.Count > 0)
            {
                AddEditNA aena = new AddEditNA() { User = User };
                aena.NAID = EmployeeNAs[dgvNAs.SelectedRows[0].Index].Id;
                aena.ShowDialog();
                if (aena.DialogResult == DialogResult.OK)
                {
                    RebindEmployeeNAs();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvNAs.SelectedRows.Count > 0)
            {
                var unitofwork = new UnitOfWork();
                unitofwork.EmployeeNARepository.Delete(EmployeeNAs[dgvNAs.SelectedRows[0].Index]);
                unitofwork.Save();
                RebindEmployeeNAs();
            }
        }
    }
}
