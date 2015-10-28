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
    public partial class ManagePermissions : Form
    {
        public Employee User { get; set; }

        public ManagePermissions()
        {
            InitializeComponent();
        }

        private AccessLevel WorkingLevel { get; set; }
        public int? AccessLevelId { get; set; }
        private void ManagePermissions_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

            WorkingLevel = unitOfWork.AccessLevelRepository.Get(x => x.Id == AccessLevelId, includeProperties: "Permissions").FirstOrDefault();
            label3.Text = WorkingLevel.Name;

            foreach (var v in AllPermissions.PermissionList())
            {
                checkedListBox1.Items.Add(v.PermissionName, v.PermissionValue);
            }
            for(int i = 0; i<WorkingLevel.Permissions.Count; i++)
            {
                if(checkedListBox1.Items.IndexOf(WorkingLevel.Permissions.ElementAt(i).PermissionName)!=-1)
                {
                    checkedListBox1.SetItemChecked(checkedListBox1.Items.IndexOf(WorkingLevel.Permissions.ElementAt(i).PermissionName), WorkingLevel.Permissions.ElementAt(i).PermissionValue);
                }
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            for(int i = 0; i< checkedListBox1.Items.Count; i++)
            {
                var permission = checkedListBox1.Items[i].ToString();
                if(WorkingLevel.Permissions.FirstOrDefault(x=> x.PermissionName== permission)==null)
                {
                    WorkingLevel.Permissions.Add(new Permissions() { PermissionName = permission, PermissionValue= checkedListBox1.GetItemChecked(i) });
                }
                else
                {
                    WorkingLevel.Permissions.FirstOrDefault(x => x.PermissionName == permission).PermissionValue = checkedListBox1.GetItemChecked(i);
                }
             
            }
            unitOfWork.Save();

            this.DialogResult = DialogResult.OK;
        }
    }
}
