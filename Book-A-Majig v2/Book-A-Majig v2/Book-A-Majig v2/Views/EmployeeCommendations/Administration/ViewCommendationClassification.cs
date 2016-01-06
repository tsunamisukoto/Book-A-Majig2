﻿using Book_A_Majig_v2.DatabaseEntities;
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
    public partial class ViewCommendationClassification : Form
    {
        public ViewCommendationClassification()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }

        private void ViewCommendationClassification_Load(object sender, EventArgs e)
        {
            Rebind();
        }
        List<EmployeeCommendationClassification> commendations = new List<EmployeeCommendationClassification>();
        private void Rebind()
        {

            var unitofwork = new UnitOfWork();
            commendations = unitofwork.EmployeeCommendationClassificationRepository.Get().ToList() ;
            dataGridView1.DataSource = commendations.Select(x => new { Name = x.Name }).ToList() ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditCommendationClassification aecc = new AddEditCommendationClassification();
            aecc.User = User;
            aecc.ShowDialog();
            if (aecc.DialogResult == DialogResult.OK)
            {
                Rebind();
            }
        }
    }
}
