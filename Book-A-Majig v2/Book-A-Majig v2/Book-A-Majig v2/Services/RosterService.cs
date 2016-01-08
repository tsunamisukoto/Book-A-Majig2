using Book_A_Majig_v2.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.Services
{
    class RosterService
    {
        public Roster GetRosterForDate(DateTime d,string include="")
        {
            CultureInfo cul = CultureInfo.CurrentCulture;
            int weekOfYear = cul.Calendar.GetWeekOfYear(d, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            int year = d.Year;
            if (weekOfYear > 52)
            {
                weekOfYear = weekOfYear % 52;
                year += 1;
            }
            var unitofWork = new UnitOfWork();
            var roster = unitofWork.RosterRepository.Get(x => x.WeekOfYear == weekOfYear && x.Year == year,includeProperties: include);
            if (roster.FirstOrDefault() != null)
            {
                return roster.FirstOrDefault();
            }
            else
            {
                Roster r = new Roster() { WeekOfYear = weekOfYear, Year = year, Notes = "NOTES", Restaurant = new UnitOfWork().RestaurantRepository.Get().FirstOrDefault() };
                var q = unitofWork.RosterRepository.Insert(r);
                unitofWork.Save();
                return unitofWork.RosterRepository.Get(x => x.WeekOfYear == weekOfYear && x.Year == year, includeProperties:include).FirstOrDefault();
            }
        }
    }
}
