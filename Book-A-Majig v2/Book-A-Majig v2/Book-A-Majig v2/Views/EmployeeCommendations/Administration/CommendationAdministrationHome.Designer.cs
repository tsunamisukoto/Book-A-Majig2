﻿namespace Book_A_Majig_v2.Views.EmployeeCommendations.Administration
{
    partial class CommendationAdministrationHome
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Skill Categories";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Commendation Classifications";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CommendationAdministrationHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CommendationAdministrationHome";
            this.Text = "CommendationAdministrationHome";
            this.Load += new System.EventHandler(this.CommendationAdministrationHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}