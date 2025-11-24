namespace MyBankSystemManagmentProject
{
    partial class ctrCreditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrCreditCard));
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_CardType = new System.Windows.Forms.Label();
            this.lbl_BankName = new System.Windows.Forms.Label();
            this.lbl_ValidThru = new System.Windows.Forms.Label();
            this.lbl_ExpireDate = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.lbl_CardNumber = new System.Windows.Forms.Label();
            this.pb_Network = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb_Card = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_MainMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Activate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Deactivate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Panel_Status = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reissue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Renew = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pb_NotFound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Network)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card)).BeginInit();
            this.Panel_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NotFound)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.Location = new System.Drawing.Point(6, 124);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Search.PlaceholderText = "Search By Account Number . . .";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(712, 44);
            this.txt_Search.TabIndex = 48;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Title.Location = new System.Drawing.Point(525, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(405, 86);
            this.lbl_Title.TabIndex = 47;
            this.lbl_Title.Text = "Credit Cards";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_CardType
            // 
            this.lbl_CardType.AutoSize = true;
            this.lbl_CardType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CardType.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CardType.ForeColor = System.Drawing.Color.White;
            this.lbl_CardType.Location = new System.Drawing.Point(15, 30);
            this.lbl_CardType.Name = "lbl_CardType";
            this.lbl_CardType.Size = new System.Drawing.Size(190, 45);
            this.lbl_CardType.TabIndex = 50;
            this.lbl_CardType.Text = "Credit card";
            // 
            // lbl_BankName
            // 
            this.lbl_BankName.AutoSize = true;
            this.lbl_BankName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BankName.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BankName.ForeColor = System.Drawing.Color.White;
            this.lbl_BankName.Location = new System.Drawing.Point(420, 20);
            this.lbl_BankName.Name = "lbl_BankName";
            this.lbl_BankName.Size = new System.Drawing.Size(116, 30);
            this.lbl_BankName.TabIndex = 51;
            this.lbl_BankName.Text = "Amr Bank";
            // 
            // lbl_ValidThru
            // 
            this.lbl_ValidThru.AutoSize = true;
            this.lbl_ValidThru.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ValidThru.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValidThru.ForeColor = System.Drawing.Color.White;
            this.lbl_ValidThru.Location = new System.Drawing.Point(365, 230);
            this.lbl_ValidThru.Name = "lbl_ValidThru";
            this.lbl_ValidThru.Size = new System.Drawing.Size(78, 16);
            this.lbl_ValidThru.TabIndex = 52;
            this.lbl_ValidThru.Text = "VALID THRU";
            // 
            // lbl_ExpireDate
            // 
            this.lbl_ExpireDate.AutoSize = true;
            this.lbl_ExpireDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ExpireDate.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpireDate.ForeColor = System.Drawing.Color.White;
            this.lbl_ExpireDate.Location = new System.Drawing.Point(370, 250);
            this.lbl_ExpireDate.Name = "lbl_ExpireDate";
            this.lbl_ExpireDate.Size = new System.Drawing.Size(64, 26);
            this.lbl_ExpireDate.TabIndex = 53;
            this.lbl_ExpireDate.Text = "05/24";
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.ForeColor = System.Drawing.Color.White;
            this.lbl_CustomerName.Location = new System.Drawing.Point(20, 280);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(187, 30);
            this.lbl_CustomerName.TabIndex = 54;
            this.lbl_CustomerName.Text = "Customer Name";
            // 
            // lbl_CardNumber
            // 
            this.lbl_CardNumber.AutoSize = true;
            this.lbl_CardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CardNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CardNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_CardNumber.Location = new System.Drawing.Point(80, 180);
            this.lbl_CardNumber.Name = "lbl_CardNumber";
            this.lbl_CardNumber.Size = new System.Drawing.Size(444, 45);
            this.lbl_CardNumber.TabIndex = 55;
            this.lbl_CardNumber.Text = "5623    2563    6523    9802";
            // 
            // pb_Network
            // 
            this.pb_Network.BackColor = System.Drawing.Color.Transparent;
            this.pb_Network.Image = global::MyBankSystemManagmentProject.Properties.Resources.visaLogo;
            this.pb_Network.ImageRotate = 0F;
            this.pb_Network.Location = new System.Drawing.Point(450, 260);
            this.pb_Network.Name = "pb_Network";
            this.pb_Network.Size = new System.Drawing.Size(107, 77);
            this.pb_Network.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Network.TabIndex = 56;
            this.pb_Network.TabStop = false;
            // 
            // pb_Card
            // 
            this.pb_Card.Image = ((System.Drawing.Image)(resources.GetObject("pb_Card.Image")));
            this.pb_Card.ImageRotate = 0F;
            this.pb_Card.Location = new System.Drawing.Point(67, 270);
            this.pb_Card.Name = "pb_Card";
            this.pb_Card.Size = new System.Drawing.Size(582, 337);
            this.pb_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Card.TabIndex = 49;
            this.pb_Card.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Animated = true;
            this.btn_Search.AutoRoundedCorners = true;
            this.btn_Search.BorderRadius = 25;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Search.FillColor2 = System.Drawing.Color.Gray;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Search.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Search.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Search.Location = new System.Drawing.Point(753, 115);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(133, 53);
            this.btn_Search.TabIndex = 57;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.btn_MainMenu.TabIndex = 60;
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
            this.btn_Back.Location = new System.Drawing.Point(88, 691);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 43);
            this.btn_Back.TabIndex = 59;
            this.btn_Back.Text = "Back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Activate
            // 
            this.btn_Activate.Animated = true;
            this.btn_Activate.AnimatedGIF = true;
            this.btn_Activate.AutoRoundedCorners = true;
            this.btn_Activate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Activate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Activate.BorderRadius = 34;
            this.btn_Activate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Activate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Activate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Activate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Activate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Activate.FillColor = System.Drawing.Color.SeaGreen;
            this.btn_Activate.FillColor2 = System.Drawing.Color.DarkOliveGreen;
            this.btn_Activate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activate.ForeColor = System.Drawing.Color.White;
            this.btn_Activate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Activate.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Activate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Activate.Image")));
            this.btn_Activate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Activate.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Activate.Location = new System.Drawing.Point(953, 491);
            this.btn_Activate.Name = "btn_Activate";
            this.btn_Activate.Size = new System.Drawing.Size(205, 71);
            this.btn_Activate.TabIndex = 63;
            this.btn_Activate.Text = "      Activate";
            this.btn_Activate.UseTransparentBackground = true;
            this.btn_Activate.Click += new System.EventHandler(this.btn_Activate_Click);
            // 
            // btn_Deactivate
            // 
            this.btn_Deactivate.Animated = true;
            this.btn_Deactivate.AnimatedGIF = true;
            this.btn_Deactivate.AutoRoundedCorners = true;
            this.btn_Deactivate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Deactivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Deactivate.BorderRadius = 34;
            this.btn_Deactivate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Deactivate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Deactivate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Deactivate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Deactivate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Deactivate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Deactivate.FillColor2 = System.Drawing.Color.IndianRed;
            this.btn_Deactivate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deactivate.ForeColor = System.Drawing.Color.White;
            this.btn_Deactivate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Deactivate.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Deactivate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deactivate.Image")));
            this.btn_Deactivate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Deactivate.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Deactivate.Location = new System.Drawing.Point(1176, 491);
            this.btn_Deactivate.Name = "btn_Deactivate";
            this.btn_Deactivate.Size = new System.Drawing.Size(205, 71);
            this.btn_Deactivate.TabIndex = 64;
            this.btn_Deactivate.Text = "  Deactivate";
            this.btn_Deactivate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Deactivate.UseTransparentBackground = true;
            this.btn_Deactivate.Click += new System.EventHandler(this.btn_Deactivate_Click);
            // 
            // Panel_Status
            // 
            this.Panel_Status.Controls.Add(this.lbl_Status);
            this.Panel_Status.Controls.Add(this.label1);
            this.Panel_Status.Location = new System.Drawing.Point(908, 371);
            this.Panel_Status.Name = "Panel_Status";
            this.Panel_Status.Size = new System.Drawing.Size(498, 102);
            this.Panel_Status.TabIndex = 65;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Status.Location = new System.Drawing.Point(154, 31);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(124, 45);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status : ";
            // 
            // btn_Reissue
            // 
            this.btn_Reissue.Animated = true;
            this.btn_Reissue.AnimatedGIF = true;
            this.btn_Reissue.AutoRoundedCorners = true;
            this.btn_Reissue.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reissue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reissue.BorderRadius = 34;
            this.btn_Reissue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reissue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reissue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reissue.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reissue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reissue.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_Reissue.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.btn_Reissue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reissue.ForeColor = System.Drawing.Color.White;
            this.btn_Reissue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Reissue.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Reissue.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reissue.Image")));
            this.btn_Reissue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Reissue.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Reissue.Location = new System.Drawing.Point(953, 587);
            this.btn_Reissue.Name = "btn_Reissue";
            this.btn_Reissue.Size = new System.Drawing.Size(205, 71);
            this.btn_Reissue.TabIndex = 66;
            this.btn_Reissue.Text = "     Reissue";
            this.btn_Reissue.UseTransparentBackground = true;
            this.btn_Reissue.Click += new System.EventHandler(this.btn_Reissue_Click);
            // 
            // btn_Renew
            // 
            this.btn_Renew.Animated = true;
            this.btn_Renew.AnimatedGIF = true;
            this.btn_Renew.AutoRoundedCorners = true;
            this.btn_Renew.BackColor = System.Drawing.Color.Transparent;
            this.btn_Renew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Renew.BorderRadius = 34;
            this.btn_Renew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Renew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Renew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Renew.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Renew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Renew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Renew.FillColor2 = System.Drawing.Color.Gray;
            this.btn_Renew.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Renew.ForeColor = System.Drawing.Color.White;
            this.btn_Renew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Renew.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.btn_Renew.Image = ((System.Drawing.Image)(resources.GetObject("btn_Renew.Image")));
            this.btn_Renew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Renew.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Renew.Location = new System.Drawing.Point(1176, 587);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(205, 71);
            this.btn_Renew.TabIndex = 67;
            this.btn_Renew.Text = "     Renew";
            this.btn_Renew.UseTransparentBackground = true;
            this.btn_Renew.Click += new System.EventHandler(this.btn_Renew_Click);
            // 
            // pb_NotFound
            // 
            this.pb_NotFound.Image = ((System.Drawing.Image)(resources.GetObject("pb_NotFound.Image")));
            this.pb_NotFound.Location = new System.Drawing.Point(353, 180);
            this.pb_NotFound.Name = "pb_NotFound";
            this.pb_NotFound.Size = new System.Drawing.Size(765, 483);
            this.pb_NotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NotFound.TabIndex = 68;
            this.pb_NotFound.TabStop = false;
            // 
            // ctrCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Renew);
            this.Controls.Add(this.btn_Reissue);
            this.Controls.Add(this.Panel_Status);
            this.Controls.Add(this.btn_Deactivate);
            this.Controls.Add(this.btn_Activate);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.pb_Network);
            this.Controls.Add(this.lbl_CardNumber);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_ExpireDate);
            this.Controls.Add(this.lbl_ValidThru);
            this.Controls.Add(this.lbl_BankName);
            this.Controls.Add(this.lbl_CardType);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pb_Card);
            this.Controls.Add(this.pb_NotFound);
            this.Name = "ctrCreditCard";
            this.Size = new System.Drawing.Size(1451, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Network)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Card)).EndInit();
            this.Panel_Status.ResumeLayout(false);
            this.Panel_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NotFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2PictureBox pb_Card;
        private System.Windows.Forms.Label lbl_CardType;
        private System.Windows.Forms.Label lbl_BankName;
        private System.Windows.Forms.Label lbl_ValidThru;
        private System.Windows.Forms.Label lbl_ExpireDate;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.Label lbl_CardNumber;
        private Guna.UI2.WinForms.Guna2PictureBox pb_Network;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Search;
        private Guna.UI2.WinForms.Guna2Button btn_MainMenu;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Activate;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Deactivate;
        private Guna.UI2.WinForms.Guna2Panel Panel_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Reissue;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Renew;
        private System.Windows.Forms.PictureBox pb_NotFound;
    }
}
