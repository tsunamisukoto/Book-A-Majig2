using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.Services
{
    public class UnitOfWork : IDisposable
    {
        private static DatabaseEntities.DatabaseEntities hiddenContext;
        private static DatabaseEntities.DatabaseEntities context
        {
            get
            {
                if(hiddenContext==null)
                {
                    hiddenContext = new DatabaseEntities.DatabaseEntities(); 
                }
                return hiddenContext;
            }
            set
            {
                hiddenContext = value;
            }

        }
          
        private GenericRepository<DatabaseEntities.Booking> bookingRepository;
        private GenericRepository<DatabaseEntities.BookingNote> bookingnotesRepository;
        private GenericRepository<DatabaseEntities.BookingClasification> bookingclassificationRepository;
        private GenericRepository<DatabaseEntities.Employee> employeeRepository;
        private GenericRepository<DatabaseEntities.AccessLevel> accesslevelRepository;
        private GenericRepository<DatabaseEntities.Restaurant> restaurantRepository;
        private GenericRepository<DatabaseEntities.Permissions> permissionRepository;
        private GenericRepository<DatabaseEntities.PresetNote> presetnoteRepository;
        private GenericRepository<DatabaseEntities.DateNote> datenoteRepository;
        private GenericRepository<DatabaseEntities.LockOutDate> lockeddateRepository;
        private GenericRepository<DatabaseEntities.EmployeeNA> employeenaRepository;
        private GenericRepository<DatabaseEntities.EmployeeAvailabilityDay>employeeavailabilityRepository;
        private GenericRepository<DatabaseEntities.Roster>rosterRepository;
        private GenericRepository<DatabaseEntities.Shift>shiftRepository;
        private GenericRepository<DatabaseEntities.ShiftCategory>shiftcategoryRepository;
        private GenericRepository<DatabaseEntities.SkillCategory>skillcategoryRepository;
        private GenericRepository<DatabaseEntities.EmployeeCommendation>employeecommendationRepository;
        private GenericRepository<DatabaseEntities.TeamCommendation>teamcommendationRepository;
        private GenericRepository<DatabaseEntities.EmployeeCommendationClassification>employeecommendationclassificationRepository;
        public GenericRepository<DatabaseEntities.EmployeeCommendationClassification> EmployeeCommendationClassificationRepository
        {
            get
            {

                if (this.employeecommendationclassificationRepository == null)
                {
                    this.employeecommendationclassificationRepository = new GenericRepository<DatabaseEntities.EmployeeCommendationClassification>(context);
                }
                return employeecommendationclassificationRepository;
            }
        }
        public GenericRepository<DatabaseEntities.TeamCommendation> TeamCommendationRepository
        {
            get
            {

                if (this.teamcommendationRepository == null)
                {
                    this.teamcommendationRepository = new GenericRepository<DatabaseEntities.TeamCommendation>(context);
                }
                return teamcommendationRepository;
            }
        }
        public GenericRepository<DatabaseEntities.EmployeeCommendation> EmployeeCommendationRepository
        {
            get
            {

                if (this.employeecommendationRepository == null)
                {
                    this.employeecommendationRepository = new GenericRepository<DatabaseEntities.EmployeeCommendation>(context);
                }
                return employeecommendationRepository;
            }
        }
        public GenericRepository<DatabaseEntities.SkillCategory> SkillCategoryRepository
        {
            get
            {

                if (this.shiftcategoryRepository == null)
                {
                    this.skillcategoryRepository = new GenericRepository<DatabaseEntities.SkillCategory>(context);
                }
                return skillcategoryRepository;
            }
        }
        public GenericRepository<DatabaseEntities.ShiftCategory> ShiftCategoryRepository
        {
            get
            {

                if (this.shiftcategoryRepository == null)
                {
                    this.shiftcategoryRepository = new GenericRepository<DatabaseEntities.ShiftCategory>(context);
                }
                return shiftcategoryRepository;
            }
        }

        public GenericRepository<DatabaseEntities.Shift> ShiftRepository
        {
            get
            {

                if (this.shiftRepository == null)
                {
                    this.shiftRepository = new GenericRepository<DatabaseEntities.Shift>(context);
                }
                return shiftRepository;
            }
        }

        public GenericRepository<DatabaseEntities.Roster> RosterRepository
        {
            get
            {

                if (this.rosterRepository == null)
                {
                    this.rosterRepository = new GenericRepository<DatabaseEntities.Roster>(context);
                }
                return rosterRepository;
            }
        }
        public GenericRepository<DatabaseEntities.EmployeeAvailabilityDay> EmployeeAvailabilityRepository
        {
            get
            {

                if (this.employeeavailabilityRepository == null)
                {
                    this.employeeavailabilityRepository = new GenericRepository<DatabaseEntities.EmployeeAvailabilityDay>(context);
                }
                return employeeavailabilityRepository;
            }
        }
        public GenericRepository<DatabaseEntities.EmployeeNA> EmployeeNARepository
        {
            get
            {

                if (this.employeenaRepository == null)
                {
                    this.employeenaRepository = new GenericRepository<DatabaseEntities.EmployeeNA>(context);
                }
                return employeenaRepository;
            }
        }
        public GenericRepository<DatabaseEntities.LockOutDate> LockedOutDateRepository
        {
            get
            {

                if (this.lockeddateRepository == null)
                {
                    this.lockeddateRepository = new GenericRepository<DatabaseEntities.LockOutDate>(context);
                }
                return lockeddateRepository;
            }
        }
        public GenericRepository<DatabaseEntities.DateNote> DateNoteRepository
        {
            get
            {

                if (this.datenoteRepository == null)
                {
                    this.datenoteRepository = new GenericRepository<DatabaseEntities.DateNote>(context);
                }
                return datenoteRepository;
            }
        }
        public GenericRepository<DatabaseEntities.Booking> BookingRepository
        {
            get
            {

                if (this.bookingRepository == null)
                {
                    this.bookingRepository = new GenericRepository<DatabaseEntities.Booking>(context);
                }
                return bookingRepository;
            }
        }
        public GenericRepository<DatabaseEntities.BookingNote> BookingNotesRepository
        {
            get
            {

                if (this.bookingnotesRepository == null)
                {
                    this.bookingnotesRepository = new GenericRepository<DatabaseEntities.BookingNote>(context);
                }
                return bookingnotesRepository;
            }
        }

        public GenericRepository<DatabaseEntities.BookingClasification> BookingClassificationRepository
        {
            get
            {

                if (this.bookingclassificationRepository == null)
                {
                    this.bookingclassificationRepository = new GenericRepository<DatabaseEntities.BookingClasification>(context);
                }
                return bookingclassificationRepository;
            }
        }

        public GenericRepository<DatabaseEntities.AccessLevel> AccessLevelRepository
        {
            get
            {

                if (this.accesslevelRepository == null)
                {
                    this.accesslevelRepository = new GenericRepository<DatabaseEntities.AccessLevel>(context);
                }
                return accesslevelRepository;
            }
        }

        public GenericRepository<DatabaseEntities.Employee> EmployeeRepository
        {
            get
            {

                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<DatabaseEntities.Employee>(context);
                }
                return employeeRepository;
            }
        }
        public GenericRepository<DatabaseEntities.Restaurant> RestaurantRepository
        {
            get
            {

                if (this.restaurantRepository == null)
                {
                    this.restaurantRepository = new GenericRepository<DatabaseEntities.Restaurant>(context);
                }
                return restaurantRepository;
            }
        }

        public GenericRepository<DatabaseEntities.Permissions> PermissionRepository
        {
            get
            {

                if (this.permissionRepository == null)
                {
                    this.permissionRepository = new GenericRepository<DatabaseEntities.Permissions>(context);
                }
                return permissionRepository;
            }
        }

        public GenericRepository<DatabaseEntities.PresetNote> PresetNoteRepository
        {
            get
            {

                if (this.presetnoteRepository == null)
                {
                    this.presetnoteRepository = new GenericRepository<DatabaseEntities.PresetNote>(context);
                }
                return presetnoteRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
