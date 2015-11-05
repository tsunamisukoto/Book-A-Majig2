namespace Book_A_Majig_v2.Views.Rostering.ReusableControls
{
    partial class StaffMemberDayAvailability
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDayOfWeek = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDayOfWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.Controls.Add(this.richTextBox1);
            this.lblDayOfWeek.Controls.Add(this.button1);
            this.lblDayOfWeek.Location = new System.Drawing.Point(3, 3);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(169, 385);
            this.lblDayOfWeek.TabIndex = 0;
            this.lblDayOfWeek.TabStop = false;
            this.lblDayOfWeek.Text = "Day";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(156, 330);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // StaffMemberDayAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDayOfWeek);
            this.Name = "StaffMemberDayAvailability";
            this.Size = new System.Drawing.Size(177, 391);
            this.Load += new System.EventHandler(this.StaffMemberDayAvailability_Load);
            this.lblDayOfWeek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblDayOfWeek;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}
