namespace Book_A_Majig_v2.Views.EmployeeCommendations
{
    partial class ViewCommendations
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
            this.dgvStaffCommentations = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvTopStaff = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTeamCommendations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffCommentations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamCommendations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaffCommentations
            // 
            this.dgvStaffCommentations.AllowUserToAddRows = false;
            this.dgvStaffCommentations.AllowUserToDeleteRows = false;
            this.dgvStaffCommentations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffCommentations.Location = new System.Drawing.Point(6, 19);
            this.dgvStaffCommentations.Name = "dgvStaffCommentations";
            this.dgvStaffCommentations.ReadOnly = true;
            this.dgvStaffCommentations.Size = new System.Drawing.Size(305, 266);
            this.dgvStaffCommentations.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Commend Staff Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Commend Roster Team";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvTopStaff
            // 
            this.dgvTopStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopStaff.Location = new System.Drawing.Point(6, 19);
            this.dgvTopStaff.Name = "dgvTopStaff";
            this.dgvTopStaff.Size = new System.Drawing.Size(589, 215);
            this.dgvTopStaff.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStaffCommentations);
            this.groupBox1.Location = new System.Drawing.Point(16, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 291);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Staff Commendations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTopStaff);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 240);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top Staff";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTeamCommendations);
            this.groupBox3.Location = new System.Drawing.Point(349, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 291);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recent Team Commendations";
            // 
            // dgvTeamCommendations
            // 
            this.dgvTeamCommendations.AllowUserToAddRows = false;
            this.dgvTeamCommendations.AllowUserToDeleteRows = false;
            this.dgvTeamCommendations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamCommendations.Location = new System.Drawing.Point(17, 19);
            this.dgvTeamCommendations.Name = "dgvTeamCommendations";
            this.dgvTeamCommendations.ReadOnly = true;
            this.dgvTeamCommendations.Size = new System.Drawing.Size(240, 266);
            this.dgvTeamCommendations.TabIndex = 0;
            // 
            // ViewCommendations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 665);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ViewCommendations";
            this.Text = "ViewCommendations";
            this.Load += new System.EventHandler(this.ViewCommendations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffCommentations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamCommendations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffCommentations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvTopStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTeamCommendations;
    }
}