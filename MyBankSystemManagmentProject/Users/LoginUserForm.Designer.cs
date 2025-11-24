namespace MyBankSystemManagmentProject
{
    partial class LoginUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserForm));
            this.Loginpanel2 = new System.Windows.Forms.Panel();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.linklabel_ForotPassword = new System.Windows.Forms.LinkLabel();
            this.btn_LoginUser = new Guna.UI2.WinForms.Guna2Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_LoginUser_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_LoginUser_UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Minimize = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.Loginpanel2.SuspendLayout();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginpanel2
            // 
            this.Loginpanel2.BackColor = System.Drawing.Color.White;
            this.Loginpanel2.Controls.Add(this.panel_Login);
            this.Loginpanel2.Controls.Add(this.pictureBox1);
            this.Loginpanel2.Controls.Add(this.pb_Minimize);
            this.Loginpanel2.Controls.Add(this.pb_Close);
            this.Loginpanel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Loginpanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loginpanel2.Location = new System.Drawing.Point(0, 0);
            this.Loginpanel2.Name = "Loginpanel2";
            this.Loginpanel2.Size = new System.Drawing.Size(1403, 717);
            this.Loginpanel2.TabIndex = 11;
            // 
            // panel_Login
            // 
            this.panel_Login.Controls.Add(this.linklabel_ForotPassword);
            this.panel_Login.Controls.Add(this.txt_LoginUser_Password);
            this.panel_Login.Controls.Add(this.txt_LoginUser_UserName);
            this.panel_Login.Controls.Add(this.btn_LoginUser);
            this.panel_Login.Controls.Add(this.checkBoxRemember);
            this.panel_Login.Controls.Add(this.lbl_Login);
            this.panel_Login.Location = new System.Drawing.Point(523, 59);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(571, 526);
            this.panel_Login.TabIndex = 28;
            // 
            // linklabel_ForotPassword
            // 
            this.linklabel_ForotPassword.AutoSize = true;
            this.linklabel_ForotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabel_ForotPassword.Location = new System.Drawing.Point(309, 320);
            this.linklabel_ForotPassword.Name = "linklabel_ForotPassword";
            this.linklabel_ForotPassword.Size = new System.Drawing.Size(192, 25);
            this.linklabel_ForotPassword.TabIndex = 27;
            this.linklabel_ForotPassword.TabStop = true;
            this.linklabel_ForotPassword.Text = "Forgot Password ?";
            this.linklabel_ForotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_ForgotPassword_LinkClicked);
            // 
            // btn_LoginUser
            // 
            this.btn_LoginUser.AutoRoundedCorners = true;
            this.btn_LoginUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LoginUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LoginUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LoginUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LoginUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_LoginUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginUser.ForeColor = System.Drawing.Color.White;
            this.btn_LoginUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_LoginUser.Location = new System.Drawing.Point(59, 374);
            this.btn_LoginUser.Name = "btn_LoginUser";
            this.btn_LoginUser.Size = new System.Drawing.Size(442, 45);
            this.btn_LoginUser.TabIndex = 13;
            this.btn_LoginUser.Text = "Login";
            this.btn_LoginUser.Click += new System.EventHandler(this.btn_LoginUser_Click_1);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.checkBoxRemember.Location = new System.Drawing.Point(59, 320);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(182, 29);
            this.checkBoxRemember.TabIndex = 12;
            this.checkBoxRemember.Text = "Remember Me";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Login.Location = new System.Drawing.Point(96, 11);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(358, 86);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Login User";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_LoginUser_Password
            // 
            this.txt_LoginUser_Password.AutoRoundedCorners = true;
            this.txt_LoginUser_Password.BorderRadius = 22;
            this.txt_LoginUser_Password.BorderThickness = 0;
            this.txt_LoginUser_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LoginUser_Password.DefaultText = "";
            this.txt_LoginUser_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LoginUser_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LoginUser_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LoginUser_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LoginUser_Password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LoginUser_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LoginUser_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginUser_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_LoginUser_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LoginUser_Password.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.Password;
            this.txt_LoginUser_Password.Location = new System.Drawing.Point(59, 267);
            this.txt_LoginUser_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoginUser_Password.Name = "txt_LoginUser_Password";
            this.txt_LoginUser_Password.PasswordChar = '*';
            this.txt_LoginUser_Password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_LoginUser_Password.PlaceholderText = "   Password";
            this.txt_LoginUser_Password.SelectedText = "";
            this.txt_LoginUser_Password.Size = new System.Drawing.Size(442, 46);
            this.txt_LoginUser_Password.TabIndex = 26;
            // 
            // txt_LoginUser_UserName
            // 
            this.txt_LoginUser_UserName.AutoRoundedCorners = true;
            this.txt_LoginUser_UserName.BorderRadius = 22;
            this.txt_LoginUser_UserName.BorderThickness = 0;
            this.txt_LoginUser_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LoginUser_UserName.DefaultText = "";
            this.txt_LoginUser_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LoginUser_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LoginUser_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LoginUser_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LoginUser_UserName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LoginUser_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LoginUser_UserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginUser_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_LoginUser_UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LoginUser_UserName.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.user;
            this.txt_LoginUser_UserName.Location = new System.Drawing.Point(59, 202);
            this.txt_LoginUser_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoginUser_UserName.Name = "txt_LoginUser_UserName";
            this.txt_LoginUser_UserName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_LoginUser_UserName.PlaceholderText = "   User Name";
            this.txt_LoginUser_UserName.SelectedText = "";
            this.txt_LoginUser_UserName.Size = new System.Drawing.Size(442, 46);
            this.txt_LoginUser_UserName.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 712);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Minimize
            // 
            this.pb_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_Minimize.Image")));
            this.pb_Minimize.Location = new System.Drawing.Point(1324, 0);
            this.pb_Minimize.Name = "pb_Minimize";
            this.pb_Minimize.Size = new System.Drawing.Size(41, 38);
            this.pb_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Minimize.TabIndex = 9;
            this.pb_Minimize.TabStop = false;
            this.pb_Minimize.Click += new System.EventHandler(this.pb_Minimize_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(1362, 0);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(41, 38);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Close.TabIndex = 10;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // LoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 717);
            this.Controls.Add(this.Loginpanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginUserForm";
            this.Load += new System.EventHandler(this.LoginUserForm_Load);
            this.Loginpanel2.ResumeLayout(false);
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loginpanel2;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private Guna.UI2.WinForms.Guna2Button btn_LoginUser;
        private Guna.UI2.WinForms.Guna2TextBox txt_LoginUser_Password;
        private Guna.UI2.WinForms.Guna2TextBox txt_LoginUser_UserName;
        private System.Windows.Forms.LinkLabel linklabel_ForotPassword;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}