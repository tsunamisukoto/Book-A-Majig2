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

        }
        public Employee User { get; set; }
        private EmployeeCommendation currentCommendation { get; set; }
        public int? currentCommendationId { get; set; }
        private void AddEditStaffCommendation_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

            if (currentCommendationId!= null)
            {
                currentCommendation = unitOfWork.EmployeeCommendationRepository.Get(x => x.Id == currentCommendationId).FirstOrDefault();

            }
        }
    }
}
