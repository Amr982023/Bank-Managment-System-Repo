namespace MyBankSystemManagmentProject
{
    partial class ctrDeposit_Withdraw
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
            this.btn_General = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Deposit_AccountNumber = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Main = new System.Windows.Forms.Label();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_AccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_General
            // 
            this.btn_General.AutoRoundedCorners = true;
            this.btn_General.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_General.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_General.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_General.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_General.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_General.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_General.ForeColor = System.Drawing.Color.White;
            this.btn_General.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_General.Location = new System.Drawing.Point(52, 360);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(424, 54);
            this.btn_General.TabIndex = 59;
            this.btn_General.Text = "Deposit";
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
            // 
            // lbl_Deposit_AccountNumber
            // 
            this.lbl_Deposit_AccountNumber.AutoSize = true;
            this.lbl_Deposit_AccountNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deposit_AccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Deposit_AccountNumber.Location = new System.Drawing.Point(53, 50);
            this.lbl_Deposit_AccountNumber.Name = "lbl_Deposit_AccountNumber";
            this.lbl_Deposit_AccountNumber.Size = new System.Drawing.Size(182, 30);
            this.lbl_Deposit_AccountNumber.TabIndex = 57;
            this.lbl_Deposit_AccountNumber.Text = "Account Number";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Amount.Location = new System.Drawing.Point(53, 185);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(94, 30);
            this.lbl_Amount.TabIndex = 56;
            this.lbl_Amount.Text = "Amount";
            // 
            // lbl_Main
            // 
            this.lbl_Main.AutoSize = true;
            this.lbl_Main.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Main.Location = new System.Drawing.Point(594, 4);
            this.lbl_Main.Name = "lbl_Main";
            this.lbl_Main.Size = new System.Drawing.Size(269, 86);
            this.lbl_Main.TabIndex = 55;
            this.lbl_Main.Text = "Deposit";
            // 
            // btn_Back
            // 
            this.btn_Back.AutoRoundedCorners = true;
            this.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btn_Back.Image = global::MyBankSystemManagmentProject.Properties.Resources.back3_100;
            this.btn_Back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Back.Location = new System.Drawing.Point(93, 637);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(160, 47);
            this.btn_Back.TabIndex = 60;
            this.btn_Back.Text = "Back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Amount);
            this.panel1.Controls.Add(this.lbl_Deposit_AccountNumber);
            this.panel1.Controls.Add(this.txt_AccountNumber);
            this.panel1.Controls.Add(this.btn_General);
            this.panel1.Controls.Add(this.lbl_Amount);
            this.panel1.Location = new System.Drawing.Point(458, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 469);
            this.panel1.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "(required)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "(required)";
            // 
            // txt_Amount
            // 
            this.txt_Amount.BorderRadius = 12;
            this.txt_Amount.BorderThickness = 3;
            this.txt_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Amount.DefaultText = "";
            this.txt_Amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Amount.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Amount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_Amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Amount.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.money_100;
            this.txt_Amount.Location = new System.Drawing.Point(52, 226);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Amount.PlaceholderText = "   Amount";
            this.txt_Amount.SelectedText = "";
            this.txt_Amount.Size = new System.Drawing.Size(424, 66);
            this.txt_Amount.TabIndex = 63;
            // 
            // txt_AccountNumber
            // 
            this.txt_AccountNumber.BorderRadius = 12;
            this.txt_AccountNumber.BorderThickness = 3;
            this.txt_AccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AccountNumber.DefaultText = "";
            this.txt_AccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AccountNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_AccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AccountNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.txt_AccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AccountNumber.IconLeft = global::MyBankSystemManagmentProject.Properties.Resources.user;
            this.txt_AccountNumber.Location = new System.Drawing.Point(52, 88);
            this.txt_AccountNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AccountNumber.Name = "txt_AccountNumber";
            this.txt_AccountNumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_AccountNumber.PlaceholderText = "   Account Number";
            this.txt_AccountNumber.SelectedText = "";
            this.txt_AccountNumber.Size = new System.Drawing.Size(424, 66);
            this.txt_AccountNumber.TabIndex = 62;
            // 
            // ctrDeposit_Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Main);
            this.Name = "ctrDeposit_Withdraw";
            this.Size = new System.Drawing.Size(1451, 750);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_General;
        private System.Windows.Forms.Label lbl_Deposit_AccountNumber;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_Main;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Amount;
        private Guna.UI2.WinForms.Guna2TextBox txt_AccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
