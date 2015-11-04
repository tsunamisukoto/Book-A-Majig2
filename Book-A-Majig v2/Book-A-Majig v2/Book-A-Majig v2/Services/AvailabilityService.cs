using Book_A_Majig_v2.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.Services
{
    class AvailabilityService
    {
        public EmployeeAvailabilityDay AvailabilityForDay(int userID, int DayOfTheWeek, DateTime? d = null)
        {
            if (d == null)
                d = DateTime.Now;

            var unitOfWork = new UnitOfWork();
            var alldays = unitOfWork.EmployeeAvailabilityRepository.Get(x => x.Employee.Id == userID && x.StartDate < d && (x.EndDate == null || x.EndDate > d), includeProperties: "Employee").ToList();


            var item = alldays.Where(x => x.DayOfWeek == DayOfTheWeek).OrderByDescending(x => x.DateAdded).FirstOrDefault();
            return item;
        }
    }
}
