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
    public partial class AddEditEmployee : Form
    {

        public Employee User { get;  set; }
        private Employee currentUser { get; set; }
        public int? currentEmployeeId { get; set; }
        public AddEditEmployee()
        {
            InitializeComponent();
        }

        private void AddEditEmployee_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
   
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = unitOfWork.AccessLevelRepository.Get();
            if (currentEmployeeId != null)
            {
                currentUser = unitOfWork.EmpoyeeRepository.Get(x => x.Id == currentEmployeeId.Value, null, "AccessLevel").FirstOrDefault();
                tbFirstName.Text = currentUser.FirstName;
                tbLastName.Text = currentUser.LastName;
                tbEmail.Text = currentUser.Email;
                tbPhoneNumber.Text = currentUser.PhoneNumber;
                tbID.Text = currentUser.Id.ToString();
                comboBox1.SelectedValue = currentUser.AccessLevel.Id;
            }
        }
        private Employee GetFields(Employee b)
        {
            b.FirstName = tbFirstName.Text;
            b.LastName = tbLastName.Text;
            b.AccessLevel_Id = (int)comboBox1.SelectedValue;
            b.Email = tbEmail.Text;
            b.PhoneNumber = tbPhoneNumber.Text;
            b.Id = int.Parse(tbID.Text);
            return b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
        

            if (currentUser == null)
            {
                Employee newUser;
                newUser = GetFields(new Employee());
               

                unitOfWork.EmpoyeeRepository.Insert(newUser);
                unitOfWork.Save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                currentUser = GetFields(currentUser);
                unitOfWork.EmpoyeeRepository.Update(currentUser);
                DialogResult = DialogResult.OK;

            }
        }
    }
}
