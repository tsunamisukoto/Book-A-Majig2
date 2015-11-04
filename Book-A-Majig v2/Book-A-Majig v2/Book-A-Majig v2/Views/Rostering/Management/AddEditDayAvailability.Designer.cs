namespace Book_A_Majig_v2.Views.Rostering.Management
{
    partial class AddEditDayAvailability
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.rbFromToday = new System.Windows.Forms.RadioButton();
            this.rbFromFutureDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEndDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbEndTime = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(13, 30);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(45, 13);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Monday";
            // 
            // rbFromToday
            // 
            this.rbFromToday.AutoSize = true;
            this.rbFromToday.Checked = true;
            this.rbFromToday.Location = new System.Drawing.Point(4, 41);
            this.rbFromToday.Name = "rbFromToday";
            this.rbFromToday.Size = new System.Drawing.Size(81, 17);
            this.rbFromToday.TabIndex = 3;
            this.rbFromToday.TabStop = true;
            this.rbFromToday.Text = "From Today";
            this.rbFromToday.UseVisualStyleBackColor = true;
            this.rbFromToday.CheckedChanged += new System.EventHandler(this.rbFromToday_CheckedChanged);
            // 
            // rbFromFutureDate
            // 
            this.rbFromFutureDate.AutoSize = true;
            this.rbFromFutureDate.Location = new System.Drawing.Point(93, 41);
            this.rbFromFutureDate.Name = "rbFromFutureDate";
            this.rbFromFutureDate.Size = new System.Drawing.Size(107, 17);
            this.rbFromFutureDate.TabIndex = 4;
            this.rbFromFutureDate.TabStop = true;
            this.rbFromFutureDate.Text = "From Future Date";
            this.rbFromFutureDate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEndDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.rbFromFutureDate);
            this.groupBox1.Controls.Add(this.rbFromToday);
            this.groupBox1.Location = new System.Drawing.Point(10, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Dates";
            // 
            // cbEndDate
            // 
            this.cbEndDate.AutoSize = true;
            this.cbEndDate.Location = new System.Drawing.Point(6, 72);
            this.cbEndDate.Name = "cbEndDate";
            this.cbEndDate.Size = new System.Drawing.Size(90, 17);
            this.cbEndDate.TabIndex = 8;
            this.cbEndDate.Text = "Set End Date";
            this.cbEndDate.UseVisualStyleBackColor = true;
            this.cbEndDate.CheckedChanged += new System.EventHandler(this.cbEndDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(207, 67);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(207, 41);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 5;
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(20, 103);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(429, 60);
            this.tbNotes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Notes:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(14, 62);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(93, 20);
            this.dtpStartTime.TabIndex = 8;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(250, 62);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(91, 20);
            this.dtpEndTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Time";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbEndTime
            // 
            this.cbEndTime.AutoSize = true;
            this.cbEndTime.Checked = true;
            this.cbEndTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEndTime.Location = new System.Drawing.Point(150, 43);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(94, 17);
            this.cbEndTime.TabIndex = 13;
            this.cbEndTime.Text = "To end of shift";
            this.cbEndTime.UseVisualStyleBackColor = true;
            this.cbEndTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AddEditDayAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 327);
            this.Controls.Add(this.cbEndTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEditDayAvailability";
            this.Text = "EditDayAvailability";
            this.Load += new System.EventHandler(this.AddEditDayAvailability_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.RadioButton rbFromToday;
        private System.Windows.Forms.RadioButton rbFromFutureDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbEndTime;
    }
}