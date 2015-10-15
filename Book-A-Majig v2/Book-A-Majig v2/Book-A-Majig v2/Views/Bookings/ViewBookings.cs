using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
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
    public partial class ViewBookings : Form
    {
        public Employee User { get; set; }
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            if(User!=null)
            {
                Rebind();
            }
         
               
        }
        public void Rebind()
        {
            var unitOfWork = new UnitOfWork();
            
                dataGridView1.DataSource= unitOfWork.BookingRepository.Get(x =>
                x.BookingDate.Year == dateTimePicker1.Value.Year &&
                x.BookingDate.Month == dateTimePicker1.Value.Month &&
                x.BookingDate.Day == dateTimePicker1.Value.Day,y=> y.OrderBy(q=> q.BookingDate), "Employee,BookingClasification").Select(x =>
                new {
                    Name = x.Name,
                    TakenBy = x.Employee.FirstName,
                    ContactNumber = x.ContactNumber,
                    Classification =x.BookingClasification!=null? x.BookingClasification.ClassificationName:"",
                    Time = x.BookingDate
                }).ToList();


            dataGridView1.DataBindings.Clear();

            
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            AddEditBooking c = new AddEditBooking();
            c.user = User;
            c.ShowDialog();
            if(c.DialogResult==DialogResult.OK)
            {
                Rebind();
            }
        }

    
    }
}
