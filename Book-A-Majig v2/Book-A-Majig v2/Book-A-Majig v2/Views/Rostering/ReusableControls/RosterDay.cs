using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Rostering.ReusableControls
{
    public partial class RosterDay : UserControl
    {
        public RosterDay()
        {
            InitializeComponent();
        }
        private int _day;
        public int DayOfWeek {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
                lblDayOfWeek.Text = Enum.GetName(typeof(DayOfWeek), _day);
               // Rebind();
            }
        } 
    }
}
