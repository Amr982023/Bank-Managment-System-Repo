namespace MyBankSystemManagmentProject
{
    partial class ctrAddNewAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddNewAccount));
            this.cb_Currency = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_CreditCardNetwork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_CreditCardType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_AccountType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_AddAccount_NationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txt_CreditPassword_AddAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_AddAccount_AccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Balance_AddAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_MainMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AddNewAccount = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Currency
            // 
            this.cb_Currency.AutoRoundedCorners = true;
            this.cb_Currency.BackColor = System.Drawing.Color.Transparent;
            this.cb_Currency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Currency.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Currency.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Currency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Currency.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_Currency.ForeColor = System.Drawing.Color.Gray;
            this.cb_Currency.ItemHeight = 30;
            this.cb_Currency.Location = new System.Drawing.Point(615, 549);
            this.cb_Currency.Name = "cb_Currency";
            this.cb_Currency.Size = new System.Drawing.Size(581, 36);
            this.cb_Currency.TabIndex = 132;
            this.cb_Currency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_Currency.Validating += new System.ComponentModel.CancelEventHandler(this.cb_Currency_Validating);
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
            this.cb_CreditCardNetwork.Location = new System.Drawing.Point(615, 400);
            this.cb_CreditCardNetwork.Name = "cb_CreditCardNetwork";
            this.cb_CreditCardNetwork.Size = new System.Drawing.Size(581, 36);
            this.cb_CreditCardNetwork.TabIndex = 131;
            this.cb_CreditCardNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_CreditCardNetwork.Validating += new System.ComponentModel.CancelEventHandler(this.cb_CreditCardNetwork_Validating);
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
            this.cb_CreditCardType.Location = new System.Drawing.Point(918, 342);
            this.cb_CreditCardType.Name = "cb_CreditCardType";
            this.cb_CreditCardType.Size = new System.Drawing.Size(278, 36);
            this.cb_CreditCardType.TabIndex = 130;
            this.cb_CreditCardType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_CreditCardType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_CreditCardType_Validating);
            // 
            // cb_AccountType
            // 
            this.cb_AccountType.AutoRoundedCorners = true;
            this.cb_AccountType.BackColor = System.Drawing.Color.Transparent;
            this.cb_AccountType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_AccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AccountType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cb_AccountType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AccountType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AccountType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_AccountType.ForeColor = System.Drawing.Color.Gray;
            this.cb_AccountType.ItemHeight = 30;
            this.cb_AccountType.Items.AddRange(new object[] {
            "Account Type",
            "Current",
            "Saving",
            "Fixed",
            "Deposit",
            "Salary",
            "Joint",
            "Student"});
            this.cb_AccountType.Location = new System.Drawing.Point(615, 342);
            this.cb_AccountType.Name = "cb_AccountType";
            this.cb_AccountType.Size = new System.Drawing.Size(278, 36);
            this.cb_AccountType.StartIndex = 0;
            this.cb_AccountType.TabIndex = 129;
            this.cb_AccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_AccountType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_AccountType_Validating);
            // 
            // txt_AddAccount_NationalID
            // 
            this.txt_AddAccount_NationalID.AutoRoundedCorners = true;
            this.txt_AddAccount_NationalID.BorderRadius = 33;
            this.txt_AddAccount_NationalID.BorderThickness = 0;
            this.txt_AddAccount_NationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddAccount_NationalID.DefaultText = "";
            this.txt_AddAccount_NationalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AddAccount_NationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AddAccount_NationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddAccount_NationalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddAccount_NationalID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_AddAccount_NationalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddAccount_NationalID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddAccount_NationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_AddAccount_NationalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddAccount_NationalID.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_AddAccount_NationalID.IconLeft")));
            this.txt_AddAccount_NationalID.Location = new System.Drawing.Point(615, 69);
            this.txt_AddAccount_NationalID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AddAccount_NationalID.Name = "txt_AddAccount_NationalID";
            this.txt_AddAccount_NationalID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_AddAccount_NationalID.PlaceholderText = "   Client National ID";
            this.txt_AddAccount_NationalID.SelectedText = "";
            this.txt_AddAccount_NationalID.Size = new System.Drawing.Size(581, 69);
            this.txt_AddAccount_NationalID.TabIndex = 128;
            this.txt_AddAccount_NationalID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AddAccount_NationalID_Validating);
            // 
            // Txt_CreditPassword_AddAccount
            // 
            this.Txt_CreditPassword_AddAccount.AutoRoundedCorners = true;
            this.Txt_CreditPassword_AddAccount.BorderRadius = 33;
            this.Txt_CreditPassword_AddAccount.BorderThickness = 0;
            this.Txt_CreditPassword_AddAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_CreditPassword_AddAccount.DefaultText = "";
            this.Txt_CreditPassword_AddAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_CreditPassword_AddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_CreditPassword_AddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_CreditPassword_AddAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_CreditPassword_AddAccount.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_CreditPassword_AddAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_CreditPassword_AddAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreditPassword_AddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Txt_CreditPassword_AddAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_CreditPassword_AddAccount.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.Password;
            this.Txt_CreditPassword_AddAccount.Location = new System.Drawing.Point(615, 458);
            this.Txt_CreditPassword_AddAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_CreditPassword_AddAccount.Name = "Txt_CreditPassword_AddAccount";
            this.Txt_CreditPassword_AddAccount.PasswordChar = '*';
            this.Txt_CreditPassword_AddAccount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Txt_CreditPassword_AddAccount.PlaceholderText = "Credit Card Password";
            this.Txt_CreditPassword_AddAccount.SelectedText = "";
            this.Txt_CreditPassword_AddAccount.Size = new System.Drawing.Size(581, 69);
            this.Txt_CreditPassword_AddAccount.TabIndex = 127;
            this.Txt_CreditPassword_AddAccount.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_CreditPassword_AddAccount_Validating);
            // 
            // txt_AddAccount_AccountNumber
            // 
            this.txt_AddAccount_AccountNumber.AutoRoundedCorners = true;
            this.txt_AddAccount_AccountNumber.BorderRadius = 33;
            this.txt_AddAccount_AccountNumber.BorderThickness = 0;
            this.txt_AddAccount_AccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddAccount_AccountNumber.DefaultText = "";
            this.txt_AddAccount_AccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AddAccount_AccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AddAccount_AccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddAccount_AccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddAccount_AccountNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_AddAccount_AccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddAccount_AccountNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddAccount_AccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_AddAccount_AccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddAccount_AccountNumber.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.user;
            this.txt_AddAccount_AccountNumber.Location = new System.Drawing.Point(615, 160);
            this.txt_AddAccount_AccountNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AddAccount_AccountNumber.Name = "txt_AddAccount_AccountNumber";
            this.txt_AddAccount_AccountNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_AddAccount_AccountNumber.PlaceholderText = "   Account Number";
            this.txt_AddAccount_AccountNumber.SelectedText = "";
            this.txt_AddAccount_AccountNumber.Size = new System.Drawing.Size(581, 69);
            this.txt_AddAccount_AccountNumber.TabIndex = 126;
            this.txt_AddAccount_AccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AddAccount_AccountNumber_Validating);
            // 
            // txt_Balance_AddAccount
            // 
            this.txt_Balance_AddAccount.AutoRoundedCorners = true;
            this.txt_Balance_AddAccount.BorderRadius = 33;
            this.txt_Balance_AddAccount.BorderThickness = 0;
            this.txt_Balance_AddAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Balance_AddAccount.DefaultText = "";
            this.txt_Balance_AddAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Balance_AddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Balance_AddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Balance_AddAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Balance_AddAccount.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Balance_AddAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Balance_AddAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Balance_AddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_Balance_AddAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Balance_AddAccount.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.money_100;
            this.txt_Balance_AddAccount.Location = new System.Drawing.Point(615, 251);
            this.txt_Balance_AddAccount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Balance_AddAccount.Name = "txt_Balance_AddAccount";
            this.txt_Balance_AddAccount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Balance_AddAccount.PlaceholderText = "   Balance";
            this.txt_Balance_AddAccount.SelectedText = "";
            this.txt_Balance_AddAccount.Size = new System.Drawing.Size(581, 69);
            this.txt_Balance_AddAccount.TabIndex = 125;
            this.txt_Balance_AddAccount.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Balance_AddAccount_Validating);
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
            this.btn_MainMenu.Location = new System.Drawing.Point(95, 603);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(131, 43);
            this.btn_MainMenu.TabIndex = 134;
            this.btn_MainMenu.Text = "Home";
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.AutoRoundedCorners = true;
            this.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_Back.Image = global::MyBankSystemManagmentProject.Properties.Resources.back3_100;
            this.btn_Back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Back.Location = new System.Drawing.Point(95, 652);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 43);
            this.btn_Back.TabIndex = 133;
            this.btn_Back.Text = "Back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_AddNewAccount
            // 
            this.btn_AddNewAccount.AutoRoundedCorners = true;
            this.btn_AddNewAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddNewAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddNewAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddNewAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddNewAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_AddNewAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewAccount.ForeColor = System.Drawing.Color.White;
            this.btn_AddNewAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_AddNewAccount.Location = new System.Drawing.Point(706, 627);
            this.btn_AddNewAccount.Name = "btn_AddNewAccount";
            this.btn_AddNewAccount.Size = new System.Drawing.Size(382, 45);
            this.btn_AddNewAccount.TabIndex = 135;
            this.btn_AddNewAccount.Text = "Add";
            this.btn_AddNewAccount.Click += new System.EventHandler(this.btn_AddNewAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AddNewAccount);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.cb_Currency);
            this.Controls.Add(this.cb_CreditCardNetwork);
            this.Controls.Add(this.cb_CreditCardType);
            this.Controls.Add(this.cb_AccountType);
            this.Controls.Add(this.txt_AddAccount_NationalID);
            this.Controls.Add(this.Txt_CreditPassword_AddAccount);
            this.Controls.Add(this.txt_AddAccount_AccountNumber);
            this.Controls.Add(this.txt_Balance_AddAccount);
            this.Name = "ctrAddNewAccount";
            this.Size = new System.Drawing.Size(1451, 750);
            this.Load += new System.EventHandler(this.ctrAddNewAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cb_Currency;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CreditCardNetwork;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CreditCardType;
        private Guna.UI2.WinForms.Guna2ComboBox cb_AccountType;
        private Guna.UI2.WinForms.Guna2TextBox txt_AddAccount_NationalID;
        private Guna.UI2.WinForms.Guna2TextBox Txt_CreditPassword_AddAccount;
        private Guna.UI2.WinForms.Guna2TextBox txt_AddAccount_AccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_Balance_AddAccount;
        private Guna.UI2.WinForms.Guna2Button btn_MainMenu;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
        private Guna.UI2.WinForms.Guna2Button btn_AddNewAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
