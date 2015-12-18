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
    public partial class AddEditBookingNotePreset : Form
    {
        public AddEditBookingNotePreset()
        {
            InitializeComponent();
        }
        public int? presetID { get; set; }
        public PresetNote WorkingNote { get; set; }
        public int UserId { get; set; }
      
        private void AddEditBookingNote_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
           
            if(presetID!=null)
            {
                WorkingNote = unitOfWork.PresetNoteRepository.GetByID(presetID.Value);
              
            }
            if(WorkingNote !=null)
            {
                tbNote.Text = WorkingNote.Name;
                nmudSeverity.Value = WorkingNote.Severity;
                
            }
            stylesSheetManager1.ApplyStyles();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            var unitOfWork = new UnitOfWork();
            if (WorkingNote == null)
            {
                WorkingNote = new PresetNote();
                    WorkingNote.Name = tbNote.Text;
                    WorkingNote.Severity = (int)nmudSeverity.Value;
                    unitOfWork.PresetNoteRepository.Insert(WorkingNote);

            }
            else
                {
                    
                    WorkingNote.Name = tbNote.Text;
                    WorkingNote.Severity = (int)nmudSeverity.Value;
                    if(presetID!=null)
                    unitOfWork.PresetNoteRepository.Update(WorkingNote);


            }
            unitOfWork.Save();
            DialogResult = DialogResult.OK;
        }
        
    }
}
