namespace MyBankSystemManagmentProject
{
    partial class frmResetCode
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
            this.panel_ResetCode = new System.Windows.Forms.Panel();
            this.txt_OTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel_SendCode = new System.Windows.Forms.LinkLabel();
            this.txt_UserName_Reset = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_check = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_ResetCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ResetCode
            // 
            this.panel_ResetCode.Controls.Add(this.txt_OTP);
            this.panel_ResetCode.Controls.Add(this.linkLabel_SendCode);
            this.panel_ResetCode.Controls.Add(this.txt_UserName_Reset);
            this.panel_ResetCode.Controls.Add(this.btn_check);
            this.panel_ResetCode.Controls.Add(this.label1);
            this.panel_ResetCode.Location = new System.Drawing.Point(44, 5);
            this.panel_ResetCode.Name = "panel_ResetCode";
            this.panel_ResetCode.Size = new System.Drawing.Size(571, 502);
            this.panel_ResetCode.TabIndex = 30;
            // 
            // txt_OTP
            // 
            this.txt_OTP.Animated = true;
            this.txt_OTP.AutoRoundedCorners = true;
            this.txt_OTP.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.txt_OTP.BorderRadius = 22;
            this.txt_OTP.BorderThickness = 0;
            this.txt_OTP.CausesValidation = false;
            this.txt_OTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OTP.DefaultText = "";
            this.txt_OTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_OTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_OTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_OTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_OTP.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_OTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_OTP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_OTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_OTP.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.user;
            this.txt_OTP.Location = new System.Drawing.Point(59, 242);
            this.txt_OTP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OTP.Name = "txt_OTP";
            this.txt_OTP.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_OTP.PlaceholderText = "   Enter Code";
            this.txt_OTP.SelectedText = "";
            this.txt_OTP.Size = new System.Drawing.Size(442, 46);
            this.txt_OTP.TabIndex = 29;
            this.txt_OTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel_SendCode
            // 
            this.linkLabel_SendCode.AutoSize = true;
            this.linkLabel_SendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_SendCode.Location = new System.Drawing.Point(306, 188);
            this.linkLabel_SendCode.Name = "linkLabel_SendCode";
            this.linkLabel_SendCode.Size = new System.Drawing.Size(195, 25);
            this.linkLabel_SendCode.TabIndex = 27;
            this.linkLabel_SendCode.TabStop = true;
            this.linkLabel_SendCode.Text = "Send Code To mail";
            this.linkLabel_SendCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SendCode_LinkClicked);
            // 
            // txt_UserName_Reset
            // 
            this.txt_UserName_Reset.AutoRoundedCorners = true;
            this.txt_UserName_Reset.BorderRadius = 22;
            this.txt_UserName_Reset.BorderThickness = 0;
            this.txt_UserName_Reset.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName_Reset.DefaultText = "";
            this.txt_UserName_Reset.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_UserName_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_UserName_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName_Reset.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_UserName_Reset.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_UserName_Reset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName_Reset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_UserName_Reset.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_UserName_Reset.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.user;
            this.txt_UserName_Reset.Location = new System.Drawing.Point(59, 138);
            this.txt_UserName_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserName_Reset.Name = "txt_UserName_Reset";
            this.txt_UserName_Reset.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_UserName_Reset.PlaceholderText = "   User Name";
            this.txt_UserName_Reset.SelectedText = "";
            this.txt_UserName_Reset.Size = new System.Drawing.Size(442, 46);
            this.txt_UserName_Reset.TabIndex = 25;
            this.txt_UserName_Reset.Validating += new System.ComponentModel.CancelEventHandler(this.txt_UserName_Reset_Validating);
            // 
            // btn_check
            // 
            this.btn_check.AutoRoundedCorners = true;
            this.btn_check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_check.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_check.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_check.Location = new System.Drawing.Point(59, 305);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(442, 45);
            this.btn_check.TabIndex = 13;
            this.btn_check.Text = "Check";
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reset Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmResetCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 517);
            this.Controls.Add(this.panel_ResetCode);
            this.Name = "frmResetCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.frmResetPasswordCode_Load);
            this.panel_ResetCode.ResumeLayout(false);
            this.panel_ResetCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ResetCode;
        private Guna.UI2.WinForms.Guna2TextBox txt_OTP;
        private System.Windows.Forms.LinkLabel linkLabel_SendCode;
        private Guna.UI2.WinForms.Guna2TextBox txt_UserName_Reset;
        private Guna.UI2.WinForms.Guna2Button btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}