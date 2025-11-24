namespace MyBankSystemManagmentProject
{
    partial class frmResetPassword
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
            this.panel_ResetPassowrd = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ConfirmNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.panel_ResetPassowrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ResetPassowrd
            // 
            this.panel_ResetPassowrd.Controls.Add(this.label2);
            this.panel_ResetPassowrd.Controls.Add(this.txt_ConfirmNewPassword);
            this.panel_ResetPassowrd.Controls.Add(this.txt_NewPassword);
            this.panel_ResetPassowrd.Controls.Add(this.btnResetPassword);
            this.panel_ResetPassowrd.Location = new System.Drawing.Point(34, 27);
            this.panel_ResetPassowrd.Name = "panel_ResetPassowrd";
            this.panel_ResetPassowrd.Size = new System.Drawing.Size(604, 463);
            this.panel_ResetPassowrd.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label2.Location = new System.Drawing.Point(60, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 86);
            this.label2.TabIndex = 32;
            this.label2.Text = "Reset Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_ConfirmNewPassword
            // 
            this.txt_ConfirmNewPassword.AutoRoundedCorners = true;
            this.txt_ConfirmNewPassword.BorderRadius = 22;
            this.txt_ConfirmNewPassword.BorderThickness = 0;
            this.txt_ConfirmNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConfirmNewPassword.DefaultText = "";
            this.txt_ConfirmNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ConfirmNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ConfirmNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ConfirmNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ConfirmNewPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ConfirmNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_ConfirmNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ConfirmNewPassword.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.Password;
            this.txt_ConfirmNewPassword.Location = new System.Drawing.Point(83, 215);
            this.txt_ConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword";
            this.txt_ConfirmNewPassword.PasswordChar = '*';
            this.txt_ConfirmNewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_ConfirmNewPassword.PlaceholderText = "   Confirm Password";
            this.txt_ConfirmNewPassword.SelectedText = "";
            this.txt_ConfirmNewPassword.Size = new System.Drawing.Size(442, 46);
            this.txt_ConfirmNewPassword.TabIndex = 31;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.AutoRoundedCorners = true;
            this.txt_NewPassword.BorderRadius = 22;
            this.txt_NewPassword.BorderThickness = 0;
            this.txt_NewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NewPassword.DefaultText = "";
            this.txt_NewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NewPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NewPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_NewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NewPassword.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.Password;
            this.txt_NewPassword.Location = new System.Drawing.Point(83, 161);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.PasswordChar = '*';
            this.txt_NewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_NewPassword.PlaceholderText = "   New Password";
            this.txt_NewPassword.SelectedText = "";
            this.txt_NewPassword.Size = new System.Drawing.Size(442, 46);
            this.txt_NewPassword.TabIndex = 30;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.AutoRoundedCorners = true;
            this.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnResetPassword.Location = new System.Drawing.Point(83, 308);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(442, 45);
            this.btnResetPassword.TabIndex = 29;
            this.btnResetPassword.Text = "reset";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 517);
            this.Controls.Add(this.panel_ResetPassowrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.panel_ResetPassowrd.ResumeLayout(false);
            this.panel_ResetPassowrd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ResetPassowrd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_ConfirmNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_NewPassword;
        private Guna.UI2.WinForms.Guna2Button btnResetPassword;
    }
}