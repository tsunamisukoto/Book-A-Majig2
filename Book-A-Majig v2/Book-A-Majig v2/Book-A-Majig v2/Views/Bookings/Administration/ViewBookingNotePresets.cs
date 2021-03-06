﻿using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Common.RestaurantManagement;
using Book_A_Majig_v2.Views.Common.RoleManagement;
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
    public partial class ViewBookingNotePresets : Form
    {
        public ViewBookingNotePresets()
        {
            InitializeComponent();
        }

        private void ViewBookingNotePresets_Load(object sender, EventArgs e)
        {
            Rebind();
        }
        public Employee User { get; set; }

        List<PresetNote> accessLevels = new List<PresetNote>();
        void Rebind()
        {
            var unitOfWork = new UnitOfWork();
            accessLevels = unitOfWork.PresetNoteRepository.Get().ToList();
            dgvPresetNotes.DataSource = accessLevels.Select(x => new { Name = x.Name, Severity = x.Severity }).ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditBookingNotePreset aeal = new AddEditBookingNotePreset();
            aeal.ShowDialog();
            if (aeal.DialogResult == DialogResult.OK)
            {
                Rebind();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvPresetNotes.SelectedRows.Count > 0)
            {
                AddEditBookingNotePreset aeal = new AddEditBookingNotePreset();
                aeal.presetID = accessLevels[dgvPresetNotes.SelectedRows[0].Index].Id;
                aeal.ShowDialog();
                if (aeal.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvPresetNotes.SelectedRows.Count > 0)
            {
                var unitofwork = new UnitOfWork();
                unitofwork.PresetNoteRepository.Delete(accessLevels[dgvPresetNotes.SelectedRows[0].Index].Id);
                unitofwork.Save();
                Rebind();
            }
        }
    }
}
