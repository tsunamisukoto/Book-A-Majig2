using Book_A_Majig_v2.DatabaseEntities;
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
    public partial class CommendationAdministrationHome : Form
    {
        public CommendationAdministrationHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSkillCategories vsc = new ViewSkillCategories();
            vsc.User = User;
            vsc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewCommendationClassification vcc = new ViewCommendationClassification();
            vcc.User = User;
            vcc.ShowDialog();
        }
        public Employee User { get; set; }

        private void CommendationAdministrationHome_Load(object sender, EventArgs e)
        {

        }
    }
}
