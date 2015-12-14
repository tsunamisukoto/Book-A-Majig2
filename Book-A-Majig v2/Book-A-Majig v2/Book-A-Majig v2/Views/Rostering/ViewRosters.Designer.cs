namespace Book_A_Majig_v2.Views.Rostering
{
    partial class ViewRosters
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblWeekOfYear = new System.Windows.Forms.Label();
            this.rosterDay7 = new Book_A_Majig_v2.Views.Rostering.ReusableControls.RosterDay();
            this.rosterDay6 = new Book_A_Majig_v2.Views.Rostering.ReusableControls.RosterDay();
            this.rosterDay5 = new Book_A_Majig_v2.Views.Rostering.ReusableControls.RosterDay();
            this.rosterDay4 = new Book_A_Majig_v2.Views.Rostering.ReusableControls.RosterDay();
            this.rosterDay3 = new Book_A_Majig_v2.Views.Rostering.ReusableControls.RosterDay();
            this.rosterDay2 = new Book_A_Majig_v2.Views.Rostering.ReusableControls.RosterDay();
            this.rosterDay1 = new Book_A_Majig_v2.Views.Rostering.ReusableControls.RosterDay();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblWeekOfYear
            // 
            this.lblWeekOfYear.AutoSize = true;
            this.lblWeekOfYear.Location = new System.Drawing.Point(280, 13);
            this.lblWeekOfYear.Name = "lblWeekOfYear";
            this.lblWeekOfYear.Size = new System.Drawing.Size(35, 13);
            this.lblWeekOfYear.TabIndex = 8;
            this.lblWeekOfYear.Text = "label1";
            // 
            // rosterDay7
            // 
            this.rosterDay7.DayOfWeek = 0;
            this.rosterDay7.Label = "Sunday";
            this.rosterDay7.Location = new System.Drawing.Point(1109, 40);
            this.rosterDay7.Name = "rosterDay7";
            this.rosterDay7.Size = new System.Drawing.Size(176, 440);
            this.rosterDay7.TabIndex = 7;
            // 
            // rosterDay6
            // 
            this.rosterDay6.DayOfWeek = 0;
            this.rosterDay6.Label = "Sunday";
            this.rosterDay6.Location = new System.Drawing.Point(926, 40);
            this.rosterDay6.Name = "rosterDay6";
            this.rosterDay6.Size = new System.Drawing.Size(176, 440);
            this.rosterDay6.TabIndex = 6;
            // 
            // rosterDay5
            // 
            this.rosterDay5.DayOfWeek = 0;
            this.rosterDay5.Label = "Sunday";
            this.rosterDay5.Location = new System.Drawing.Point(743, 40);
            this.rosterDay5.Name = "rosterDay5";
            this.rosterDay5.Size = new System.Drawing.Size(176, 440);
            this.rosterDay5.TabIndex = 5;
            // 
            // rosterDay4
            // 
            this.rosterDay4.DayOfWeek = 0;
            this.rosterDay4.Label = "Sunday";
            this.rosterDay4.Location = new System.Drawing.Point(561, 40);
            this.rosterDay4.Name = "rosterDay4";
            this.rosterDay4.Size = new System.Drawing.Size(176, 440);
            this.rosterDay4.TabIndex = 4;
            // 
            // rosterDay3
            // 
            this.rosterDay3.DayOfWeek = 0;
            this.rosterDay3.Label = "Sunday";
            this.rosterDay3.Location = new System.Drawing.Point(378, 40);
            this.rosterDay3.Name = "rosterDay3";
            this.rosterDay3.Size = new System.Drawing.Size(176, 440);
            this.rosterDay3.TabIndex = 3;
            // 
            // rosterDay2
            // 
            this.rosterDay2.DayOfWeek = 0;
            this.rosterDay2.Label = "Sunday";
            this.rosterDay2.Location = new System.Drawing.Point(195, 40);
            this.rosterDay2.Name = "rosterDay2";
            this.rosterDay2.Size = new System.Drawing.Size(176, 440);
            this.rosterDay2.TabIndex = 2;
            // 
            // rosterDay1
            // 
            this.rosterDay1.DayOfWeek = 0;
            this.rosterDay1.Label = "Sunday";
            this.rosterDay1.Location = new System.Drawing.Point(13, 40);
            this.rosterDay1.Name = "rosterDay1";
            this.rosterDay1.Size = new System.Drawing.Size(176, 440);
            this.rosterDay1.TabIndex = 1;
            // 
            // ViewRosters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 495);
            this.Controls.Add(this.lblWeekOfYear);
            this.Controls.Add(this.rosterDay7);
            this.Controls.Add(this.rosterDay6);
            this.Controls.Add(this.rosterDay5);
            this.Controls.Add(this.rosterDay4);
            this.Controls.Add(this.rosterDay3);
            this.Controls.Add(this.rosterDay2);
            this.Controls.Add(this.rosterDay1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ViewRosters";
            this.Text = "ViewRosters";
            this.Load += new System.EventHandler(this.ViewRosters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ReusableControls.RosterDay rosterDay1;
        private ReusableControls.RosterDay rosterDay2;
        private ReusableControls.RosterDay rosterDay3;
        private ReusableControls.RosterDay rosterDay4;
        private ReusableControls.RosterDay rosterDay5;
        private ReusableControls.RosterDay rosterDay6;
        private ReusableControls.RosterDay rosterDay7;
        private System.Windows.Forms.Label lblWeekOfYear;
    }
}