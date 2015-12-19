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
            Categories = unitofwork.SkillCategoryRepository.Get(includeProperties: "Parent,Children").ToList();
            dataGridView1.DataSource = Categories.Select(x => new { Name = x.Name });
        }
    }
}
