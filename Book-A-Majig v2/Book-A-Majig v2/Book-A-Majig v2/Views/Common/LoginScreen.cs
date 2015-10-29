using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Common;
using InteractivePreGeneratedViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            using (var ctx = new DatabaseEntities.DatabaseEntities())
            {
                InteractiveViews.SetViewCacheFactory(ctx, new FileViewCacheFactory(Environment.CurrentDirectory + @"\EFCache\EFCache.xml"));
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            try
            {
                int userID = int.Parse(tbUserId.Text);
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
                    var newemployee = new Employee() { Id = 111, FirstName = "Scott", LastName = "Becker", AccessLevel = added, Email="test@test.com", PhoneNumber= "999999999" };
                    var availabilities = new List<EmployeeAvailabilityDay>();
                    availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Monday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 16, 30, 0) });
                    availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Tuesday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 18, 30, 0) });
                    availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Wednesday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 12, 30, 0) });
                    availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Thursday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 15, 30, 0) });
                    availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Friday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 13, 30, 0) });
                    availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Saturday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 16, 30, 0) });
                    availabilities.Add(new EmployeeAvailabilityDay() { DayOfWeek = (int)DayOfWeek.Sunday, StartDate = new DateTime(2014, 1, 1), Notes = "Initial Availability", StartTime = new DateTime(2014, 10, 10, 14, 30, 0) });
                    newemployee.EmployeeAvailabilityDays = availabilities;
                    newemployee.EmployeeAvailabilityHoursRequests.Add(new EmployeeAvailabilityHoursRequest() { StartDate = new DateTime(2014, 1, 1), RequestedMinimumHours = 8, RequestedMaximumHours = 30 });
                    unitofwork.AccessLevelRepository.Insert(new AccessLevel() {Name="Level 2", Level=2 });
                    unitofwork.AccessLevelRepository.Insert(new AccessLevel() {Name="Level 3", Level=3 });
                    unitofwork.AccessLevelRepository.Insert(new AccessLevel() {Name= "Level 4", Level=4 });
                    unitofwork.EmpoyeeRepository.Insert(newemployee);
                    unitofwork.PresetNoteRepository.Insert(new PresetNote() { Name = "Gluten Free", Severity = 5 });
                    unitofwork.PresetNoteRepository.Insert(new PresetNote() { Name = "Dairy Free", Severity = 5 });
                    unitofwork.PresetNoteRepository.Insert(new PresetNote() { Name = "Window Seat", Severity = 2 });
                    unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name="Locked Out Date 1",  Reason="Cause", StartDate= DateTime.Now, EndDate= DateTime.Now.AddYears(1), Restaurant=newRestaurant});
                    unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name= "Locked Out Date 2",  Reason="Cause", StartDate= DateTime.Now, EndDate= DateTime.Now.AddYears(1), Restaurant=newRestaurant});
                    unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name= "Locked Out Date 3",  Reason="Cause", StartDate= DateTime.Now, EndDate= DateTime.Now.AddYears(1), Restaurant=newRestaurant});
                    unitofwork.LockedOutDateRepository.Insert(new LockOutDate() { Name= "Locked Out Date 4",  Reason="Cause", StartDate= DateTime.Now, EndDate= DateTime.Now.AddYears(1), Restaurant=newRestaurant});
                    unitofwork.DateNoteRepository.Insert(new DateNote() {  Note="Note1", AppearOnAddingBooking=true, AppearOnRoster=true, StartDate= DateTime.Now, EndDate=DateTime.Now.AddYears(1), Restaurant=newRestaurant});
                    unitofwork.DateNoteRepository.Insert(new DateNote() {  Note="Note2", AppearOnAddingBooking=false, AppearOnRoster=true, StartDate= DateTime.Now, EndDate=DateTime.Now.AddYears(1), Restaurant=newRestaurant});
                    unitofwork.DateNoteRepository.Insert(new DateNote() {  Note="Note3", AppearOnAddingBooking=true, AppearOnRoster=false, StartDate= DateTime.Now, EndDate=DateTime.Now.AddYears(1), Restaurant=newRestaurant});
                
                    unitofwork.Save();
                }
                var user = unitofwork.EmpoyeeRepository.Get(x => x.Id == userID).FirstOrDefault();
                var ss = unitofwork.EmpoyeeRepository.Get();
                if (user == null)
                {
                    throw new NullReferenceException();
                }
                NavigationMenu v = new NavigationMenu();
                v.User = user;
                v.ShowDialog();








            }
            catch (FormatException ex)
            {
                MessageBox.Show("Incorrect Format, Please input an integer number");
            }
            catch (NullReferenceException ex2)
            {
                MessageBox.Show("User Not Found");

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex4)
            {
                MessageBox.Show(ex4.Message + " " + string.Join(", ", ex4.EntityValidationErrors.SelectMany(x => x.ValidationErrors.SelectMany(y => y.ErrorMessage))));
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
                while (ex3.InnerException != null)
                {
                    ex3 = ex3.InnerException;
                    MessageBox.Show(ex3.Message);
                }
            }
        }
    }
}
