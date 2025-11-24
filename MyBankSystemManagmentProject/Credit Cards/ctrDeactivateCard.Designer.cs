namespace MyBankSystemManagmentProject
{
    partial class ctrDeactivateCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDeactivateCard));
            this.btn_Issue = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Deactivate = new System.Windows.Forms.Label();
            this.btn_MainMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Back_AddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.cb_CardStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // btn_Issue
            // 
            this.btn_Issue.AutoRoundedCorners = true;
            this.btn_Issue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Issue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Issue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Issue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Issue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Issue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Issue.ForeColor = System.Drawing.Color.White;
            this.btn_Issue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_Issue.IndicateFocus = true;
            this.btn_Issue.Location = new System.Drawing.Point(511, 391);
            this.btn_Issue.Name = "btn_Issue";
            this.btn_Issue.Size = new System.Drawing.Size(486, 45);
            this.btn_Issue.TabIndex = 132;
            this.btn_Issue.Text = "Deactivate";
            this.btn_Issue.Click += new System.EventHandler(this.btn_Deactivate_Click);
            // 
            // lbl_Deactivate
            // 
            this.lbl_Deactivate.AutoSize = true;
            this.lbl_Deactivate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deactivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Deactivate.Location = new System.Drawing.Point(551, 0);
            this.lbl_Deactivate.Name = "lbl_Deactivate";
            this.lbl_Deactivate.Size = new System.Drawing.Size(385, 65);
            this.lbl_Deactivate.TabIndex = 131;
            this.lbl_Deactivate.Text = "Deactivate Card";
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.AutoRoundedCorners = true;
            this.btn_MainMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_MainMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_MainMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_MainMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_MainMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_MainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.ForeColor = System.Drawing.Color.White;
            this.btn_MainMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_MainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_MainMenu.Image")));
            this.btn_MainMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_MainMenu.Location = new System.Drawing.Point(93, 642);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(131, 43);
            this.btn_MainMenu.TabIndex = 134;
            this.btn_MainMenu.Text = "Home";
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_Back_AddNewClient
            // 
            this.btn_Back_AddNewClient.AutoRoundedCorners = true;
            this.btn_Back_AddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back_AddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back_AddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back_AddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back_AddNewClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Back_AddNewClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back_AddNewClient.ForeColor = System.Drawing.Color.White;
            this.btn_Back_AddNewClient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_Back_AddNewClient.Image = global::MyBankSystemManagmentProject.Properties.Resources.back3_100;
            this.btn_Back_AddNewClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Back_AddNewClient.Location = new System.Drawing.Point(93, 691);
            this.btn_Back_AddNewClient.Name = "btn_Back_AddNewClient";
            this.btn_Back_AddNewClient.Size = new System.Drawing.Size(131, 43);
            this.btn_Back_AddNewClient.TabIndex = 133;
            this.btn_Back_AddNewClient.Text = "Back";
            this.btn_Back_AddNewClient.Click += new System.EventHandler(this.btn_Back_AddNewClient_Click);
            // 
            // cb_CardStatus
            // 
            this.cb_CardStatus.AutoRoundedCorners = true;
            this.cb_CardStatus.BackColor = System.Drawing.Color.Transparent;
            this.cb_CardStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_CardStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CardStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cb_CardStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CardStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CardStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_CardStatus.ForeColor = System.Drawing.Color.Gray;
            this.cb_CardStatus.ItemHeight = 30;
            this.cb_CardStatus.Items.AddRange(new object[] {
            "Card Status For Deactivation",
            "Frozen",
            "Lost",
            "Cancelled",
            "Reissued"});
            this.cb_CardStatus.Location = new System.Drawing.Point(511, 228);
            this.cb_CardStatus.Name = "cb_CardStatus";
            this.cb_CardStatus.Size = new System.Drawing.Size(486, 36);
            this.cb_CardStatus.TabIndex = 135;
            this.cb_CardStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctrDeactivateCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cb_CardStatus);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Back_AddNewClient);
            this.Controls.Add(this.btn_Issue);
            this.Controls.Add(this.lbl_Deactivate);
            this.Name = "ctrDeactivateCard";
            this.Size = new System.Drawing.Size(1451, 750);
            this.Load += new System.EventHandler(this.ctrDeactivateCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_MainMenu;
        private Guna.UI2.WinForms.Guna2Button btn_Back_AddNewClient;
        private Guna.UI2.WinForms.Guna2Button btn_Issue;
        private System.Windows.Forms.Label lbl_Deactivate;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CardStatus;
    }
}
