using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
namespace Book_A_Majig_v2._2dClasses
{
    class _2DEngine
    {
        private Graphics drawHandle;
        private Thread renderThread;
        public _2DEngine(Graphics g)
        {
            drawHandle = g;

        }
        public void init()
        {
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }
        public void stop()
        {
            renderThread.Abort();
        }
        private void render()
        {
            while(true)
            {
                drawHandle.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, 500, 400);
            }
        }

    }
}
