using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;

namespace Book_A_Majig_v2.Views.Rostering.ReusableControls
{
    public partial class UserDropdown : UserControl
    {
        public UserDropdown()
        {
            InitializeComponent();
        }
        public Expression<Func<Employee, bool>> Filter { get; set; }
        List<Employee> EmployeeList { get; set; }
        private Employee _sEmployee;
        public Employee SelectedEmployee
        {
            get
            {
                return EmployeeList[ddlUsers.SelectedIndex];
            }
            set
            {
                _sEmployee = value;
                if(ddlUsers!=null)
                ddlUsers.SelectedValue = value.Id;
            }

        }
        private void UserDropdown_Load(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            EmployeeList = unitofwork.EmpoyeeRepository.Get(Filter, x => x.OrderBy(y => y.FullName)).ToList();
            ddlUsers.DisplayMember = "FullName";
            ddlUsers.ValueMember = "Id";
            ddlUsers.DataSource = EmployeeList;
        }
    }
}
