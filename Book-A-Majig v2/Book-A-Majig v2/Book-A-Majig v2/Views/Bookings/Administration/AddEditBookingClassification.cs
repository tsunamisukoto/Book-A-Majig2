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

namespace Book_A_Majig_v2.Views.Bookings.Administration
{
    public partial class AddEditBookingClassification : Form
    {
        public AddEditBookingClassification()
        {
            InitializeComponent();
        }
        public int? presetID { get; set; }
        public BookingClasification WorkingNote { get; set; }
        public int UserId { get; set; }
      
        private void AddEditBookingNote_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
           
            if(presetID!=null)
            {
                WorkingNote = unitOfWork.BookingClassificationRepository.GetByID(presetID.Value);
           
            }
            if(WorkingNote !=null)
            {
                tbNote.Text = WorkingNote.ClassificationName;
                
            }
            stylesSheetManager1.ApplyStyles();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();

            if (WorkingNote == null)
                {
                    WorkingNote = new BookingClasification();
                    WorkingNote.ClassificationName = tbNote.Text;
                unitOfWork.BookingClassificationRepository.Insert(WorkingNote);

            }
            else
                {
                    
                    WorkingNote.ClassificationName = tbNote.Text;
                    if(presetID!=null)
                    unitOfWork.BookingClassificationRepository.Update(WorkingNote);


            }
            unitOfWork.Save();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
