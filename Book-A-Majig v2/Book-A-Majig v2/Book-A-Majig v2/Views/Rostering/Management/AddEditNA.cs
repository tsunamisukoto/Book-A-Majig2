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
    public partial class AddEditNA : Form
    {
        public AddEditNA()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        public Employee EditedUser { get; set; }
        public int? NAID { get; set; }
        private EmployeeNA workingNA;
        private List<Employee> AllEmployees;
        private void AddEditNA_Load(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            AllEmployees =unitofwork.EmpoyeeRepository.Get(x => x.DateInactive == null).ToList();
            cbEmployees.DataSource = AllEmployees.ToList();
            cbEmployees.ValueMember="Id";
            cbEmployees.DisplayMember = "FullName";
            if(NAID!=null)
            {
                workingNA = unitofwork.EmployeeNARepository.Get(x => x.Id == NAID,includeProperties: "Employee").FirstOrDefault();
                EditedUser = workingNA.Employee;
                tbNotes.Text = workingNA.Notes;
                
            }
            if (EditedUser != null)
            {
                cbEmployees.SelectedValue = EditedUser.Id;
                cbEmployees.Enabled = false;    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

            if (NAID!= null)
            {
                unitOfWork.EmployeeNARepository.Update(GetFields(workingNA));

            }
            else
            {
                unitOfWork.EmployeeNARepository.Insert(GetFields(new EmployeeNA()));
            }
            unitOfWork.Save();
            this.DialogResult = DialogResult.OK;
        }
        private EmployeeNA GetFields(EmployeeNA ena)
        {
            var unitOfWork = new UnitOfWork();
            ena.Employee = unitOfWork.EmpoyeeRepository.GetByID(cbEmployees.SelectedValue);
            ena.StartDate = dtpStartDate.Value;
            ena.EndDate = dtpEndDate.Value;
            if(cbStartTime.Checked)
            {
                ena.StartDate = ena.StartDate.Date.AddHours(dtpStartTime.Value.Hour).AddMinutes(dtpStartTime.Value.Minute);
            }
            else
            {
                ena.StartDate = ena.StartDate.Date;
            }
            if (cbEndTime.Checked)
            {
                ena.EndDate = ena.EndDate.Date.AddHours(dtpEndTime.Value.Hour).AddMinutes(dtpEndTime.Value.Minute);
            }
            else
            {
                ena.EndDate = ena.EndDate.Date.AddDays(1).AddTicks(-1);
            }
            ena.SubmittedBy= unitOfWork.EmpoyeeRepository.GetByID(User.Id);
            ena.SubmittedDate = DateTime.Today;
            ena.Notes = tbNotes.Text;
            return ena;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
