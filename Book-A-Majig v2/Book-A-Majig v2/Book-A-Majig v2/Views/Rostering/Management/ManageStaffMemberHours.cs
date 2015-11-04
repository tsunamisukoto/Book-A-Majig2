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

namespace Book_A_Majig_v2.Views.Rostering.Management
{
    public partial class ManageStaffMemberHours : Form
    {
        public ManageStaffMemberHours()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        public int EditedUserID { get; set; }
        private void ManageStaffMemberHours_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.Date;

            button1.Click += B_Click;
            button2.Click += B_Click;
            button3.Click += B_Click;
            button4.Click += B_Click;
            button5.Click += B_Click;
            button6.Click += B_Click;
            button7.Click += B_Click;
            Rebind();
        }
        private void Rebind()
        {
            var unitofwork = new UnitOfWork();
             BuildButton( 1, button1);
            BuildButton( 2, button2);
            BuildButton( 3, button3);
            BuildButton( 4, button4);
            BuildButton( 5, button5);
            BuildButton( 6, button6);
            BuildButton( 0, button7);
            lblEmployeeName.Text = unitofwork.EmpoyeeRepository.GetByID(EditedUserID).FullName;
        }
        private void BuildButton( int day, Button b)
        {
            AvailabilityService aservice = new AvailabilityService();
        
            var s = Enum.GetName(typeof(DayOfWeek), day);
            var item = aservice.AvailabilityForDay(EditedUserID, day, dateTimePicker1.Value);
            if(item!=null)
            {
                s += item.StartTime.ToShortTimeString() + (item.FinishTime.HasValue ? " - " + item.FinishTime.Value.ToShortTimeString() : "") + "\n";
              
         
            }
            else
            {
                s += "No Availability Set";
            }
            b.Tag = day;
            b.Text = s;
        } 

        private void B_Click(object sender, EventArgs e)
        {
            int day = (int)(((Button)sender).Tag);
            AddEditDayAvailability aeda = new AddEditDayAvailability();
            aeda.User = User;
            aeda.DayOfWeek = day;
            aeda.EditedUserID = EditedUserID;
            aeda.ShowDialog();
            if(aeda.DialogResult==DialogResult.OK)
            {
             
                Rebind();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Rebind();
        }
    }
}
