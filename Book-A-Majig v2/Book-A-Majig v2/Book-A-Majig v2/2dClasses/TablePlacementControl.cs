using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Book_A_Majig_v2._2dClasses
{
    class TablePlacementControl
    {
        private _2DEngine gEngine;
        public void startGraphics(Graphics g)
        {
            gEngine = new _2DEngine(g);
            gEngine.init();
        }
        public void stopProgram()
        {
            gEngine.stop();
        }
    }
}
