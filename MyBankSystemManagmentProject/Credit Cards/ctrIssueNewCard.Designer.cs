namespace MyBankSystemManagmentProject
{
    partial class ctrIssueNewCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrIssueNewCard));
            this.cb_CreditCardNetwork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_CreditCardType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txt_CreditPassword_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Issue = new System.Windows.Forms.Label();
            this.btn_Back_AddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Issue = new Guna.UI2.WinForms.Guna2Button();
            this.btn_MainMenu = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cb_CreditCardNetwork
            // 
            this.cb_CreditCardNetwork.AutoRoundedCorners = true;
            this.cb_CreditCardNetwork.BackColor = System.Drawing.Color.Transparent;
            this.cb_CreditCardNetwork.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_CreditCardNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CreditCardNetwork.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cb_CreditCardNetwork.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CreditCardNetwork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CreditCardNetwork.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_CreditCardNetwork.ForeColor = System.Drawing.Color.Gray;
            this.cb_CreditCardNetwork.ItemHeight = 30;
            this.cb_CreditCardNetwork.Items.AddRange(new object[] {
            "Network Type",
            "Visa",
            "MasterCard",
            "American Express",
            "Discover",
            "UnionPay"});
            this.cb_CreditCardNetwork.Location = new System.Drawing.Point(754, 262);
            this.cb_CreditCardNetwork.Name = "cb_CreditCardNetwork";
            this.cb_CreditCardNetwork.Size = new System.Drawing.Size(238, 36);
            this.cb_CreditCardNetwork.TabIndex = 125;
            this.cb_CreditCardNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_CreditCardType
            // 
            this.cb_CreditCardType.AutoRoundedCorners = true;
            this.cb_CreditCardType.BackColor = System.Drawing.Color.Transparent;
            this.cb_CreditCardType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_CreditCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CreditCardType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cb_CreditCardType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CreditCardType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_CreditCardType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_CreditCardType.ForeColor = System.Drawing.Color.Gray;
            this.cb_CreditCardType.ItemHeight = 30;
            this.cb_CreditCardType.Items.AddRange(new object[] {
            "Card Type",
            "Debit Card",
            "Credit Card",
            "Prepaid Card",
            "Charge Card"});
            this.cb_CreditCardType.Location = new System.Drawing.Point(506, 263);
            this.cb_CreditCardType.Name = "cb_CreditCardType";
            this.cb_CreditCardType.Size = new System.Drawing.Size(238, 36);
            this.cb_CreditCardType.TabIndex = 124;
            this.cb_CreditCardType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_CreditPassword_AddClient
            // 
            this.Txt_CreditPassword_AddClient.AutoRoundedCorners = true;
            this.Txt_CreditPassword_AddClient.BorderRadius = 17;
            this.Txt_CreditPassword_AddClient.BorderThickness = 0;
            this.Txt_CreditPassword_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_CreditPassword_AddClient.DefaultText = "";
            this.Txt_CreditPassword_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_CreditPassword_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_CreditPassword_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_CreditPassword_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_CreditPassword_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_CreditPassword_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_CreditPassword_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreditPassword_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Txt_CreditPassword_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_CreditPassword_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.Password;
            this.Txt_CreditPassword_AddClient.Location = new System.Drawing.Point(506, 309);
            this.Txt_CreditPassword_AddClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_CreditPassword_AddClient.Name = "Txt_CreditPassword_AddClient";
            this.Txt_CreditPassword_AddClient.PasswordChar = '*';
            this.Txt_CreditPassword_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Txt_CreditPassword_AddClient.PlaceholderText = "Credit Card Password";
            this.Txt_CreditPassword_AddClient.SelectedText = "";
            this.Txt_CreditPassword_AddClient.Size = new System.Drawing.Size(486, 36);
            this.Txt_CreditPassword_AddClient.TabIndex = 123;
            // 
            // lbl_Issue
            // 
            this.lbl_Issue.AutoSize = true;
            this.lbl_Issue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Issue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Issue.Location = new System.Drawing.Point(546, 0);
            this.lbl_Issue.Name = "lbl_Issue";
            this.lbl_Issue.Size = new System.Drawing.Size(373, 65);
            this.lbl_Issue.TabIndex = 126;
            this.lbl_Issue.Text = "Issue New Card";
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
            this.btn_Back_AddNewClient.Location = new System.Drawing.Point(88, 691);
            this.btn_Back_AddNewClient.Name = "btn_Back_AddNewClient";
            this.btn_Back_AddNewClient.Size = new System.Drawing.Size(131, 43);
            this.btn_Back_AddNewClient.TabIndex = 129;
            this.btn_Back_AddNewClient.Text = "Back";
            this.btn_Back_AddNewClient.Click += new System.EventHandler(this.btn_Back_AddNewClient_Click);
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
            this.btn_Issue.Location = new System.Drawing.Point(506, 391);
            this.btn_Issue.Name = "btn_Issue";
            this.btn_Issue.Size = new System.Drawing.Size(486, 45);
            this.btn_Issue.TabIndex = 128;
            this.btn_Issue.Text = "Issue";
            this.btn_Issue.Click += new System.EventHandler(this.btn_Issue_Click);
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
            this.btn_MainMenu.Location = new System.Drawing.Point(88, 642);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(131, 43);
            this.btn_MainMenu.TabIndex = 130;
            this.btn_MainMenu.Text = "Home";
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // ctrIssueNewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Back_AddNewClient);
            this.Controls.Add(this.btn_Issue);
            this.Controls.Add(this.lbl_Issue);
            this.Controls.Add(this.cb_CreditCardNetwork);
            this.Controls.Add(this.cb_CreditCardType);
            this.Controls.Add(this.Txt_CreditPassword_AddClient);
            this.Name = "ctrIssueNewCard";
            this.Size = new System.Drawing.Size(1451, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cb_CreditCardNetwork;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CreditCardType;
        private Guna.UI2.WinForms.Guna2TextBox Txt_CreditPassword_AddClient;
        private System.Windows.Forms.Label lbl_Issue;
        private Guna.UI2.WinForms.Guna2Button btn_Back_AddNewClient;
        private Guna.UI2.WinForms.Guna2Button btn_Issue;
        private Guna.UI2.WinForms.Guna2Button btn_MainMenu;
    }
}
