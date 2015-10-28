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

namespace Book_A_Majig_v2.Views.Common.RoleManagement
{
    public partial class AddEditAccessLevel : Form
    {
        public AddEditAccessLevel()
        {
            InitializeComponent();
          
        }
        private AccessLevel WorkingLevel { get; set; }
        public int? AccessLevelId { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                var unitOfWork = new UnitOfWork();
                if (AccessLevelId == null)
                {
                    WorkingLevel = new AccessLevel() { Level = (int)numericUpDown1.Value, Name = textBox1.Text };
                    unitOfWork.AccessLevelRepository.Insert(WorkingLevel);

                }
                else
                {
                    WorkingLevel.Name = textBox1.Text;
                    WorkingLevel.Level = (int)numericUpDown1.Value;
                    unitOfWork.AccessLevelRepository.Update(WorkingLevel);
                }
                unitOfWork.Save();


                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddEditAccessLevel_Load(object sender, EventArgs e)
        {
            if (AccessLevelId != null)
            {
                var unitOfWork = new UnitOfWork();

                WorkingLevel = unitOfWork.AccessLevelRepository.GetByID(AccessLevelId);
                textBox1.Text = WorkingLevel.Name;
                numericUpDown1.Value = WorkingLevel.Level;
            }
        }
    }
}
