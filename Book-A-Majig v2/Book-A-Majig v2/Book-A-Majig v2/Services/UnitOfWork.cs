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

        public GenericRepository<DatabaseEntities.Employee> EmpoyeeRepository
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
