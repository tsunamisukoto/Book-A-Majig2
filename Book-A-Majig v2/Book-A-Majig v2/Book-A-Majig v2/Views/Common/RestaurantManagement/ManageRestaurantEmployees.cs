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
    public partial class ManageRestaurantEmployees : Form
    {
        public ManageRestaurantEmployees()
        {
            InitializeComponent();
        }
        public Employee user { get; set; }
        public int? RestaurantID { get; set; }
        private Restaurant Restaurant;
        UnitOfWork unitOfWork;
        List<Employee> EmployeesAssigned;
        List<Employee> EmployeesUnassigned;
        private void ManageRestaurantEmployees_Load(object sender, EventArgs e)
        {

             unitOfWork = new UnitOfWork();
            Restaurant = unitOfWork.RestaurantRepository.Get(x => x.Id == RestaurantID,null,"Employees").FirstOrDefault();
            lblRestaurantName.Text = Restaurant.Name;
            Rebind();
        }
        private void Rebind()
        {
            EmployeesAssigned = Restaurant.Employees.ToList();
            var employees = EmployeesAssigned.Select(x => x.Id);
            var user = unitOfWork.EmpoyeeRepository.Get().ToList();
            EmployeesUnassigned = user.Where(x =>! employees.Contains(x.Id)).ToList();
            dataGridView2.DataSource = EmployeesAssigned.Select(x => new { Name = x.FullName }).ToList() ;
            dataGridView1.DataSource = EmployeesUnassigned.Select(x => new { Name = x.FullName }).ToList();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< dataGridView1.SelectedRows.Count; i++)
            {
                Restaurant.Employees.Add(EmployeesUnassigned[dataGridView1.SelectedRows[i].Index]);
            }
            unitOfWork.Save();
            Rebind();
        }
    }
}
