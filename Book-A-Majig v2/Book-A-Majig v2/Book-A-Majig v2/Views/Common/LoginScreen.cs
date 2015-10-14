using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
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
          
                    if(unitofwork.EmpoyeeRepository.Get().Count()==0)
                    {
                        unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 1", DisplayOrder = 1 });
                        unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 2", DisplayOrder = 1 });
                        unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 3", DisplayOrder = 1 });
                        unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 4", DisplayOrder = 1 });
                        unitofwork.BookingClassificationRepository.Insert(new BookingClasification() { ClassificationName = "Class 5", DisplayOrder = 1 });
                        var added = unitofwork.AccessLevelRepository.Insert(new AccessLevel {  Name = "Level 1" });
                        unitofwork.EmpoyeeRepository.Insert(new Employee() { Id = 111, FirstName = "Scott", LastName = "Becker", AccessLevel = added });
                        unitofwork.Save();
                    }

                    var user = unitofwork.EmpoyeeRepository.Get(x => x.Id == userID).FirstOrDefault();
                    var ss = unitofwork.EmpoyeeRepository.Get();
                    if (user == null)
                    {
                        throw new NullReferenceException();
                    }
                    ViewBookings v = new ViewBookings();
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
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
                while(ex3.InnerException!= null)
                {
                    ex3 = ex3.InnerException;
                    MessageBox.Show(ex3.Message);
                }
            }
        }
    }
}
