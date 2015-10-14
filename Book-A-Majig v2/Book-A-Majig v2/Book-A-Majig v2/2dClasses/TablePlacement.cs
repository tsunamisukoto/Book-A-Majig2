using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2._2dClasses
{
    public partial class TablePlacement : Form
    {
        public TablePlacement()
        {
            InitializeComponent();
        }
        TablePlacementControl control = new TablePlacementControl();
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            control.startGraphics(g);
        }

        private void TablePlacement_FormClosing(object sender, FormClosingEventArgs e)
        {
            control.stopProgram();
        }
    }
}
