using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Services
{
    class DateService
    {
        public void DateNotesForDate(RichTextBox rtb, DateTime date, bool includeRoster, bool includeBookingNotes)
        {
            rtb.Text = "";
            rtb.AppendBoldLine("Todays Notes:");
            var unitOfWork = new UnitOfWork();
            var today = date;
            var notes = unitOfWork.DateNoteRepository.Get(x => x.InactiveDate == null && today < x.EndDate && today > x.StartDate);
            if (!(includeRoster && includeBookingNotes))
            {
                if (includeBookingNotes)
                    notes = notes.Where(x => x.AppearOnAddingBooking);
                if (includeRoster)
                    notes = notes.Where(x => x.AppearOnRoster);
            }
            notes = notes.OrderBy(x => x.DateCreated);
            int i = 1;
            foreach (var note in notes)
            {
                rtb.AppendLine(i + ". " + note.Note);
            }



        }
        public void BookingLockoutsForDate(RichTextBox rtb, DateTime date)
        {
            rtb.Text = "";
            var unitOfWork = new UnitOfWork();
            var today = date.Date;
            var notes = unitOfWork.LockedOutDateRepository.Get(x => today < x.EndDate && today > x.StartDate,includeProperties:"LockOutTimes");

            notes = notes.OrderBy(x => x.DateCreated);
            if (notes.Count() > 0)
            {

                rtb.AppendBoldColoredLine("Locked:", System.Drawing.Color.Red);
                int i = 1;
                foreach (var note in notes)
                {
                    rtb.AppendBoldColoredLine(i + ". " + note.Name, System.Drawing.Color.Red);
                    string reason = note.Reason;

                    rtb.AppendLine(reason);
                    if (note.LockOutTimes.Count>0)
                    {
                        foreach(var v in note.LockOutTimes)
                        {
                            rtb.AppendText(v.StartTime.ToShortTimeString() + " - "+ v.EndTime.ToShortTimeString()+", " );

                        }
                    }
                }


            }

        }
    }

}
