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
                InitService.Initialize();
                var unitofwork = new UnitOfWork();

                int userID = int.Parse(tbUserId.Text);
                var user = unitofwork.EmpoyeeRepository.Get(x => x.Id == userID).FirstOrDefault();
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
