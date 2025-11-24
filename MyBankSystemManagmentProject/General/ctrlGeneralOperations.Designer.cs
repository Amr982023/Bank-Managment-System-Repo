namespace MyBankSystemManagmentProject
{
    partial class ctrlGeneralOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlGeneralOperations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_NationalID_UserName_AccountNumber = new System.Windows.Forms.RadioButton();
            this.rb_FirstName_Name = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cms_DeleteUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_UpdateUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_UpdateClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_deleteClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.btn_Back = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.cms_ViewAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_ViewClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cms_DeleteUser.SuspendLayout();
            this.cms_UpdateUser.SuspendLayout();
            this.cms_UpdateClient.SuspendLayout();
            this.cms_deleteClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.cms_ViewAccount.SuspendLayout();
            this.cms_ViewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_NationalID_UserName_AccountNumber);
            this.panel1.Controls.Add(this.rb_FirstName_Name);
            this.panel1.Location = new System.Drawing.Point(1047, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 60);
            this.panel1.TabIndex = 39;
            // 
            // rb_NationalID_UserName_AccountNumber
            // 
            this.rb_NationalID_UserName_AccountNumber.AutoSize = true;
            this.rb_NationalID_UserName_AccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_NationalID_UserName_AccountNumber.Location = new System.Drawing.Point(3, 21);
            this.rb_NationalID_UserName_AccountNumber.Name = "rb_NationalID_UserName_AccountNumber";
            this.rb_NationalID_UserName_AccountNumber.Size = new System.Drawing.Size(153, 33);
            this.rb_NationalID_UserName_AccountNumber.TabIndex = 8;
            this.rb_NationalID_UserName_AccountNumber.TabStop = true;
            this.rb_NationalID_UserName_AccountNumber.Text = "User Name";
            this.rb_NationalID_UserName_AccountNumber.UseVisualStyleBackColor = true;
            this.rb_NationalID_UserName_AccountNumber.CheckedChanged += new System.EventHandler(this.rb_NationalID_UserName_CheckedChanged);
            // 
            // rb_FirstName_Name
            // 
            this.rb_FirstName_Name.AutoSize = true;
            this.rb_FirstName_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_FirstName_Name.Location = new System.Drawing.Point(227, 20);
            this.rb_FirstName_Name.Name = "rb_FirstName_Name";
            this.rb_FirstName_Name.Size = new System.Drawing.Size(149, 33);
            this.rb_FirstName_Name.TabIndex = 9;
            this.rb_FirstName_Name.TabStop = true;
            this.rb_FirstName_Name.Text = "First Name";
            this.rb_FirstName_Name.UseVisualStyleBackColor = true;
            this.rb_FirstName_Name.CheckedChanged += new System.EventHandler(this.rb_FirstName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(836, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 37;
            this.label1.Text = "Search With : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lbl_Title.Location = new System.Drawing.Point(520, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(113, 86);
            this.lbl_Title.TabIndex = 35;
            this.lbl_Title.Text = "lbl";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.label2.Location = new System.Drawing.Point(1236, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Page";
            // 
            // cms_DeleteUser
            // 
            this.cms_DeleteUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.cms_DeleteUser.Name = "cms_Update";
            this.cms_DeleteUser.Size = new System.Drawing.Size(134, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripMenuItem.Image")));
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.DeleteToolStripMenuItem.Text = "Delete User";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteUserToolStripMenuItem_Click);
            // 
            // cms_UpdateUser
            // 
            this.cms_UpdateUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cms_UpdateUser.Name = "cms_Update";
            this.cms_UpdateUser.Size = new System.Drawing.Size(139, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem1.Text = "Update User";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.UpdateUsertoolStripMenuItem1_Click);
            // 
            // cms_UpdateClient
            // 
            this.cms_UpdateClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.cms_UpdateClient.Name = "cms_Update";
            this.cms_UpdateClient.Size = new System.Drawing.Size(147, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem2.Text = "Update Client";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.UpdateClienttoolStripMenuItem2_Click);
            // 
            // cms_deleteClient
            // 
            this.cms_deleteClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteClientToolStripMenuItem});
            this.cms_deleteClient.Name = "cms_delete";
            this.cms_deleteClient.Size = new System.Drawing.Size(142, 26);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteClientToolStripMenuItem.Image")));
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(875, 681);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(134, 43);
            this.btn_Next.TabIndex = 41;
            this.btn_Next.Text = "Next Page";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Previous.FlatAppearance.BorderSize = 0;
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.ForeColor = System.Drawing.Color.White;
            this.btn_Previous.Location = new System.Drawing.Point(545, 681);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(134, 43);
            this.btn_Previous.TabIndex = 40;
            this.btn_Previous.Text = "Previous Page";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // dgv_Search
            // 
            this.dgv_Search.AllowUserToAddRows = false;
            this.dgv_Search.AllowUserToDeleteRows = false;
            this.dgv_Search.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Search.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Search.Location = new System.Drawing.Point(0, 162);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.ReadOnly = true;
            this.dgv_Search.RowTemplate.Height = 25;
            this.dgv_Search.Size = new System.Drawing.Size(1451, 513);
            this.dgv_Search.TabIndex = 43;
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
            this.btn_Back.Location = new System.Drawing.Point(112, 681);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(131, 43);
            this.btn_Back.TabIndex = 44;
            this.btn_Back.Text = "Back";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            this.txt_Search.Location = new System.Drawing.Point(0, 114);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_Search.PlaceholderText = "Search . . .";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(712, 44);
            this.txt_Search.TabIndex = 46;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // cms_ViewAccount
            // 
            this.cms_ViewAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewAccount});
            this.cms_ViewAccount.Name = "cms_delete";
            this.cms_ViewAccount.Size = new System.Drawing.Size(148, 26);
            // 
            // ViewAccount
            // 
            this.ViewAccount.Image = ((System.Drawing.Image)(resources.GetObject("ViewAccount.Image")));
            this.ViewAccount.Name = "ViewAccount";
            this.ViewAccount.Size = new System.Drawing.Size(147, 22);
            this.ViewAccount.Text = "View Account";
            this.ViewAccount.Click += new System.EventHandler(this.ViewAccount_Click);
            // 
            // cms_ViewClient
            // 
            this.cms_ViewClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.cms_ViewClient.Name = "cms_delete";
            this.cms_ViewClient.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "View client";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ViewClient_Click);
            // 
            // ctrlGeneralOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Name = "ctrlGeneralOperations";
            this.Size = new System.Drawing.Size(1451, 750);
            this.Load += new System.EventHandler(this.ctrlSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cms_DeleteUser.ResumeLayout(false);
            this.cms_UpdateUser.ResumeLayout(false);
            this.cms_UpdateClient.ResumeLayout(false);
            this.cms_deleteClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.cms_ViewAccount.ResumeLayout(false);
            this.cms_ViewClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_NationalID_UserName_AccountNumber;
        private System.Windows.Forms.RadioButton rb_FirstName_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cms_DeleteUser;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_UpdateUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cms_UpdateClient;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cms_deleteClient;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.DataGridView dgv_Search;
        private Guna.UI2.WinForms.Guna2Button btn_Back;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private System.Windows.Forms.ContextMenuStrip cms_ViewAccount;
        private System.Windows.Forms.ToolStripMenuItem ViewAccount;
        private System.Windows.Forms.ContextMenuStrip cms_ViewClient;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}
