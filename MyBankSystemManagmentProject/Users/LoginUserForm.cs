using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Common.Services;

namespace MyBankSystemManagmentProject
{
    public partial class LoginUserForm : Form
    {
        short Counter = 3;

        clsUser User = null;

         
        public LoginUserForm()
        {
            InitializeComponent();         
            this.AcceptButton = btn_LoginUser;        
        }

        private void Login (ref short Counter)
        {
            User = clsUser.Find(txt_LoginUser_UserName.Text.ToString().Trim(), txt_LoginUser_Password.Text.ToString().Trim());
        
            int LoginID = 0;
            if (User != null)
            {
               clsGlobal.CurrentUser = User;
                this.Hide();
                MainForm Form = new MainForm(this);
                clsGlobal.Form = Form;
                LoginID = clsLoginLogs.Save(User.ID);
                if (LoginID != 0)
                {
                    clsGlobal.LoginID = LoginID;
                }

                if (checkBoxRemember.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword_Registry(txt_LoginUser_UserName.Text.Trim(), txt_LoginUser_Password.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword_Registry("", "");
                }

                Form.ShowDialog(); 

                return;
            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password !", "Invalid !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Warning, $"Invalid Login With User Name {txt_LoginUser_UserName.Text}!", "Security");
                txt_LoginUser_Password.Clear();
                txt_LoginUser_Password.Focus();
                Counter--;
            }
        }
     
        private void pb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginUserForm_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential_Registry(ref UserName, ref Password))
            {
                txt_LoginUser_UserName.Text = UserName;
                txt_LoginUser_Password.Text = Password;
                checkBoxRemember.Checked = true;
            }
            else
                checkBoxRemember.Checked = false;

            if (txt_LoginUser_UserName.Text == "" && txt_LoginUser_Password.Text == "")
            {
                checkBoxRemember.Checked = false;

            }
        }

        private void btn_LoginUser_Click_1(object sender, EventArgs e)
        { 
            Login(ref Counter);
            if (Counter <= 0)
            {
                MessageBox.Show("Too many failed attempts. The application will now close.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Warning, "Too many failed attempts. The application will now close.", "Security");
                Application.Exit();
            }
        }

        private void linklabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          frmResetCode resetPasswordCode = new frmResetCode();
            resetPasswordCode.ShowDialog();
            
        }

     
    
        
        

    }
}
