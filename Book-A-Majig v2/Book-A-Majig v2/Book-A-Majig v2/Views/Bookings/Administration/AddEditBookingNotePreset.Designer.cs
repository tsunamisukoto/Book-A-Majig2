﻿namespace Book_A_Majig_v2.Views.Bookings.Administration
{
    partial class AddEditBookingNotePreset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudSeverity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stylesSheetManager1 = new Sb.Windows.Forms.StylesSheet.StylesSheetManager(this.components);
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSeverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.stylesSheetManager1.SetStyle(this.label1, "");
            this.label1.TabIndex = 2;
            this.label1.Text = "Severity";
            // 
            // nmudSeverity
            // 
            this.nmudSeverity.Location = new System.Drawing.Point(18, 85);
            this.nmudSeverity.Name = "nmudSeverity";
            this.nmudSeverity.Size = new System.Drawing.Size(120, 20);
            this.stylesSheetManager1.SetStyle(this.nmudSeverity, "");
            this.nmudSeverity.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(18, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.button1, "SaveButton");
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(100, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.button2, "CancelButton");
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(15, 45);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(390, 20);
            this.stylesSheetManager1.SetStyle(this.tbNote, "");
            this.tbNote.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.stylesSheetManager1.SetStyle(this.label3, "");
            this.label3.TabIndex = 10;
            this.label3.Text = "Preset Name";
            // 
            // AddEditBookingNotePreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 151);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nmudSeverity);
            this.Controls.Add(this.label1);
            this.Name = "AddEditBookingNotePreset";
            this.stylesSheetManager1.SetStyle(this, "");
            this.Text = "AddEditBookingNote";
            this.Load += new System.EventHandler(this.AddEditBookingNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmudSeverity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmudSeverity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Sb.Windows.Forms.StylesSheet.StylesSheetManager stylesSheetManager1;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label3;
    }
}