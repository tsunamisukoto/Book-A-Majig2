using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;

namespace Book_A_Majig_v2.Views.Rostering.ReusableControls
{
    public partial class RosterDay : UserControl
    {
        public RosterDay()
        {
            InitializeComponent();
        }
        public Button btnModify { get { return this.button1; } }
        public String Label { get { return this.lblDayOfWeek.Text; } set { this.lblDayOfWeek.Text = value; } }
        private int _day;
        public int DayOfWeek {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
                lblDayOfWeek.Text = Enum.GetName(typeof(DayOfWeek), _day);
               // Rebind();
            }
        }
        List<EmployeeShift> UsersOnShift;
        public void BindRoster(Roster workingRoster)
        {
            var unitOfWork = new UnitOfWork();
           UsersOnShift= unitOfWork.ShiftRepository.Get(x => x.DayOfTheWeek == _day && x.RosterId==workingRoster.Id,includeProperties: "EmployeeShifts.EmployeeShiftAssignments").SelectMany(x=> x.EmployeeShifts).ToList();
            dataGridView1.DataSource = UsersOnShift.Select(x => new { Employee = x.Employee==null?"": x.Employee.FullName, ShiftTime = x.StartTime }).ToList();
        }
    }
}
