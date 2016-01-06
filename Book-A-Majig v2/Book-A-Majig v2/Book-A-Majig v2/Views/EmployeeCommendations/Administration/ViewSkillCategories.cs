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

namespace Book_A_Majig_v2.Views.EmployeeCommendations.Administration
{
    public partial class ViewSkillCategories : Form
    {
        public ViewSkillCategories()
        {
            InitializeComponent();
        }

        private void ViewSkillCategories_Load(object sender, EventArgs e)
        {
            Rebind();
        }
        List<SkillCategory> Categories = new List<SkillCategory>();
        void Rebind()
        {
            var unitofwork = new UnitOfWork();
            Categories = unitofwork.SkillCategoryRepository.Get(includeProperties: "Paremt,Children").ToList();
            dataGridView1.DataSource = Categories.Select(x => new { Name = x.Name }).ToList();
        }
        public Employee User { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditSkillCategory aesc = new AddEditSkillCategory();
            aesc.User = User;
            aesc.ShowDialog();
            if(aesc.DialogResult==DialogResult.OK)
            {
                Rebind();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                AddEditSkillCategory aesc = new AddEditSkillCategory();
                aesc.User = User;
                aesc.currentSkillCategoryId = Categories[dataGridView1.SelectedRows[0].Index].Id;
                aesc.ShowDialog();
                if (aesc.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                AddEditSkillCategory aesc = new AddEditSkillCategory();
                aesc.User = User;
                aesc.parentSkillCategoryId = Categories[dataGridView1.SelectedRows[0].Index].Id;
                aesc.ShowDialog();
                if (aesc.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }
        }
    }
}
