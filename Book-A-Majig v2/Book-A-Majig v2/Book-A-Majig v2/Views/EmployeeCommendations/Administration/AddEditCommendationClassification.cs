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
    public partial class AddEditCommendationClassification : Form
    {
        public AddEditCommendationClassification()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        private EmployeeCommendationClassification workingClassification { get; set; }
        public int? workingClassificationID { get; set; }
        private void AddEditCommendationClassification_Load(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            if(workingClassificationID!=null)
            {
                workingClassification = unitofwork.EmployeeCommendationClassificationRepository.Get(x => x.Id == workingClassificationID,includeProperties: "EmployeeCommendationSkillCategories.SkillCategory").FirstOrDefault();
                textBox1.Name = workingClassification.Name;
                numericUpDown1.Value = workingClassification.Weighting;

                checkBox1.Checked= workingClassification.AvailableOnUser  ;
                checkBox2.Checked= workingClassification.AvailableOnTeam  ;
            }
            else
            {
                workingClassification = new EmployeeCommendationClassification();

            }
            RebindSkills();
        }
        private List<EmployeeCommendationSkillCategory> skills = new List<EmployeeCommendationSkillCategory>();
        private void RebindSkills()
        {
            var unitofwork = new UnitOfWork();
            skills = workingClassification.EmployeeCommendationSkillCategories.ToList(); ;
            dataGridView1.DataSource = skills.Select(x => new { Name = x.SkillCategory.Name, Weighting = x.SkillWeighting }).ToList();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddCommendationClassificationSkillCategory accsc = new AddCommendationClassificationSkillCategory();
            accsc.User = User;
            accsc.classification = workingClassification;
            accsc.ShowDialog();
            if(accsc.DialogResult==DialogResult.OK)
            {
                RebindSkills();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                workingClassification.EmployeeCommendationSkillCategories.Remove(workingClassification.EmployeeCommendationSkillCategories.ElementAt(dataGridView1.SelectedRows[0].Index));
                RebindSkills();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            workingClassification.Name = textBox1.Text;
            workingClassification.Weighting = (int)numericUpDown1.Value;
            workingClassification.AvailableOnUser = checkBox1.Checked;
            workingClassification.AvailableOnTeam = checkBox2.Checked;
            if(workingClassificationID!= null)
            {
                unitofwork.EmployeeCommendationClassificationRepository.Update(workingClassification);

            }
            else
            {
                unitofwork.EmployeeCommendationClassificationRepository.Insert(workingClassification);

            }
            unitofwork.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
