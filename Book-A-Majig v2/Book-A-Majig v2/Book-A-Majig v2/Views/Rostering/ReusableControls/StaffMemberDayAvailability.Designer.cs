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
            this.SuspendLayout();
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.Location = new System.Drawing.Point(3, 3);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(185, 385);
            this.lblDayOfWeek.TabIndex = 0;
            this.lblDayOfWeek.TabStop = false;
            this.lblDayOfWeek.Text = "Day";
            // 
            // StaffMemberDayAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDayOfWeek);
            this.Name = "StaffMemberDayAvailability";
            this.Size = new System.Drawing.Size(191, 391);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lblDayOfWeek;
    }
}
