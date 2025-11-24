namespace MyBankSystemManagmentProject
{
    partial class FormViewClient
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
            this.ctrViewClient1 = new MyBankSystemManagmentProject.ctrViewClient();
            this.SuspendLayout();
            // 
            // ctrViewClient1
            // 
            this.ctrViewClient1.BackColor = System.Drawing.Color.White;
            this.ctrViewClient1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrViewClient1.Location = new System.Drawing.Point(0, 0);
            this.ctrViewClient1.Name = "ctrViewClient1";
            this.ctrViewClient1.Size = new System.Drawing.Size(1175, 301);
            this.ctrViewClient1.TabIndex = 0;
            // 
            // FormViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 297);
            this.Controls.Add(this.ctrViewClient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormViewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Client";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrViewClient ctrViewClient1;
    }
}