using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Common.RestaurantManagement;
using Book_A_Majig_v2.Views.Common.RoleManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Common.AccessLevelManagement
{
    public partial class ViewAccessLevels : Form
    {
        public ViewAccessLevels()
        {
            InitializeComponent();
        }

        private void ViewAccessLevels_Load(object sender, EventArgs e)
        {
            Rebind();
        }
        public Employee User { get; set; }

        List<AccessLevel> accessLevels = new List<AccessLevel>();
        void Rebind()
        {
            var unitOfWork = new UnitOfWork();
            accessLevels = unitOfWork.AccessLevelRepository.Get( includeProperties:"Employees").ToList();
            dgvAccessLevels.DataSource = accessLevels.Select(x => new { Name = x.Name, AuthorityLevel = x.Level ,Employees = x.Employees.Where(y=> y.DateInactive== null).Count()}).ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditAccessLevel aeal = new AddEditAccessLevel();
            aeal.ShowDialog();
            if(aeal.DialogResult==DialogResult.OK)
            {
                Rebind();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvAccessLevels.SelectedRows.Count>0)
            {
                AddEditAccessLevel aeal = new AddEditAccessLevel();
                aeal.AccessLevelId = accessLevels[dgvAccessLevels.SelectedRows[0].Index].Id;
                aeal.ShowDialog();
                if (aeal.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvAccessLevels.SelectedRows.Count > 0)
            {
                ManagePermissions aeal = new ManagePermissions();
                aeal.AccessLevelId = accessLevels[dgvAccessLevels.SelectedRows[0].Index].Id;
                aeal.ShowDialog();
                if (aeal.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvAccessLevels.SelectedRows.Count > 0)
            {
                ManageAccessLevelEmployees aeal = new ManageAccessLevelEmployees();
                aeal.AccessLevelID = accessLevels[dgvAccessLevels.SelectedRows[0].Index].Id;
                aeal.ShowDialog();
                if (aeal.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }
        }

        private void dgvAccessLevels_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
