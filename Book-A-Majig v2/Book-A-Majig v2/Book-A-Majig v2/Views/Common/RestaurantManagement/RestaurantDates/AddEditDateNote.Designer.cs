namespace Book_A_Majig_v2.Views.Common.RestaurantManagement.RestaurantDates
{
    partial class AddEditDateNote
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cbAppearOnRoster = new System.Windows.Forms.CheckBox();
            this.cbAppearOnBooking = new System.Windows.Forms.CheckBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(6, 35);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // cbAppearOnRoster
            // 
            this.cbAppearOnRoster.AutoSize = true;
            this.cbAppearOnRoster.Checked = true;
            this.cbAppearOnRoster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAppearOnRoster.Location = new System.Drawing.Point(13, 85);
            this.cbAppearOnRoster.Name = "cbAppearOnRoster";
            this.cbAppearOnRoster.Size = new System.Drawing.Size(125, 17);
            this.cbAppearOnRoster.TabIndex = 1;
            this.cbAppearOnRoster.Text = "Appear On Rostering";
            this.cbAppearOnRoster.UseVisualStyleBackColor = true;
            // 
            // cbAppearOnBooking
            // 
            this.cbAppearOnBooking.AutoSize = true;
            this.cbAppearOnBooking.Checked = true;
            this.cbAppearOnBooking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAppearOnBooking.Location = new System.Drawing.Point(180, 85);
            this.cbAppearOnBooking.Name = "cbAppearOnBooking";
            this.cbAppearOnBooking.Size = new System.Drawing.Size(124, 17);
            this.cbAppearOnBooking.TabIndex = 2;
            this.cbAppearOnBooking.Text = "Appear On Bookings";
            this.cbAppearOnBooking.UseVisualStyleBackColor = true;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(12, 108);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(440, 142);
            this.tbNote.TabIndex = 3;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(213, 35);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Dates";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddEditDateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.cbAppearOnBooking);
            this.Controls.Add(this.cbAppearOnRoster);
            this.Name = "AddEditDateNote";
            this.Text = "AddEditDateNote";
            this.Load += new System.EventHandler(this.AddEditDateNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox cbAppearOnRoster;
        private System.Windows.Forms.CheckBox cbAppearOnBooking;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}