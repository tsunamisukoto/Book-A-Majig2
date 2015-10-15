using Book_A_Majig_v2.DatabaseEntities;
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
    public partial class ManagePermissions : Form
    {
        public Employee User { get; set; }

        public ManagePermissions()
        {
            InitializeComponent();
        }
    }
}
