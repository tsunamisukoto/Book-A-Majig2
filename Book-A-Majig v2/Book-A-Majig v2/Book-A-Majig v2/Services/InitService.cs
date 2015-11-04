using Book_A_Majig_v2.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.Services
{
    class InitService
    {
        public static void Initialize()
        {
            var unitofwork = new UnitOfWork();

            if (unitofwork.EmpoyeeRepository.Get().Count() == 0)
            {
                unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 1", DisplayOrder = 1 });
                unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 2", DisplayOrder = 1 });
                unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 3", DisplayOrder = 1 });
                unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 4", DisplayOrder = 1 });
                unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 5", DisplayOrder = 1 });
                var added = unitofwork.AccessLevelRepository.Insert(new AccessLevel { Name = "Level 1", Level = 1 });
                var newRestaurant = new Restaurant() { Capacity = 100, Name = "Rebellion", Location = "Sydney", RosteringStartDay = (int)DayOfWeek.Monday, RosteringWeekDuration = 1, RosteringWeekOffset = 0 };
                var newemployee = new Employee() { Id = 111, FirstName = "Scott", LastName = "Becker", AccessLevel = added, Email = "test@test.com", PhoneNumber = "999999999" };
                var availabilities = new List<EmployeeAvailabilityDay>();
                availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Monday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 16, 30, 0),DateAdded= DateTime.Now });
                availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Tuesday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 18, 30, 0), DateAdded = DateTime.Now });
                availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Wednesday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 12, 30, 0), DateAdded = DateTime.Now });
                availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Thursday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 15, 30, 0), DateAdded = DateTime.Now });
                availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Friday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 13, 30, 0), DateAdded = DateTime.Now });
                availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Saturday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 16, 30, 0), DateAdded = DateTime.Now });
                availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Sunday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 14, 30, 0), DateAdded = DateTime.Now });
                newemployee.EmployeeAvailabilityDays = availabilities;
                newemployee.EmployeeNAs.Add(new EmployeeNA() { StartDate = DateTime.Now.AddDays(-7), EndDate = DateTime.Now.AddDays(-6), Notes = "Visiting Grandma", SubmittedBy = newemployee ,SubmittedDate=DateTime.Now});
                newemployee.EmployeeNAs.Add(new EmployeeNA() { StartDate = DateTime.Now.AddDays(6), EndDate = DateTime.Now.AddDays(7), Notes = "Visiting Grandma Again", SubmittedBy = newemployee, SubmittedDate = DateTime.Now });
                newemployee.EmployeeNAs.Add(new EmployeeNA() { StartDate = DateTime.Now.AddDays(9), EndDate = DateTime.Now.AddDays(10), Notes = "Visiting Grandma", SubmittedBy = newemployee, SubmittedDate = DateTime.Now });

                newemployee.EmployeeAvailabilityHoursRequests.Add(new EmployeeAvailabilityHoursRequest() { StartDate = new DateTime(2014, 1, 1), RequestedMinimumHours = 8, RequestedMaximumHours = 30 });
                unitofwork.AccessLevelRepository.Insert(new AccessLevel() { Name = "Level 2", Level = 2 });
                unitofwork.AccessLevelRepository.Insert(new AccessLevel() { Name = "Level 3", Level = 3 });
                unitofwork.AccessLevelRepository.Insert(new AccessLevel() { Name = "Level 4", Level = 4 });
                unitofwork.EmpoyeeRepository.Insert(newemployee);
                unitofwork.PresetNoteRepository.Insert(new PresetNote() { Name = "Gluten Free", Severity = 5 });
                unitofwork.PresetNoteRepository.Insert(new PresetNote() { Name = "Dairy Free", Severity = 5 });
                unitofwork.PresetNoteRepository.Insert(new PresetNote() { Name = "Window Seat", Severity = 2 });
                unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name = "Locked Out Date 1", Reason = "Cause", StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), DateCreated = DateTime.Now, Restaurant = newRestaurant });
                unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name = "Locked Out Date 2", Reason = "Cause", StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), DateCreated = DateTime.Now, Restaurant = newRestaurant });
                unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name = "Locked Out Date 3", Reason = "Cause", StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), DateCreated = DateTime.Now, Restaurant = newRestaurant });
                unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name = "Locked Out Date 4", Reason = "Cause", StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), DateCreated = DateTime.Now, Restaurant = newRestaurant });
                unitofwork.DateNoteRepository.Insert(new DateNote() { Note = "Note1", AppearOnAddingBooking = true, AppearOnRoster = true, StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), Restaurant = newRestaurant, DateCreated = DateTime.Now });
                unitofwork.DateNoteRepository.Insert(new DateNote() { Note = "Note2", AppearOnAddingBooking = false, AppearOnRoster = true, StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), DateCreated = DateTime.Now, Restaurant = newRestaurant });
                unitofwork.DateNoteRepository.Insert(new DateNote() { Note = "Note3", AppearOnAddingBooking = true, AppearOnRoster = false, StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), DateCreated = DateTime.Now, Restaurant = newRestaurant });

                unitofwork.Save();
            }
        }
    }
}
