namespace MyBankSystemManagmentProject
{
    partial class frmShowAccount
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
            this.ctrViewAccount1 = new MyBankSystemManagmentProject.ctrViewAccount();
            this.SuspendLayout();
            // 
            // ctrViewAccount1
            // 
            this.ctrViewAccount1.BackColor = System.Drawing.Color.White;
            this.ctrViewAccount1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrViewAccount1.Location = new System.Drawing.Point(0, 0);
            this.ctrViewAccount1.Name = "ctrViewAccount1";
            this.ctrViewAccount1.Size = new System.Drawing.Size(713, 288);
            this.ctrViewAccount1.TabIndex = 0;
            // 
            // frmShowAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 286);
            this.Controls.Add(this.ctrViewAccount1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowAccount";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrViewAccount ctrViewAccount1;
    }
}