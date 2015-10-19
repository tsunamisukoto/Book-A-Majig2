using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Services
{
    public static class UIExtensionMethods
    {


        const string NewLine = "\r\n";

        public static void AppendLine(this RichTextBox ed)
        {
            ed.AppendText(NewLine);
        }

        public static void AppendLine(this RichTextBox ed, string s)
        {
            int ss = ed.SelectionStart;
            ed.AppendText(s);
            int sl = ed.SelectionStart - ss + 1;

            Font bold = new Font(ed.Font, FontStyle.Regular);
            ed.Select(ss, sl);
            ed.SelectionFont = bold;
            ed.AppendText(NewLine);
        }

        public static void AppendBoldLine(this RichTextBox ed, string s)
        {
            int ss = ed.SelectionStart;
            ed.AppendText(s);
            int sl = ed.SelectionStart - ss + 1;

            Font bold = new Font(ed.Font, FontStyle.Bold);
            ed.Select(ss, sl);
            ed.SelectionFont = bold;
            ed.AppendText(NewLine);
        }
        public static void AppendBoldColoredLine(this RichTextBox ed, string s,Color passedInColor)
        {
            int ss = ed.SelectionStart;
            ed.AppendText(s);
            int sl = ed.SelectionStart - ss + 1;

            Font bold = new Font(ed.Font, FontStyle.Bold);
            
            ed.Select(ss, sl);
            ed.SelectionFont = bold;
            ed.SelectionColor = passedInColor;
            ed.AppendText(NewLine);
        }

    }
}
