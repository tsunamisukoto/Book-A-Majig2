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

namespace Book_A_Majig_v2.Views.EmployeeCommendations
{
    public partial class ViewCommendations : Form
    {
        public Employee User { get; set; }

        public ViewCommendations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ViewCommendations_Load(object sender, EventArgs e)
        {
            RebindStaffCommendations();
            RebindTeamCommendations();
            RebindTopStaffMembers();
        }
        List<EmployeeCommendation> staffcommendations = new List<EmployeeCommendation>();
        void RebindStaffCommendations()
        {
            var unitofwork = new UnitOfWork();
            staffcommendations = unitofwork.EmployeeCommendationRepository.Get(includeProperties:"RecievingEmployee").ToList();
            dgvStaffCommentations.DataSource = staffcommendations.Select(x => new { StaffName = x.RecievingEmployee.FullName }).ToList();
        }
        List<TeamCommendation> teamcommendations = new List<TeamCommendation>();
        void RebindTeamCommendations()
        {
            var unitofwork = new UnitOfWork();
            teamcommendations = unitofwork.TeamCommendationRepository.Get().ToList();
            dgvTeamCommendations.DataSource = teamcommendations.Select(x => new {Reason = x.Reason });
        }
        List<Employee> employees = new List<Employee>();

        void RebindTopStaffMembers()
        {
            var unitofwork = new UnitOfWork();
            employees = unitofwork.EmployeeRepository.Get().ToList();
            dgvTopStaff.DataSource = employees.Select(x => new { Name = x.FullName });
        }
    }
}
