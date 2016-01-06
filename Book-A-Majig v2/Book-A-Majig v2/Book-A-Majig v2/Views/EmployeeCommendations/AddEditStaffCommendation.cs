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

namespace Book_A_Majig_v2.Views.EmployeeCommendations
{
    public partial class AddEditStaffCommendation : Form
    {
        public AddEditStaffCommendation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            //TODO: Validate Inputs
            if (currentCommendationId != null)
            {

                unitOfWork.EmployeeCommendationRepository.Update(GetFields(currentCommendation));

            }
            else
            {
                currentCommendation = GetFields(new EmployeeCommendation());
                currentCommendation.DateCreated = DateTime.Now;

                unitOfWork.EmployeeCommendationRepository.Insert(currentCommendation);
            }
            unitOfWork.Save();
            this.DialogResult = DialogResult.OK;
        }
        EmployeeCommendation GetFields(EmployeeCommendation work)
        {
            work.CommendedBy = User;
            work.RecievingEmployee = (Employee)cbEmployee.SelectedValue;
            work.Notes = txtNotes.Text;
            work.EmployeeCommendationClassification = (EmployeeCommendationClassification)cbClassification.SelectedValue;
            return work;
        }
        public Employee User { get; set; }
        private EmployeeCommendation currentCommendation { get; set; }
        public int? currentCommendationId { get; set; }
        private void AddEditStaffCommendation_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
          
            cbEmployee.DisplayMember = "FullName";

            
            cbClassification.DisplayMember = "Name";
            cbEmployee.DataSource = unitOfWork.EmployeeRepository.Get(x => x.DateInactive == null).ToList();
            cbClassification.DataSource = unitOfWork.EmployeeCommendationClassificationRepository.Get(x=> x.AvailableOnUser).ToList();
            
            if (currentCommendationId!= null)
            {
                currentCommendation = unitOfWork.EmployeeCommendationRepository.Get(x => x.Id == currentCommendationId).FirstOrDefault();

            }
        }
    }
}
