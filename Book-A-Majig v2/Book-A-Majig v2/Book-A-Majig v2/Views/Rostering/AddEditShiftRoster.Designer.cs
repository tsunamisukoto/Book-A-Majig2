namespace Book_A_Majig_v2.Views.Rostering
{
    partial class AddEditShiftRoster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbPresetShifts = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbEmployeeRequirementCategory = new System.Windows.Forms.ComboBox();
            this.dgvAvailableUsers = new System.Windows.Forms.DataGridView();
            this.dgvSlotsToFill = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotsToFill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shift Slots To Fill:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Users For Selected Shift Slot:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(745, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(365, 430);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BookingInformation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Preset Shifts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPresetShifts
            // 
            this.cbPresetShifts.FormattingEnabled = true;
            this.cbPresetShifts.Location = new System.Drawing.Point(388, 396);
            this.cbPresetShifts.Name = "cbPresetShifts";
            this.cbPresetShifts.Size = new System.Drawing.Size(197, 21);
            this.cbPresetShifts.TabIndex = 7;
            this.cbPresetShifts.Text = "Shift Category";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save Changes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add Shift Slot";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(133, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Remove Shift Slot";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.cbEmployeeRequirementCategory);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(385, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 202);
            this.panel1.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(100, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Finish Time";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH:MM tt";
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(100, 47);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(279, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Load Most Suitable Users";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(388, 423);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Save Slots As New Preset";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:MM tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // cbEmployeeRequirementCategory
            // 
            this.cbEmployeeRequirementCategory.FormattingEnabled = true;
            this.cbEmployeeRequirementCategory.Location = new System.Drawing.Point(3, 3);
            this.cbEmployeeRequirementCategory.Name = "cbEmployeeRequirementCategory";
            this.cbEmployeeRequirementCategory.Size = new System.Drawing.Size(156, 21);
            this.cbEmployeeRequirementCategory.TabIndex = 13;
            this.cbEmployeeRequirementCategory.Text = "Employee Requirement Category";
            // 
            // dgvAvailableUsers
            // 
            this.dgvAvailableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableUsers.Location = new System.Drawing.Point(17, 439);
            this.dgvAvailableUsers.Name = "dgvAvailableUsers";
            this.dgvAvailableUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableUsers.Size = new System.Drawing.Size(362, 180);
            this.dgvAvailableUsers.TabIndex = 16;
            this.dgvAvailableUsers.SelectionChanged += new System.EventHandler(this.dgvAvailableUsers_SelectionChanged);
            // 
            // dgvSlotsToFill
            // 
            this.dgvSlotsToFill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlotsToFill.Location = new System.Drawing.Point(7, 186);
            this.dgvSlotsToFill.Name = "dgvSlotsToFill";
            this.dgvSlotsToFill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlotsToFill.Size = new System.Drawing.Size(372, 202);
            this.dgvSlotsToFill.TabIndex = 17;
            this.dgvSlotsToFill.SelectionChanged += new System.EventHandler(this.dgvSlotsToFill_SelectionChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(198, 415);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "^^Assign";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(10, 51);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(734, 95);
            this.txtNotes.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Notes";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(533, 423);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "Save Slots As Existing Preset";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // AddEditShiftRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 660);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dgvSlotsToFill);
            this.Controls.Add(this.dgvAvailableUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbPresetShifts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditShiftRoster";
            this.Text = "AddEditShiftRoster";
            this.Load += new System.EventHandler(this.AddEditShiftRoster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotsToFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPresetShifts;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbEmployeeRequirementCategory;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dgvAvailableUsers;
        private System.Windows.Forms.DataGridView dgvSlotsToFill;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button9;
    }
}