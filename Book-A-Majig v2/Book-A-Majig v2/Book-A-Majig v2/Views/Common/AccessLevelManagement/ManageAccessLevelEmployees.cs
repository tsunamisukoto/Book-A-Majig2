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

namespace Book_A_Majig_v2.Views.Common.RestaurantManagement
{
    public partial class ManageAccessLevelEmployees : Form
    {
        public ManageAccessLevelEmployees()
        {
            InitializeComponent();
        }
        public Employee user { get; set; }
        public int? AccessLevelID { get; set; }
        private AccessLevel accessLevel;
        UnitOfWork unitOfWork;
        List<Employee> EmployeesAssigned;
        List<Employee> EmployeesUnassigned;
        private void ManageRestaurantEmployees_Load(object sender, EventArgs e)
        {

             unitOfWork = new UnitOfWork();
            accessLevel = unitOfWork.AccessLevelRepository.Get(x => x.Id == AccessLevelID,null,"Employees").FirstOrDefault();
            lblRestaurantName.Text = accessLevel.Name;
            Rebind();
        }
        private void Rebind()
        {
            EmployeesAssigned = accessLevel.Employees.ToList();
            var employees = EmployeesAssigned.Select(x => x.Id);
            var user = unitOfWork.EmpoyeeRepository.Get( includeProperties:"AccessLevel").ToList();
            EmployeesUnassigned = user.Where(x =>! employees.Contains(x.Id)).ToList();
            dataGridView2.DataSource = EmployeesAssigned.Select(x => new { Name = x.FullName, CurrentAccessLevel=x.AccessLevel.Name }).ToList() ;
            dataGridView1.DataSource = EmployeesUnassigned.Select(x => new { Name = x.FullName, CurrentAccessLevel = x.AccessLevel.Name }).ToList();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< dataGridView1.SelectedRows.Count; i++)
            {
                accessLevel.Employees.Add(EmployeesUnassigned[dataGridView1.SelectedRows[i].Index]);
            }
            unitOfWork.Save();
            Rebind();
        }
    }
}
