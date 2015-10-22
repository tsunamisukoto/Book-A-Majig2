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
            employees = unitOfWork.EmpoyeeRepository.Get(x => x.DateInactive == null).ToList();
            dataGridView1.DataSource = employees.Select(x => new { FullName = x.FullName }).ToList() ;
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditEmployee v = new AddEditEmployee() { User = User };
            v.ShowDialog();
            if(v.DialogResult==DialogResult.OK)
            {
                Rebind();
            }
        }
    }
}
