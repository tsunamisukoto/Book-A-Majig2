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
    public partial class AddCommendationClassificationSkillCategory : Form
    {
        public AddCommendationClassificationSkillCategory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
       public Employee User { get; set; }
       public EmployeeCommendationClassification classification { get; set; }
        private List<SkillCategory> availableskills;
        private void AddCommendationClassificationSkillCategory_Load(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            var listofusedIDs = classification.EmployeeCommendationSkillCategories.Select(x => x.SkillCategory.Id);
            availableskills = unitofwork.SkillCategoryRepository.Get(y => !(listofusedIDs.Contains(y.Id))).ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = availableskills;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classification.EmployeeCommendationSkillCategories.Add(new EmployeeCommendationSkillCategory() { SkillCategory=(SkillCategory)comboBox1.SelectedValue, SkillWeighting= (int)numericUpDown1.Value });
            this.DialogResult = DialogResult.OK;
        }
    }
}
