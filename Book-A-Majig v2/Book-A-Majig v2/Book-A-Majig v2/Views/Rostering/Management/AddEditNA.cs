using Book_A_Majig_v2.DatabaseEntities;
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
    public partial class AddEditNA : Form
    {
        public AddEditNA()
        {
            InitializeComponent();
        }
        public Employee User { get; set; }
        public int? NAID { get; set; }
        private void AddEditNA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
