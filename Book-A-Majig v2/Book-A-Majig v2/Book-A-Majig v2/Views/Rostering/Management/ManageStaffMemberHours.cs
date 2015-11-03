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

            Rebind();
        }
        private void Rebind()
        {
            var unitofwork = new UnitOfWork();
            var allemployeeavailabilities = unitofwork.EmployeeAvailabilityRepository.Get(x => x.Employee.Id == EditedUserID&& x.StartDate< DateTime.Now && (x.EndDate==null || x.EndDate>DateTime.Now), includeProperties: "Employee").ToList();
            BuildButton(allemployeeavailabilities, 1, button1);
            BuildButton(allemployeeavailabilities, 2, button2);
            BuildButton(allemployeeavailabilities, 3, button3);
            BuildButton(allemployeeavailabilities, 4, button4);
            BuildButton(allemployeeavailabilities, 5, button5);
            BuildButton(allemployeeavailabilities, 6, button6);
            BuildButton(allemployeeavailabilities, 0, button7);
            lblEmployeeName.Text = unitofwork.EmpoyeeRepository.GetByID(EditedUserID).FullName;
        }
        private void BuildButton(List<EmployeeAvailabilityDay> allEmployeeAvailabilityDays, int day, Button b)
        {
            var item = allEmployeeAvailabilityDays.Where(x => x.DayOfWeek == day).OrderByDescending(x => x.DateAdded).FirstOrDefault();
            var s = Enum.GetName(typeof(DayOfWeek), day);
            s += item.StartTime.ToShortTimeString() +( item.FinishTime.HasValue?" - "+item.FinishTime.Value.ToShortTimeString():"")+"\n" ;
            b.Text = s;
            b.Click += B_Click;
            b.Tag = day;
        }

        private void B_Click(object sender, EventArgs e)
        {
            int day = (int)(((Button)sender).Tag);
            AddEditDayAvailability aeda = new AddEditDayAvailability();
            aeda.User = User;
            aeda.DayOfWeek = day;
            aeda.EditedUserID = EditedUserID;
            aeda.ShowDialog();
            
        }
    }
}
