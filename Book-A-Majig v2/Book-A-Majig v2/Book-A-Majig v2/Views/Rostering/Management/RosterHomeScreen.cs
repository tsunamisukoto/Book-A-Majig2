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
    public partial class RosterHomeScreen : Form
    {
        public RosterHomeScreen()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        List<EmployeeNA> EmployeeNAs = new List<EmployeeNA>();
        private void RosterHomeScreen_Load(object sender, EventArgs e)
        {
            RebindEmployeeNAs();
        }

        private void RebindEmployeeNAs()
        {
            var unitOfWork = new UnitOfWork();
            EmployeeNAs = unitOfWork.EmployeeNARepository.Get(x => x.EndDate > DateTime.Today, x=> x.OrderBy(y=>y.StartDate),includeProperties:"Employee").ToList();
            dgvNAs.DataSource = EmployeeNAs.Select(x => new {StartDate = x.StartDate, EndDate = x.EndDate, Notes= x.Notes });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewRosters v = new ViewRosters() { User = User };
            v.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewStaffMemberHours v = new ViewStaffMemberHours() { User = User };
            v.ShowDialog();
        }
    }
}
