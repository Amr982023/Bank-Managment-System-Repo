namespace MyBankSystemManagmentProject
{
    partial class ctrAddNewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddNewClient));
            this.lbl_AddNewClients = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save_AddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.ll_ChangePhoto = new System.Windows.Forms.LinkLabel();
            this.ll_RemovePhoto = new System.Windows.Forms.LinkLabel();
            this.cb_Country = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_AccountType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_CreditCardType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_CreditCardNetwork = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_ClientType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_Currency = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txt_Phone2_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_AddClient_NationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_AddClient_Street = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_AddClient_City = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ThirdName_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SecondName_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_FirstName_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Back_AddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_CreditPassword_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_AddClient_AccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Balance_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Phone1_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_LastName_AddClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_Male = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AddNewClients
            // 
            this.lbl_AddNewClients.AutoSize = true;
            this.lbl_AddNewClients.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddNewClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_AddNewClients.Location = new System.Drawing.Point(563, 0);
            this.lbl_AddNewClients.Name = "lbl_AddNewClients";
            this.lbl_AddNewClients.Size = new System.Drawing.Size(382, 65);
            this.lbl_AddNewClients.TabIndex = 86;
            this.lbl_AddNewClients.Text = "Add New Client";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label2.Location = new System.Drawing.Point(100, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 109;
            this.label2.Text = "Date Of birth";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.White;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.DateTimePicker.ForeColor = System.Drawing.Color.DimGray;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(105, 573);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(293, 56);
            this.DateTimePicker.TabIndex = 108;
            this.DateTimePicker.Value = new System.DateTime(2025, 8, 30, 15, 42, 28, 555);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 45);
            this.label1.TabIndex = 105;
            this.label1.Text = "Client Info";
            // 
            // btn_Save_AddNewClient
            // 
            this.btn_Save_AddNewClient.AutoRoundedCorners = true;
            this.btn_Save_AddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save_AddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save_AddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save_AddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save_AddNewClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Save_AddNewClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_AddNewClient.ForeColor = System.Drawing.Color.White;
            this.btn_Save_AddNewClient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_Save_AddNewClient.Location = new System.Drawing.Point(1122, 688);
            this.btn_Save_AddNewClient.Name = "btn_Save_AddNewClient";
            this.btn_Save_AddNewClient.Size = new System.Drawing.Size(180, 45);
            this.btn_Save_AddNewClient.TabIndex = 102;
            this.btn_Save_AddNewClient.Text = "Save";
            this.btn_Save_AddNewClient.Click += new System.EventHandler(this.btn_Save_AddNewClient_Click);
            // 
            // ll_ChangePhoto
            // 
            this.ll_ChangePhoto.AutoSize = true;
            this.ll_ChangePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_ChangePhoto.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ll_ChangePhoto.Location = new System.Drawing.Point(944, 487);
            this.ll_ChangePhoto.Name = "ll_ChangePhoto";
            this.ll_ChangePhoto.Size = new System.Drawing.Size(140, 24);
            this.ll_ChangePhoto.TabIndex = 95;
            this.ll_ChangePhoto.TabStop = true;
            this.ll_ChangePhoto.Text = "Change Picture";
            this.ll_ChangePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ChangePhoto_LinkClicked);
            // 
            // ll_RemovePhoto
            // 
            this.ll_RemovePhoto.AutoSize = true;
            this.ll_RemovePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_RemovePhoto.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ll_RemovePhoto.Location = new System.Drawing.Point(1158, 487);
            this.ll_RemovePhoto.Name = "ll_RemovePhoto";
            this.ll_RemovePhoto.Size = new System.Drawing.Size(144, 24);
            this.ll_RemovePhoto.TabIndex = 94;
            this.ll_RemovePhoto.TabStop = true;
            this.ll_RemovePhoto.Text = "Remove Picture";
            this.ll_RemovePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_RemovePhoto_LinkClicked_1);
            // 
            // cb_Country
            // 
            this.cb_Country.AutoRoundedCorners = true;
            this.cb_Country.BackColor = System.Drawing.Color.Transparent;
            this.cb_Country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Country.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Country.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Country.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Country.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_Country.ForeColor = System.Drawing.Color.Gray;
            this.cb_Country.ItemHeight = 30;
            this.cb_Country.Location = new System.Drawing.Point(105, 639);
            this.cb_Country.Name = "cb_Country";
            this.cb_Country.Size = new System.Drawing.Size(486, 36);
            this.cb_Country.TabIndex = 118;
            this.cb_Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_Country.Validating += new System.ComponentModel.CancelEventHandler(this.cb_Country_Validating);
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
            this.cb_AccountType.Location = new System.Drawing.Point(353, 303);
            this.cb_AccountType.Name = "cb_AccountType";
            this.cb_AccountType.Size = new System.Drawing.Size(238, 36);
            this.cb_AccountType.StartIndex = 0;
            this.cb_AccountType.TabIndex = 120;
            this.cb_AccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_AccountType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_AccountType_Validating);
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
            this.cb_CreditCardType.Location = new System.Drawing.Point(105, 349);
            this.cb_CreditCardType.Name = "cb_CreditCardType";
            this.cb_CreditCardType.Size = new System.Drawing.Size(238, 36);
            this.cb_CreditCardType.TabIndex = 121;
            this.cb_CreditCardType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_CreditCardType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_CreditCardType_Validating);
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
            this.cb_CreditCardNetwork.Location = new System.Drawing.Point(353, 348);
            this.cb_CreditCardNetwork.Name = "cb_CreditCardNetwork";
            this.cb_CreditCardNetwork.Size = new System.Drawing.Size(238, 36);
            this.cb_CreditCardNetwork.TabIndex = 122;
            this.cb_CreditCardNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_CreditCardNetwork.Validating += new System.ComponentModel.CancelEventHandler(this.cb_CreditCardNetwork_Validating);
            // 
            // cb_ClientType
            // 
            this.cb_ClientType.AutoRoundedCorners = true;
            this.cb_ClientType.BackColor = System.Drawing.Color.Transparent;
            this.cb_ClientType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ClientType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cb_ClientType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ClientType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ClientType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cb_ClientType.ForeColor = System.Drawing.Color.Gray;
            this.cb_ClientType.ItemHeight = 30;
            this.cb_ClientType.Items.AddRange(new object[] {
            "Client Type",
            "Individual",
            "Company",
            "VIP",
            "Government"});
            this.cb_ClientType.Location = new System.Drawing.Point(105, 487);
            this.cb_ClientType.Name = "cb_ClientType";
            this.cb_ClientType.Size = new System.Drawing.Size(238, 36);
            this.cb_ClientType.TabIndex = 123;
            this.cb_ClientType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_ClientType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_ClientType_Validating);
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
            this.cb_Currency.Location = new System.Drawing.Point(351, 487);
            this.cb_Currency.Name = "cb_Currency";
            this.cb_Currency.Size = new System.Drawing.Size(239, 36);
            this.cb_Currency.TabIndex = 124;
            this.cb_Currency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cb_Currency.Validating += new System.ComponentModel.CancelEventHandler(this.cb_Currency_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyBankSystemManagmentProject.Properties.Resources.unknown_icon;
            this.pictureBox1.ImageRotate = 0F;
            this.pictureBox1.Location = new System.Drawing.Point(948, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox1.Size = new System.Drawing.Size(354, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Phone2_AddClient
            // 
            this.txt_Phone2_AddClient.AutoRoundedCorners = true;
            this.txt_Phone2_AddClient.BorderRadius = 17;
            this.txt_Phone2_AddClient.BorderThickness = 0;
            this.txt_Phone2_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone2_AddClient.DefaultText = "";
            this.txt_Phone2_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone2_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone2_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone2_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone2_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Phone2_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone2_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone2_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_Phone2_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone2_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.phone_100;
            this.txt_Phone2_AddClient.Location = new System.Drawing.Point(352, 211);
            this.txt_Phone2_AddClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Phone2_AddClient.Name = "txt_Phone2_AddClient";
            this.txt_Phone2_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Phone2_AddClient.PlaceholderText = "   Phone 2";
            this.txt_Phone2_AddClient.SelectedText = "";
            this.txt_Phone2_AddClient.Size = new System.Drawing.Size(237, 36);
            this.txt_Phone2_AddClient.TabIndex = 125;
            this.txt_Phone2_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Phone2_AddClient_Validating);
            // 
            // txt_AddClient_NationalID
            // 
            this.txt_AddClient_NationalID.AutoRoundedCorners = true;
            this.txt_AddClient_NationalID.BorderRadius = 17;
            this.txt_AddClient_NationalID.BorderThickness = 0;
            this.txt_AddClient_NationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddClient_NationalID.DefaultText = "";
            this.txt_AddClient_NationalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AddClient_NationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AddClient_NationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_NationalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_NationalID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_AddClient_NationalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_NationalID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddClient_NationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_AddClient_NationalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_NationalID.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_AddClient_NationalID.IconLeft")));
            this.txt_AddClient_NationalID.Location = new System.Drawing.Point(105, 441);
            this.txt_AddClient_NationalID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AddClient_NationalID.Name = "txt_AddClient_NationalID";
            this.txt_AddClient_NationalID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_AddClient_NationalID.PlaceholderText = "   National ID";
            this.txt_AddClient_NationalID.SelectedText = "";
            this.txt_AddClient_NationalID.Size = new System.Drawing.Size(485, 36);
            this.txt_AddClient_NationalID.TabIndex = 117;
            this.txt_AddClient_NationalID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AddClient_NationalID_Validating);
            // 
            // txt_AddClient_Street
            // 
            this.txt_AddClient_Street.AutoRoundedCorners = true;
            this.txt_AddClient_Street.BorderRadius = 17;
            this.txt_AddClient_Street.BorderThickness = 0;
            this.txt_AddClient_Street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddClient_Street.DefaultText = "";
            this.txt_AddClient_Street.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AddClient_Street.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AddClient_Street.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_Street.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_Street.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_AddClient_Street.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_Street.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddClient_Street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_AddClient_Street.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_Street.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_AddClient_Street.IconLeft")));
            this.txt_AddClient_Street.Location = new System.Drawing.Point(353, 687);
            this.txt_AddClient_Street.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AddClient_Street.Name = "txt_AddClient_Street";
            this.txt_AddClient_Street.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_AddClient_Street.PlaceholderText = "    Street";
            this.txt_AddClient_Street.SelectedText = "";
            this.txt_AddClient_Street.Size = new System.Drawing.Size(238, 36);
            this.txt_AddClient_Street.TabIndex = 116;
            this.txt_AddClient_Street.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AddClient_Street_Validating);
            // 
            // txt_AddClient_City
            // 
            this.txt_AddClient_City.AutoRoundedCorners = true;
            this.txt_AddClient_City.BorderRadius = 17;
            this.txt_AddClient_City.BorderThickness = 0;
            this.txt_AddClient_City.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddClient_City.DefaultText = "";
            this.txt_AddClient_City.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AddClient_City.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AddClient_City.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_City.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_City.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_AddClient_City.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_City.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddClient_City.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_AddClient_City.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_City.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_AddClient_City.IconLeft")));
            this.txt_AddClient_City.Location = new System.Drawing.Point(105, 688);
            this.txt_AddClient_City.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AddClient_City.Name = "txt_AddClient_City";
            this.txt_AddClient_City.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_AddClient_City.PlaceholderText = "   City";
            this.txt_AddClient_City.SelectedText = "";
            this.txt_AddClient_City.Size = new System.Drawing.Size(238, 36);
            this.txt_AddClient_City.TabIndex = 113;
            this.txt_AddClient_City.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AddClient_City_Validating);
            // 
            // txt_ThirdName_AddClient
            // 
            this.txt_ThirdName_AddClient.AutoRoundedCorners = true;
            this.txt_ThirdName_AddClient.BorderRadius = 17;
            this.txt_ThirdName_AddClient.BorderThickness = 0;
            this.txt_ThirdName_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThirdName_AddClient.DefaultText = "";
            this.txt_ThirdName_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ThirdName_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ThirdName_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThirdName_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThirdName_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ThirdName_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThirdName_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThirdName_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_ThirdName_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThirdName_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.name_tag_50;
            this.txt_ThirdName_AddClient.Location = new System.Drawing.Point(105, 119);
            this.txt_ThirdName_AddClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_ThirdName_AddClient.Name = "txt_ThirdName_AddClient";
            this.txt_ThirdName_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_ThirdName_AddClient.PlaceholderText = "   Third Name";
            this.txt_ThirdName_AddClient.SelectedText = "";
            this.txt_ThirdName_AddClient.Size = new System.Drawing.Size(238, 36);
            this.txt_ThirdName_AddClient.TabIndex = 107;
            this.txt_ThirdName_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ThirdName_AddClient_Validating);
            // 
            // txt_SecondName_AddClient
            // 
            this.txt_SecondName_AddClient.AutoRoundedCorners = true;
            this.txt_SecondName_AddClient.BorderRadius = 17;
            this.txt_SecondName_AddClient.BorderThickness = 0;
            this.txt_SecondName_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SecondName_AddClient.DefaultText = "";
            this.txt_SecondName_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SecondName_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SecondName_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SecondName_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SecondName_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SecondName_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SecondName_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SecondName_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_SecondName_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SecondName_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.name_tag_50;
            this.txt_SecondName_AddClient.Location = new System.Drawing.Point(352, 73);
            this.txt_SecondName_AddClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_SecondName_AddClient.Name = "txt_SecondName_AddClient";
            this.txt_SecondName_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_SecondName_AddClient.PlaceholderText = "   Second Name";
            this.txt_SecondName_AddClient.SelectedText = "";
            this.txt_SecondName_AddClient.Size = new System.Drawing.Size(238, 36);
            this.txt_SecondName_AddClient.TabIndex = 106;
            this.txt_SecondName_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_SecondName_AddClient_Validating);
            // 
            // txt_FirstName_AddClient
            // 
            this.txt_FirstName_AddClient.AutoRoundedCorners = true;
            this.txt_FirstName_AddClient.BorderRadius = 17;
            this.txt_FirstName_AddClient.BorderThickness = 0;
            this.txt_FirstName_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FirstName_AddClient.DefaultText = "";
            this.txt_FirstName_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_FirstName_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_FirstName_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FirstName_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_FirstName_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_FirstName_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FirstName_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_FirstName_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_FirstName_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.name_tag_50;
            this.txt_FirstName_AddClient.Location = new System.Drawing.Point(105, 73);
            this.txt_FirstName_AddClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FirstName_AddClient.Name = "txt_FirstName_AddClient";
            this.txt_FirstName_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_FirstName_AddClient.PlaceholderText = "   First Name";
            this.txt_FirstName_AddClient.SelectedText = "";
            this.txt_FirstName_AddClient.Size = new System.Drawing.Size(238, 36);
            this.txt_FirstName_AddClient.TabIndex = 104;
            this.txt_FirstName_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_FirstName_AddClient_Validating);
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
            this.btn_Back_AddNewClient.Location = new System.Drawing.Point(779, 686);
            this.btn_Back_AddNewClient.Name = "btn_Back_AddNewClient";
            this.btn_Back_AddNewClient.Size = new System.Drawing.Size(180, 45);
            this.btn_Back_AddNewClient.TabIndex = 103;
            this.btn_Back_AddNewClient.Text = "Back";
            this.btn_Back_AddNewClient.Click += new System.EventHandler(this.btn_Back_AddNewClient_Click_1);
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
            this.Txt_CreditPassword_AddClient.Location = new System.Drawing.Point(105, 395);
            this.Txt_CreditPassword_AddClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_CreditPassword_AddClient.Name = "Txt_CreditPassword_AddClient";
            this.Txt_CreditPassword_AddClient.PasswordChar = '*';
            this.Txt_CreditPassword_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Txt_CreditPassword_AddClient.PlaceholderText = "Credit Card Password";
            this.Txt_CreditPassword_AddClient.SelectedText = "";
            this.Txt_CreditPassword_AddClient.Size = new System.Drawing.Size(486, 36);
            this.Txt_CreditPassword_AddClient.TabIndex = 101;
            this.Txt_CreditPassword_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_CreditPassword_AddClient_Validating);
            // 
            // txt_AddClient_AccountNumber
            // 
            this.txt_AddClient_AccountNumber.AutoRoundedCorners = true;
            this.txt_AddClient_AccountNumber.BorderRadius = 17;
            this.txt_AddClient_AccountNumber.BorderThickness = 0;
            this.txt_AddClient_AccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AddClient_AccountNumber.DefaultText = "";
            this.txt_AddClient_AccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AddClient_AccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AddClient_AccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_AccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AddClient_AccountNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_AddClient_AccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_AccountNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddClient_AccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_AddClient_AccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AddClient_AccountNumber.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.user;
            this.txt_AddClient_AccountNumber.Location = new System.Drawing.Point(105, 303);
            this.txt_AddClient_AccountNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AddClient_AccountNumber.Name = "txt_AddClient_AccountNumber";
            this.txt_AddClient_AccountNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_AddClient_AccountNumber.PlaceholderText = "   Account Number";
            this.txt_AddClient_AccountNumber.SelectedText = "";
            this.txt_AddClient_AccountNumber.Size = new System.Drawing.Size(238, 36);
            this.txt_AddClient_AccountNumber.TabIndex = 100;
            this.txt_AddClient_AccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_AddClient_AccountNumber_Validating_1);
            // 
            // txt_Balance_AddClient
            // 
            this.txt_Balance_AddClient.AutoRoundedCorners = true;
            this.txt_Balance_AddClient.BorderRadius = 17;
            this.txt_Balance_AddClient.BorderThickness = 0;
            this.txt_Balance_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Balance_AddClient.DefaultText = "";
            this.txt_Balance_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Balance_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Balance_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Balance_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Balance_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Balance_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Balance_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Balance_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_Balance_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Balance_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.money_100;
            this.txt_Balance_AddClient.Location = new System.Drawing.Point(105, 257);
            this.txt_Balance_AddClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Balance_AddClient.Name = "txt_Balance_AddClient";
            this.txt_Balance_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Balance_AddClient.PlaceholderText = "   Balance";
            this.txt_Balance_AddClient.SelectedText = "";
            this.txt_Balance_AddClient.Size = new System.Drawing.Size(485, 36);
            this.txt_Balance_AddClient.TabIndex = 99;
            this.txt_Balance_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Balance_AddClient_Validating);
            // 
            // txt_Phone1_AddClient
            // 
            this.txt_Phone1_AddClient.AutoRoundedCorners = true;
            this.txt_Phone1_AddClient.BorderRadius = 17;
            this.txt_Phone1_AddClient.BorderThickness = 0;
            this.txt_Phone1_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone1_AddClient.DefaultText = "";
            this.txt_Phone1_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone1_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone1_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone1_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone1_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Phone1_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone1_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone1_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_Phone1_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone1_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.phone_100;
            this.txt_Phone1_AddClient.Location = new System.Drawing.Point(105, 211);
            this.txt_Phone1_AddClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Phone1_AddClient.Name = "txt_Phone1_AddClient";
            this.txt_Phone1_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Phone1_AddClient.PlaceholderText = "   Phone";
            this.txt_Phone1_AddClient.SelectedText = "";
            this.txt_Phone1_AddClient.Size = new System.Drawing.Size(238, 36);
            this.txt_Phone1_AddClient.TabIndex = 98;
            this.txt_Phone1_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Phone_AddClient_Validating);
            // 
            // txt_Email_AddClient
            // 
            this.txt_Email_AddClient.AutoRoundedCorners = true;
            this.txt_Email_AddClient.BorderRadius = 17;
            this.txt_Email_AddClient.BorderThickness = 0;
            this.txt_Email_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email_AddClient.DefaultText = "";
            this.txt_Email_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Email_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_Email_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.Email;
            this.txt_Email_AddClient.Location = new System.Drawing.Point(105, 165);
            this.txt_Email_AddClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Email_AddClient.Name = "txt_Email_AddClient";
            this.txt_Email_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Email_AddClient.PlaceholderText = "   Email";
            this.txt_Email_AddClient.SelectedText = "";
            this.txt_Email_AddClient.Size = new System.Drawing.Size(485, 36);
            this.txt_Email_AddClient.TabIndex = 97;
            this.txt_Email_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Email_AddClient_Validating);
            // 
            // txt_LastName_AddClient
            // 
            this.txt_LastName_AddClient.AutoRoundedCorners = true;
            this.txt_LastName_AddClient.BorderRadius = 17;
            this.txt_LastName_AddClient.BorderThickness = 0;
            this.txt_LastName_AddClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LastName_AddClient.DefaultText = "";
            this.txt_LastName_AddClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LastName_AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LastName_AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LastName_AddClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LastName_AddClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_LastName_AddClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LastName_AddClient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName_AddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_LastName_AddClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LastName_AddClient.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.name_tag_50;
            this.txt_LastName_AddClient.Location = new System.Drawing.Point(352, 119);
            this.txt_LastName_AddClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_LastName_AddClient.Name = "txt_LastName_AddClient";
            this.txt_LastName_AddClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_LastName_AddClient.PlaceholderText = "   Last Name";
            this.txt_LastName_AddClient.SelectedText = "";
            this.txt_LastName_AddClient.Size = new System.Drawing.Size(238, 36);
            this.txt_LastName_AddClient.TabIndex = 96;
            this.txt_LastName_AddClient.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LastName_AddClient_Validating);
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(402, 540);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(187, 89);
            this.gb_Gender.TabIndex = 208;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_Female.CheckedState.BorderThickness = 0;
            this.rb_Female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_Female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_Female.CheckedState.InnerOffset = -4;
            this.rb_Female.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(89, 34);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(97, 34);
            this.rb_Female.TabIndex = 205;
            this.rb_Female.Text = "Female";
            this.rb_Female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_Female.UncheckedState.BorderThickness = 2;
            this.rb_Female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_Female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_Male.CheckedState.BorderThickness = 0;
            this.rb_Male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_Male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_Male.CheckedState.InnerOffset = -4;
            this.rb_Male.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(6, 34);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(77, 34);
            this.rb_Male.TabIndex = 204;
            this.rb_Male.Text = "Male";
            this.rb_Male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_Male.UncheckedState.BorderThickness = 2;
            this.rb_Male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_Male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ctrAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Phone2_AddClient);
            this.Controls.Add(this.cb_Currency);
            this.Controls.Add(this.cb_ClientType);
            this.Controls.Add(this.cb_CreditCardNetwork);
            this.Controls.Add(this.cb_CreditCardType);
            this.Controls.Add(this.cb_AccountType);
            this.Controls.Add(this.cb_Country);
            this.Controls.Add(this.txt_AddClient_NationalID);
            this.Controls.Add(this.txt_AddClient_Street);
            this.Controls.Add(this.txt_AddClient_City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.txt_ThirdName_AddClient);
            this.Controls.Add(this.txt_SecondName_AddClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_FirstName_AddClient);
            this.Controls.Add(this.btn_Back_AddNewClient);
            this.Controls.Add(this.btn_Save_AddNewClient);
            this.Controls.Add(this.Txt_CreditPassword_AddClient);
            this.Controls.Add(this.txt_AddClient_AccountNumber);
            this.Controls.Add(this.txt_Balance_AddClient);
            this.Controls.Add(this.txt_Phone1_AddClient);
            this.Controls.Add(this.txt_Email_AddClient);
            this.Controls.Add(this.txt_LastName_AddClient);
            this.Controls.Add(this.ll_ChangePhoto);
            this.Controls.Add(this.ll_RemovePhoto);
            this.Controls.Add(this.lbl_AddNewClients);
            this.Name = "ctrAddNewClient";
            this.Size = new System.Drawing.Size(1451, 750);
            this.Load += new System.EventHandler(this.ctrAddNewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_AddNewClients;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2TextBox txt_ThirdName_AddClient;
        private Guna.UI2.WinForms.Guna2TextBox txt_SecondName_AddClient;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_FirstName_AddClient;
        private Guna.UI2.WinForms.Guna2Button btn_Back_AddNewClient;
        private Guna.UI2.WinForms.Guna2Button btn_Save_AddNewClient;
        private Guna.UI2.WinForms.Guna2TextBox Txt_CreditPassword_AddClient;
        private Guna.UI2.WinForms.Guna2TextBox txt_AddClient_AccountNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_Balance_AddClient;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone1_AddClient;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email_AddClient;
        private Guna.UI2.WinForms.Guna2TextBox txt_LastName_AddClient;
        private System.Windows.Forms.LinkLabel ll_ChangePhoto;
        private System.Windows.Forms.LinkLabel ll_RemovePhoto;
        private Guna.UI2.WinForms.Guna2TextBox txt_AddClient_Street;
        private Guna.UI2.WinForms.Guna2TextBox txt_AddClient_City;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Country;
        private Guna.UI2.WinForms.Guna2TextBox txt_AddClient_NationalID;
        private Guna.UI2.WinForms.Guna2ComboBox cb_AccountType;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CreditCardType;
        private Guna.UI2.WinForms.Guna2ComboBox cb_CreditCardNetwork;
        private Guna.UI2.WinForms.Guna2ComboBox cb_ClientType;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Currency;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone2_AddClient;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_Gender;
        private Guna.UI2.WinForms.Guna2RadioButton rb_Female;
        private Guna.UI2.WinForms.Guna2RadioButton rb_Male;
    }
}
