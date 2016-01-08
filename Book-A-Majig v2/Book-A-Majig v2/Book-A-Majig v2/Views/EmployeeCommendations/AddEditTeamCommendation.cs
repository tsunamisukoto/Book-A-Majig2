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
    public partial class AddEditTeamCommendation : Form
    {
        public AddEditTeamCommendation()
        {
            InitializeComponent();
        }

        public Employee User
        {
            get;
            set;
        }

        List<Shift> shifts = new List<Shift>();
        private void AddEditTeamCommendation_Load(object sender, EventArgs e)
        {
            var unitofWork = new UnitOfWork();
            cbClassification.DisplayMember = "Name";
            cbClassification.DataSource = unitofWork.EmployeeCommendationClassificationRepository.Get(x => x.AvailableOnUser).ToList();
            

            if (WorkingCommendationId != null)
            {
                workingcommendation = unitofWork.TeamCommendationRepository.Get(x => x.Id == WorkingCommendationId, includeProperties: "EmployeeCommendationClassification").FirstOrDefault();
                cbClassification.SelectedValue = workingcommendation.EmployeeCommendationClassification;
                txtNotes.Text = workingcommendation.Reason;
                shifts.Clear();
                shifts.Add(workingcommendation.Shift);
                dataGridView1.DataSource = shifts.Select(x => new { Day = x.DayOfTheWeek, Employees = GetEmployeeCount(unitofWork, x) }).ToList();
                dataGridView1.ReadOnly = true;
            }
            else
            {
                RebindShifts();
            }

        }
        public int? WorkingCommendationId { get; set; }
        private TeamCommendation workingcommendation { get; set; }
        void RebindShifts()
        {
            var unitofWork = new UnitOfWork();

            RosterService rservice = new RosterService();
            shifts.AddRange(rservice.GetRosterForDate(DateTime.Today.AddDays(0), "Shifts").Shifts);
            shifts.AddRange(rservice.GetRosterForDate(DateTime.Today.AddDays(-7), "Shifts").Shifts);
            shifts.AddRange(rservice.GetRosterForDate(DateTime.Today.AddDays(-14), "Shifts").Shifts);
            dataGridView1.DataSource = shifts.Select(x => new { Day = x.DayOfTheWeek, Employees = GetEmployeeCount(unitofWork, x) }).ToList();
          

        }
        void RebindDetailedView()
        {

        }
        int GetEmployeeCount(UnitOfWork unitofwork, Shift shift)
        {

            return unitofwork.ShiftRepository.Get(x => x.Id == shift.Id, includeProperties: "EmployeeShifts").FirstOrDefault().EmployeeShifts.Count;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
