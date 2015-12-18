namespace Book_A_Majig_v2.Views.Bookings.Administration
{
    partial class ViewBookingNotePresets
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
            this.dgvPresetNotes = new System.Windows.Forms.DataGridView();
            this.tbMoreDetails = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresetNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPresetNotes
            // 
            this.dgvPresetNotes.AllowUserToAddRows = false;
            this.dgvPresetNotes.AllowUserToDeleteRows = false;
            this.dgvPresetNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresetNotes.Location = new System.Drawing.Point(13, 13);
            this.dgvPresetNotes.Name = "dgvPresetNotes";
            this.dgvPresetNotes.ReadOnly = true;
            this.dgvPresetNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresetNotes.Size = new System.Drawing.Size(260, 350);
            this.dgvPresetNotes.TabIndex = 0;
            // 
            // tbMoreDetails
            // 
            this.tbMoreDetails.Location = new System.Drawing.Point(280, 13);
            this.tbMoreDetails.Multiline = true;
            this.tbMoreDetails.Name = "tbMoreDetails";
            this.tbMoreDetails.ReadOnly = true;
            this.tbMoreDetails.Size = new System.Drawing.Size(441, 350);
            this.tbMoreDetails.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Preset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit Preset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Preset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewBookingNotePresets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 412);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMoreDetails);
            this.Controls.Add(this.dgvPresetNotes);
            this.Name = "ViewBookingNotePresets";
            this.Text = "ViewAccessLevels";
            this.Load += new System.EventHandler(this.ViewBookingNotePresets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresetNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPresetNotes;
        private System.Windows.Forms.TextBox tbMoreDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}