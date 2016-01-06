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
    public partial class AddEditSkillCategory : Form
    {
        public AddEditSkillCategory()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        private SkillCategory currentSkillCategory { get; set; }
        public int? currentSkillCategoryId { get; set; }
        public int? parentSkillCategoryId { get; set; }
        private void AddEditSkillCategory_Load(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            if(currentSkillCategoryId!=null)
            {
                currentSkillCategory = unitofwork.SkillCategoryRepository.Get(x => x.Id == currentSkillCategoryId,includeProperties:"Paremt").FirstOrDefault();
                txtName.Text = currentSkillCategory.Name;
                txtNotes.Text = currentSkillCategory.Notes;
                if(currentSkillCategory.Paremt!=null)
                parentSkillCategoryId = currentSkillCategory.Paremt.Id;
            }
            if(parentSkillCategoryId!=null)
            {
                lblParent.Text= unitofwork.SkillCategoryRepository.Get(x => x.Id == parentSkillCategoryId).FirstOrDefault().Name;
            }
            else
            {
                lblParent.Text = "";
            }
        }
        private SkillCategory GetFields(SkillCategory work,SkillCategory parent)
        {
            work.Name = txtName.Text;
            work.Notes = txtNotes.Text;
            work.Paremt = parent;
            return work;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            SkillCategory parent=null;
            if(parentSkillCategoryId!= null)
                parent= unitofwork.SkillCategoryRepository.Get(x => x.Id == parentSkillCategoryId).FirstOrDefault();
            if (currentSkillCategoryId!=null)
            {
                unitofwork.SkillCategoryRepository.Update(GetFields(currentSkillCategory,parent));
            }
            else
            {
                unitofwork.SkillCategoryRepository.Insert(GetFields(new SkillCategory(),parent));

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
