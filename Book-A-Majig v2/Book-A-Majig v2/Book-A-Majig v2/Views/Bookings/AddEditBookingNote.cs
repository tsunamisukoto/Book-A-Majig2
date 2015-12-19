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

namespace Book_A_Majig_v2.Views.Bookings
{
    public partial class AddEditBookingNote : Form
    {
        public AddEditBookingNote()
        {
            InitializeComponent();
        }
        public int? noteID { get; set; }
        public BookingNote WorkingNote { get; set; }
        public int UserId { get; set; }
        List<PresetNote> presetNotes = new List<PresetNote>();
        private void AddEditBookingNote_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            ShowPresetPanel();
            if(noteID!=null)
            {
                WorkingNote = unitOfWork.BookingNotesRepository.GetByID(noteID.Value);
              
            }
            if(WorkingNote !=null)
            {
                tbNote.Text = WorkingNote.Note;
                nmudSeverity.Value = WorkingNote.Severity;
                radioButton1.Enabled = false;
                ShowCustomPanel();

            }
            presetNotes = unitOfWork.PresetNoteRepository.Get().ToList();
            dataGridView1.DataSource = presetNotes;
            stylesSheetManager1.ApplyStyles();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                ShowPresetPanel();

            }
            if(radioButton2.Checked)
            {
                ShowCustomPanel();
            }
        }
        void ShowPresetPanel()
        {
            radioButton1.Checked = true;
            dataGridView1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            nmudSeverity.Visible = false;
            tbNote.Visible = false;
            button3.Visible = true;
        }
        void ShowCustomPanel()
        {
            radioButton2.Checked = true;

            dataGridView1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            nmudSeverity.Visible = true;
            tbNote.Visible = true;
            button3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                if(WorkingNote == null)
                {
                    WorkingNote = new BookingNote();
                    WorkingNote.Note = tbNote.Text;
                    WorkingNote.EmployeeId = UserId;
                    WorkingNote.DateAdded = DateTime.Now;
                    WorkingNote.Severity = (int)nmudSeverity.Value;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    
                    WorkingNote.Note = tbNote.Text;
                    WorkingNote.Severity = (int)nmudSeverity.Value;
                    WorkingNote.EmployeeId = UserId;
                    var unitOfWork = new UnitOfWork();
                    if(noteID!=null)
                    unitOfWork.BookingNotesRepository.Update(WorkingNote);

                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                var note = presetNotes[dataGridView1.SelectedRows[0].Index];
                tbNote.Text = note.Name;
                nmudSeverity.Value = note.Severity;
                radioButton1.Enabled = false;
                ShowCustomPanel();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
