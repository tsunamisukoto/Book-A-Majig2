namespace Book_A_Majig_v2.Views.Common.RestaurantManagement
{
    partial class ManageRestaurantDateNotes
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
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.dgvLocked = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocked)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upcoming Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upcoming Locked Dates";
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(13, 30);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.Size = new System.Drawing.Size(724, 251);
            this.dgvNotes.TabIndex = 2;
            // 
            // dgvLocked
            // 
            this.dgvLocked.AllowUserToAddRows = false;
            this.dgvLocked.AllowUserToDeleteRows = false;
            this.dgvLocked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocked.Location = new System.Drawing.Point(3, 316);
            this.dgvLocked.Name = "dgvLocked";
            this.dgvLocked.ReadOnly = true;
            this.dgvLocked.Size = new System.Drawing.Size(724, 320);
            this.dgvLocked.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Locked Date";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete Locked Date";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit Locked Date";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Edit Date Note";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(377, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Delete Date Note";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(105, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Add Date Note";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // ManageRestaurantDateNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 648);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLocked);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageRestaurantDateNotes";
            this.Text = "ManageRestaurantDateNotes";
            this.Load += new System.EventHandler(this.ManageRestaurantDateNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.DataGridView dgvLocked;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}