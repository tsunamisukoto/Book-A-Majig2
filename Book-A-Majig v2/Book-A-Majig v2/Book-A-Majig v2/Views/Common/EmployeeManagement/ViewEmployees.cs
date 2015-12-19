using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Rostering.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Common
{
    public partial class ViewEmployees : Form
    {
        public Employee User { get; set; }

        public ViewEmployees()
        {
            InitializeComponent();
        }
        private List<Employee> employees;
        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            Rebind();
        }
        private void Rebind()
        {
            var unitOfWork = new UnitOfWork();
            employees = unitOfWork.EmployeeRepository.Get(x => x.DateInactive == null,null, "AccessLevel").ToList();
            dataGridView1.DataSource = employees.Select(x => new {ID=x.Id, FullName = x.FullName, AccessLevel= x.AccessLevel.Name }).ToList() ;
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditEmployee v = new AddEditEmployee() { User = User };
            v.ShowDialog();
            if (v.DialogResult == DialogResult.OK)
            {
                Rebind();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int workingIndex = dataGridView1.SelectedRows[0].Index;
                AddEditEmployee c = new AddEditEmployee();
                c.User = User;
                c.currentEmployeeId = employees[workingIndex].Id;

                c.ShowDialog();
                if(c.DialogResult==DialogResult.OK)
                {
                    Rebind();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                ManageStaffMemberHours msmh = new ManageStaffMemberHours();
                msmh.User = User;
                msmh.EditedUserID = employees[dataGridView1.SelectedRows[0].Index].Id;
                msmh.ShowDialog();
                if (msmh.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }
           
        }
    }
}
