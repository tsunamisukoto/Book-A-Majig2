using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Rostering.ReusableControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Rostering
{
    public partial class ViewRosters : Form
    {
        public Employee User { get; set; }

        public ViewRosters()
        {
            InitializeComponent();
        }

        private void B_Click(object sender, EventArgs e)
        {
            int day = (int)(((Button)sender).Tag);
            AddEditShiftRoster aeda = new AddEditShiftRoster();
            aeda.User = User;
            var dateToWorkWith = dateTimePicker1.Value;
            RosterService rservice = new RosterService();
            WorkingRoster = rservice.GetRosterForDate(dateToWorkWith);
            aeda.DayOfWeek = day;
            aeda.RosterId = WorkingRoster.Id;
            aeda.ShowDialog();
            if (aeda.DialogResult == DialogResult.OK)
            {

                Rebind();
            }

        }
        private void BuildButton(int day, RosterDay b)
        {

            var dateToWorkWith = dateTimePicker1.Value;
            RosterService rservice = new RosterService();
            WorkingRoster = rservice.GetRosterForDate(dateToWorkWith);
            if (day > 6)
                day = day % 7;
            b.Label = Enum.GetName(typeof(DayOfWeek), day);
            b.DayOfWeek = day;
            b.BindRoster(WorkingRoster);
            
            b.btnModify.Tag = day;
         
        }

        private void ViewRosters_Load(object sender, EventArgs e)
        {
            rosterDay1.btnModify.Click += B_Click;
            rosterDay2.btnModify.Click += B_Click;
            rosterDay3.btnModify.Click += B_Click;
            rosterDay4.btnModify.Click += B_Click;
            rosterDay5.btnModify.Click += B_Click;
            rosterDay6.btnModify.Click += B_Click;
            rosterDay7.btnModify.Click += B_Click;
            Rebind();
        }
        void Rebind()
        {
            var newRestaurant = new Restaurant() { Capacity = 100, Name = "Rebellion", Location = "Sydney", RosteringStartDay = (int)DayOfWeek.Monday, RosteringWeekDuration = 1, RosteringWeekOffset = 0 };

            BuildButton(newRestaurant.RosteringStartDay + 0, rosterDay1);
            BuildButton(newRestaurant.RosteringStartDay + 1, rosterDay2);
            BuildButton(newRestaurant.RosteringStartDay + 2, rosterDay3);
            BuildButton(newRestaurant.RosteringStartDay + 3, rosterDay4);
            BuildButton(newRestaurant.RosteringStartDay + 4, rosterDay5);
            BuildButton(newRestaurant.RosteringStartDay + 5, rosterDay6);
            BuildButton(newRestaurant.RosteringStartDay + 6, rosterDay7);
        }
        Roster WorkingRoster;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dateToWorkWith = dateTimePicker1.Value;
            RosterService rservice = new RosterService();
            WorkingRoster = rservice.GetRosterForDate(dateToWorkWith);
            Rebind();
        }
    }
}
