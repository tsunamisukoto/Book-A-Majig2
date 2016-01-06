namespace Book_A_Majig_v2.Views.Common.AccessLevelManagement
{
    partial class ViewAccessLevels
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
            this.dgvAccessLevels = new System.Windows.Forms.DataGridView();
            this.lblMoreDetails = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccessLevels
            // 
            this.dgvAccessLevels.AllowUserToAddRows = false;
            this.dgvAccessLevels.AllowUserToDeleteRows = false;
            this.dgvAccessLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccessLevels.Location = new System.Drawing.Point(13, 13);
            this.dgvAccessLevels.Name = "dgvAccessLevels";
            this.dgvAccessLevels.ReadOnly = true;
            this.dgvAccessLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccessLevels.Size = new System.Drawing.Size(260, 350);
            this.dgvAccessLevels.TabIndex = 0;
            this.dgvAccessLevels.SelectionChanged += new System.EventHandler(this.dgvAccessLevels_SelectionChanged);
            // 
            // lblMoreDetails
            // 
            this.lblMoreDetails.Location = new System.Drawing.Point(280, 13);
            this.lblMoreDetails.Multiline = true;
            this.lblMoreDetails.Name = "lblMoreDetails";
            this.lblMoreDetails.ReadOnly = true;
            this.lblMoreDetails.Size = new System.Drawing.Size(441, 350);
            this.lblMoreDetails.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Access Level";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit Access Level";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Manage Level Permissions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Manage Level Employees";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ViewAccessLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 412);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMoreDetails);
            this.Controls.Add(this.dgvAccessLevels);
            this.Name = "ViewAccessLevels";
            this.Text = "ViewAccessLevels";
            this.Load += new System.EventHandler(this.ViewAccessLevels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccessLevels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccessLevels;
        private System.Windows.Forms.RichTextBox lblMoreDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}