namespace Book_A_Majig_v2.Views.Rostering.Management
{
    partial class AddEditNA
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
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEndTime = new System.Windows.Forms.CheckBox();
            this.cbStartTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(13, 22);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(220, 21);
            this.cbEmployees.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 71);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(221, 20);
            this.dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(12, 126);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(221, 20);
            this.dtpEndDate.TabIndex = 4;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Enabled = false;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(256, 71);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 20);
            this.dtpStartTime.TabIndex = 5;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(256, 125);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 20);
            this.dtpEndTime.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "End Date";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(12, 169);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(444, 164);
            this.tbNotes.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Notes";
            // 
            // cbEndTime
            // 
            this.cbEndTime.AutoSize = true;
            this.cbEndTime.Location = new System.Drawing.Point(256, 106);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(68, 17);
            this.cbEndTime.TabIndex = 14;
            this.cbEndTime.Text = "EndTime";
            this.cbEndTime.UseVisualStyleBackColor = true;
            // 
            // cbStartTime
            // 
            this.cbStartTime.AutoSize = true;
            this.cbStartTime.Location = new System.Drawing.Point(256, 48);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(74, 17);
            this.cbStartTime.TabIndex = 15;
            this.cbStartTime.Text = "Start Time";
            this.cbStartTime.UseVisualStyleBackColor = true;
            // 
            // AddEditNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 374);
            this.Controls.Add(this.cbStartTime);
            this.Controls.Add(this.cbEndTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.button1);
            this.Name = "AddEditNA";
            this.Text = "AddEditNA";
            this.Load += new System.EventHandler(this.AddEditNA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbEndTime;
        private System.Windows.Forms.CheckBox cbStartTime;
    }
}