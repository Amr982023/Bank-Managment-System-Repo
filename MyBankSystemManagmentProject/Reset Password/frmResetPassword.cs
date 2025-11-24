using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace MyBankSystemManagmentProject
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword(int UserID,Form Form)
        {
            InitializeComponent();
            _UserID = UserID;
            _Prev_Form = Form;
        }
        int _UserID;
        Form _Prev_Form;
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(txt_NewPassword.Text != txt_ConfirmNewPassword.Text)
            {
                MessageBox.Show("Check Confirm Password");
                return;
            }

            clsUser User = clsUser.Find(_UserID);
            if (User != null)
            {
                User.Password = txt_NewPassword.Text;
                if (User.Save())
                {
                   if( MessageBox.Show("Password Has been Reset Successfully", "Reset",MessageBoxButtons.OK)== DialogResult.OK)
                    {
                        _Prev_Form.Dispose();
                        this.Dispose();
                    }
                }
                else
                {
                    if(MessageBox.Show("Failed To Reset Password", "Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error)==DialogResult.OK)
                    {
                        _Prev_Form.Dispose();
                        this.Dispose();
                    }
                }
            }
        }

    }
}
