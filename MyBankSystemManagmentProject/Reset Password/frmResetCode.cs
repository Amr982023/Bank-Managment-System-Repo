using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Forms;
using Business_Layer;
using Common.Services;

namespace MyBankSystemManagmentProject
{
    public partial class frmResetCode : Form
    {
        public frmResetCode()
        {
            InitializeComponent();
        }

        int _UserID = -1;
        private void txt_UserName_Reset_Validating(object sender, CancelEventArgs e)
        {
            if (txt_OTP.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_OTP, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_OTP, null);
            };
        }

        private async void btn_check_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txt_OTP.Text))
            {
                MessageBox.Show("Reset code is Required", "Required !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (await clsOTP.ValidateUserOtpAsync(_UserID, txt_OTP.Text))
            {
                frmResetPassword Resetcode = new frmResetPassword(_UserID, this);
                Resetcode.ShowDialog();
            }
            else
            {
                MessageBox.Show("The Code is incorrect", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async void linkLabel_SendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty( txt_UserName_Reset.Text))
            {
                MessageBox.Show("User Name is Required", "Required !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            clsUser User = clsUser.Find(txt_UserName_Reset.Text);
            _UserID = User.ID;
            if (User == null)
            {
                MessageBox.Show("This User Name is Not Found Please Enter valid one", "Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string OTP = clsGlobal.GenerateRandomNumber(6);
                if (await clsOTP.GenerateUserOtpAsync(_UserID, OTP))
                {
                    SendMails.SendResetCode(User.Email, OTP);
                    MessageBox.Show("Reset Code Has Been sent to your mail", "Sent!", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Can't Send Reset Code to your mail", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      

        private void frmResetPasswordCode_Load(object sender, EventArgs e)
        {

        }
    }
}
