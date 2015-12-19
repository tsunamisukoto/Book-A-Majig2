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
    public partial class ViewStaffMemberHours : Form
    {
        public ViewStaffMemberHours()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        private List<Employee> employees;
        private void ViewStaffMemberHours_Load(object sender, EventArgs e)
        {
            Rebind();
        }
        private void Rebind()
        {
            var unitOfWork = new UnitOfWork();
            employees = unitOfWork.EmployeeRepository.Get(x => x.DateInactive == null, includeProperties: "EmployeeAvailabilityDays").ToList();
            dataGridView1.DataSource = employees.Select(x => new { Name = x.FullName, Availability = 0 }).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ManageStaffMemberHours msmh = new ManageStaffMemberHours();
                msmh.User = User;
                msmh.EditedUserID = employees[dataGridView1.SelectedRows[0].Index].Id;
                msmh.ShowDialog();
                if(msmh.DialogResult==DialogResult.OK)
                {
                    Rebind();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
