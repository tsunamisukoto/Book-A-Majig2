namespace Book_A_Majig_v2
{
    partial class ViewBookings
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblNumCovers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumBookings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ShownClassificationListBox = new System.Windows.Forms.CheckedListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblMoreDetails = new System.Windows.Forms.RichTextBox();
            this.userInformation1 = new Book_A_Majig_v2.DatabaseEntities.UserInformation();
            this.stylesSheetManager1 = new Sb.Windows.Forms.StylesSheet.StylesSheetManager(this.components);
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.stylesSheetManager1.SetStyle(this.dateTimePicker1, "");
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2015, 8, 12, 14, 35, 17, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(32, 552);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(119, 23);
            this.stylesSheetManager1.SetStyle(this.btnAddBooking, "");
            this.btnAddBooking.TabIndex = 2;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(920, 408);
            this.stylesSheetManager1.SetStyle(this.dataGridView1, "");
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.button1, "");
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.button2, "");
            this.button2.TabIndex = 5;
            this.button2.Text = "Today";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(218, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.button3, "DeleteButton");
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(286, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.button4, "");
            this.button4.TabIndex = 7;
            this.button4.Text = "Confirm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.lblNumCovers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNumBookings);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 94);
            this.stylesSheetManager1.SetStyle(this.groupBox1, "");
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(523, 7);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(279, 87);
            this.stylesSheetManager1.SetStyle(this.richTextBox2, "");
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(247, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(269, 87);
            this.stylesSheetManager1.SetStyle(this.richTextBox1, "");
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // lblNumCovers
            // 
            this.lblNumCovers.AutoSize = true;
            this.lblNumCovers.Location = new System.Drawing.Point(10, 73);
            this.lblNumCovers.Name = "lblNumCovers";
            this.lblNumCovers.Size = new System.Drawing.Size(35, 13);
            this.stylesSheetManager1.SetStyle(this.lblNumCovers, "");
            this.lblNumCovers.TabIndex = 3;
            this.lblNumCovers.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.stylesSheetManager1.SetStyle(this.label2, "");
            this.label2.TabIndex = 2;
            this.label2.Text = "Number Of Covers";
            // 
            // lblNumBookings
            // 
            this.lblNumBookings.AutoSize = true;
            this.lblNumBookings.Location = new System.Drawing.Point(10, 37);
            this.lblNumBookings.Name = "lblNumBookings";
            this.lblNumBookings.Size = new System.Drawing.Size(83, 13);
            this.stylesSheetManager1.SetStyle(this.lblNumBookings, "");
            this.lblNumBookings.TabIndex = 1;
            this.lblNumBookings.Text = "lblNumBookings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.stylesSheetManager1.SetStyle(this.label1, "");
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Bookings:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Confirmed Bookings",
            "Unconfirmed Bookings",
            "Deleted Bookings",
            "Undeleted Bookings",
            "Arrived Bookings",
            "Unarrived Bookings"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(142, 94);
            this.stylesSheetManager1.SetStyle(this.checkedListBox1, "");
            this.checkedListBox1.TabIndex = 9;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.Click += new System.EventHandler(this.checkedListBox1_Click);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(847, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 123);
            this.stylesSheetManager1.SetStyle(this.groupBox2, "");
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ShownClassificationListBox);
            this.groupBox3.Location = new System.Drawing.Point(1007, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 120);
            this.stylesSheetManager1.SetStyle(this.groupBox3, "");
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Classifications";
            // 
            // ShownClassificationListBox
            // 
            this.ShownClassificationListBox.CheckOnClick = true;
            this.ShownClassificationListBox.FormattingEnabled = true;
            this.ShownClassificationListBox.Location = new System.Drawing.Point(0, 16);
            this.ShownClassificationListBox.Name = "ShownClassificationListBox";
            this.ShownClassificationListBox.Size = new System.Drawing.Size(194, 94);
            this.stylesSheetManager1.SetStyle(this.ShownClassificationListBox, "");
            this.ShownClassificationListBox.TabIndex = 0;
            this.ShownClassificationListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ShownClassificationListBox_ItemCheck);
            this.ShownClassificationListBox.SelectedIndexChanged += new System.EventHandler(this.ShownClassificationListBox_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(356, 552);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.button5, "");
            this.button5.TabIndex = 12;
            this.button5.Text = "Arrived";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblMoreDetails
            // 
            this.lblMoreDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMoreDetails.Location = new System.Drawing.Point(958, 138);
            this.lblMoreDetails.Name = "lblMoreDetails";
            this.lblMoreDetails.ReadOnly = true;
            this.lblMoreDetails.Size = new System.Drawing.Size(500, 408);
            this.stylesSheetManager1.SetStyle(this.lblMoreDetails, "");
            this.lblMoreDetails.TabIndex = 13;
            this.lblMoreDetails.Text = "";
            // 
            // userInformation1
            // 
            this.userInformation1.Location = new System.Drawing.Point(1213, 26);
            this.userInformation1.Name = "userInformation1";
            this.userInformation1.Size = new System.Drawing.Size(245, 98);
            this.stylesSheetManager1.SetStyle(this.userInformation1, "");
            this.userInformation1.TabIndex = 14;
            this.userInformation1.UserID = null;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 552);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.stylesSheetManager1.SetStyle(this.button6, "");
            this.button6.TabIndex = 15;
            this.button6.Text = "Administration";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 587);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.userInformation1);
            this.Controls.Add(this.lblMoreDetails);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ViewBookings";
            this.stylesSheetManager1.SetStyle(this, "");
            this.Text = "ViewBookings";
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumCovers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumBookings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox ShownClassificationListBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox lblMoreDetails;
        private DatabaseEntities.UserInformation userInformation1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Sb.Windows.Forms.StylesSheet.StylesSheetManager stylesSheetManager1;
        private System.Windows.Forms.Button button6;
    }
}