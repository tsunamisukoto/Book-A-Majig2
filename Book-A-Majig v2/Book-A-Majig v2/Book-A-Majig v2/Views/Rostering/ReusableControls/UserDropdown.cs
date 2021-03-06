﻿using System;
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
                if(ddlUsers.SelectedValue!=null)
                return EmployeeList[ddlUsers.SelectedIndex];
                return null;
            }
            set
            {
                _sEmployee = value;
                if(ddlUsers!=null&& value!=null)
                ddlUsers.SelectedValue = value.Id;
            }

        }
        private void UserDropdown_Load(object sender, EventArgs e)
        {
          
        }
        public void Rebind()
        {
            var unitofwork = new UnitOfWork();
            EmployeeList = unitofwork.EmployeeRepository.Get(Filter, x => x.OrderBy(y => y.FirstName)).ToList();
            ddlUsers.DisplayMember = "FullName";
            ddlUsers.ValueMember = "Id";
            ddlUsers.DataSource = EmployeeList;
        }
    }
}
