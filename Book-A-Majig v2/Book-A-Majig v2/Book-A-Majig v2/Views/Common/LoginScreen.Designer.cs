﻿namespace Book_A_Majig_v2
{
    partial class LoginScreen
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stylesSheetManager1 = new Sb.Windows.Forms.StylesSheet.StylesSheetManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 410);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.btnLogin, "");
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.stylesSheetManager1.SetStyle(this.btnCancel, "");
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(12, 244);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(273, 20);
            this.stylesSheetManager1.SetStyle(this.tbUserId, "");
            this.tbUserId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.stylesSheetManager1.SetStyle(this.label1, "");
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID:";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginScreen";
            this.stylesSheetManager1.SetStyle(this, "");
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stylesSheetManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label1;
        private Sb.Windows.Forms.StylesSheet.StylesSheetManager stylesSheetManager1;
    }
}