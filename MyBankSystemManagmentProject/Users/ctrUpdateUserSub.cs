using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Common;
using Common.DTOS;
using Mapster;
using Microsoft.Win32;
using MyBankSystemManagmentProject.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyBankSystemManagmentProject
{
    public partial class ctrUpdateUserSub : UserControl
    {
        public ctrUpdateUserSub(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }

        public event Action OnClose;

        int Permission = 0;
        string UserName = string.Empty;

        enum enPermission { enAddNewClient = 1, enShowClientList = 2, enDeleteClient = 4, enUpdateclient = 8, enFindClient = 16, enTransaction = 32, enManageUsers = 64, enLoginRegisters = 128, enCurrencyExchange = 256, enManagementDashBoard = 512 }

        int Permission_Check()
        {
            Permission = 0;
            Permission += ts_AddNewClient.Checked ? (int)enPermission.enAddNewClient : 0;
            Permission += ts_ShowClientList.Checked ? (int)enPermission.enShowClientList : 0;
            Permission += ts_FindClient.Checked ? (int)enPermission.enFindClient : 0;
            Permission += ts_DeleteClient.Checked ? (int)enPermission.enDeleteClient : 0;
            Permission += ts_UpdateClient.Checked ? (int)enPermission.enUpdateclient : 0;
            Permission += ts_Transactions.Checked ? (int)enPermission.enTransaction : 0;
            Permission += ts_ManageUsers.Checked ? (int)enPermission.enManageUsers : 0;
            Permission += ts_LoginRegisters.Checked ? (int)enPermission.enLoginRegisters : 0;
            Permission += ts_CurrencyExchange.Checked ? (int)enPermission.enCurrencyExchange : 0;
            Permission += ts_Managment.Checked ? (int)enPermission.enManagementDashBoard : 0;

            return Permission;
        }

        void PermissionCheck_Show(int permission)
        {
           var permissionsMap = new Dictionary<enPermission, Guna.UI2.WinForms.Guna2ToggleSwitch>
             {
                 { enPermission.enShowClientList, ts_ShowClientList },
                 { enPermission.enAddNewClient, ts_AddNewClient },
                 { enPermission.enFindClient, ts_FindClient },
                 { enPermission.enDeleteClient, ts_DeleteClient },
                 { enPermission.enTransaction, ts_Transactions },
                 { enPermission.enLoginRegisters, ts_LoginRegisters },
                 { enPermission.enUpdateclient, ts_UpdateClient },
                 { enPermission.enManageUsers, ts_ManageUsers },
                 { enPermission.enCurrencyExchange, ts_CurrencyExchange },
                 { enPermission.enManagementDashBoard, ts_Managment }
             };
            
            foreach (var kvp in permissionsMap)
            {
                var perm = kvp.Key;
                var toggle = kvp.Value;

                toggle.Checked = (permission & (int)perm) == (int)perm;
            }
        }

        private void btn_Save_UpdateUser_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some Fileds are not valid ! , put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUser User = clsUser.Find(UserName);

            var dto = new UpdateUserDTO
            {
                UserId = User.ID, 
                FirstName = txt_FirstName_UpdateUser.Text,
                SecondName = txt_SecondName_UpdateUser.Text,
                ThirdName = txt_ThirdName_UpdateUser.Text,
                LastName = txt_LastName_UpdateUser.Text,
                Email = txt_Email_UpdateUser.Text,
                PhotoPath = pictureBox1.ImageLocation,
                NationalID = txt_UpdateUser_NationalID.Text,
                UserName = txt_UserName_UpdateUser.Text,
                Gender = rb_Male.Checked ? "Male" : "Female",
                DateOfBirth = DateTimePicker.Value,

                AddressId = User.Address.ID, 
                CountryId = Convert.ToInt32(cb_Country.SelectedValue),
                City = txt_UpdateUser_City.Text,
                Street = txt_UpdateUser_Street.Text,

                Phone1 = txt_Phone1_UpdateUser.Text,
                Phone2 = txt_Phone2_UpdateUser.Text,

                Permission = Permission_Check()
            };

            var result = UserServices.UpdateUser(dto);

            if (result.IsSuccess)
            {
                MessageBox.Show($"User updated successfully with ID {result.UserId}");     
                    OnClose?.Invoke();
                    Back();
                
            }
            else
            {
                MessageBox.Show($"Error: {result.ErrorMessage}", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnClose?.Invoke();
                Back();
            }
        }

        private void LoadCountries()
        {
            DataTable dtCountries = clsCountry.GetCountryList();
            DataRow drCountry = dtCountries.NewRow();
            drCountry["ID"] = 0;
            drCountry["Name"] = "Country";
            drCountry["Code"] = "Unk";
            dtCountries.Rows.InsertAt(drCountry, 0);

            cb_Country.DataSource = dtCountries;
            cb_Country.DisplayMember = "Name";
            cb_Country.ValueMember = "ID";
            cb_Country.SelectedIndex = 0;
        }

        private void ctrUpdateUserSub_Load(object sender, EventArgs e)
        {       
            clsUser User = clsUser.Find(UserName);
            lbl_UpdateUser.Text += " With ID : " + User.ID.ToString();
            txt_FirstName_UpdateUser.Text = User.FirstName.ToString();
            txt_SecondName_UpdateUser.Text = User.SecondName.ToString();
            txt_ThirdName_UpdateUser.Text = User.ThirdName.ToString();
            txt_LastName_UpdateUser.Text = User.LastName.ToString();
            txt_Email_UpdateUser.Text = User.Email.ToString();
            txt_UpdateUser_NationalID.Text = User.NationalID.ToString();
            txt_UserName_UpdateUser.Text = User.UserName.ToString(); 
            DateTimePicker.Value = User.DateOfBirth.Value;
            if (User.Gender.ToLower()== "male")
            {
                rb_Male.Checked = true;
            }
            else
            {
                rb_Female.Checked = true;
            }

            //Address
            LoadCountries();        
            cb_Country.SelectedValue = User.Address.Country.CountryID;
            txt_UpdateUser_Street.Text = User.Address.Street;
            txt_UpdateUser_City.Text = User.Address.City;



            //Permissions
            Permission = User.Permission;
            PermissionCheck_Show(Permission);


            //Picture
            pictureBox1.ImageLocation = User.PhotoPath.ToString();
            if (pictureBox1.ImageLocation == "")
            {
                pictureBox1.Image = Resources.unknown_icon;
                pb_RemovePhoto.Visible = false;
                
            }
            else
            {
                pb_RemovePhoto.Visible = true;
            }

            //Phones
            List<PhoneDTO> phonesList = clsPhones.GetPhonesByPersonID(User.PersonID);
            txt_Phone1_UpdateUser.Text = (phonesList.Count > 0) ? phonesList[0].Number : "";
            txt_Phone2_UpdateUser.Text = (phonesList.Count > 1) ? phonesList[1].Number : "";

        }

        private void pb_ChangePicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a PhotoPath";
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string PhotoPath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = PhotoPath;
                pb_RemovePhoto.Visible = true;
                
            }
        }

        private void pb_RemovePhoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.unknown_icon;
            pb_RemovePhoto.Visible = false;
            
        }

        private void txt_FirstName_UpdateUser_Validating(object sender, CancelEventArgs e)
        {

            if (!clsValidation.ValidateLetter(txt_FirstName_UpdateUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_FirstName_UpdateUser, "Invalid Format!");
            }
            else if (txt_FirstName_UpdateUser.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_FirstName_UpdateUser, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_FirstName_UpdateUser, null);
            };
        }

        private void txt_SecondName_UpdateUser_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateLetter(txt_SecondName_UpdateUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_SecondName_UpdateUser, "Invalid Format!");
            }
            else if (txt_SecondName_UpdateUser.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_SecondName_UpdateUser, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_SecondName_UpdateUser, null);
            };
        }

        private void txt_ThirdName_UpdateUser_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateLetter(txt_ThirdName_UpdateUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_ThirdName_UpdateUser, "Invalid Format!");
            }
            else if (txt_ThirdName_UpdateUser.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_ThirdName_UpdateUser, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_ThirdName_UpdateUser, null);
            };
        }

        private void txt_LastName_UpdateUser_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateLetter(txt_LastName_UpdateUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_LastName_UpdateUser, "Invalid Format!");
            }
            else if (txt_LastName_UpdateUser.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_LastName_UpdateUser, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_LastName_UpdateUser, null);
            };
        }

        private void txt_Email_UpdateUser_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateEmail(txt_Email_UpdateUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Email_UpdateUser, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txt_Email_UpdateUser, null);
            };
        }

        private void txt_Phone1_UpdateUser_Validating(object sender, CancelEventArgs e)
        {
            clsPhones Phone = clsPhones.FindPhoneByNumber(txt_Phone1_UpdateUser.Text);
            clsUser User = clsUser.Find(UserName);
            if (!clsValidation.ValidateInteger(txt_Phone1_UpdateUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Phone1_UpdateUser, "Invalid Format!");
            }
            else if (Phone != null)
            {
                if (User.PersonID != Phone.PersonID)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txt_Phone1_UpdateUser, "This Phone Number is already Taken by another User!");
                }

            }
            else
            {
                errorProvider1.SetError(txt_Phone1_UpdateUser, null);
            };
        }

        private void txt_Phone2_UpdateUser_Validating(object sender, CancelEventArgs e)
        {
            clsPhones Phone = clsPhones.FindPhoneByNumber(txt_Phone2_UpdateUser.Text);
            clsUser User = clsUser.Find(UserName);
            if (!clsValidation.ValidateInteger(txt_Phone2_UpdateUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Phone2_UpdateUser, "Invalid Format!");
            }
            else if (Phone != null)
            {
                if (User.PersonID != Phone.PersonID)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txt_Phone2_UpdateUser, "This Phone Number is already Taken by another User!");
                }

            }
            else
            {
                errorProvider1.SetError(txt_Phone2_UpdateUser, null);
            };
        }

        private void txt_UserName_UpdateUser_Validating(object sender, CancelEventArgs e)
        {
            if (txt_UserName_UpdateUser.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UserName_UpdateUser, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_UserName_UpdateUser, null);
            };
        }

        private void cb_Country_Validating(object sender, CancelEventArgs e)
        {
            if (cb_Country.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_Country, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(cb_Country, null);
            };
        }

        private void txt_UpdateUser_City_Validating(object sender, CancelEventArgs e)
        {
           
            if (txt_UpdateUser_City.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateUser_City, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_UpdateUser_City, null);
            };
        }

        private void txt_UpdateUser_Street_Validating(object sender, CancelEventArgs e)
        {
            
            if (txt_UpdateUser_Street.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateUser_Street, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_UpdateUser_Street, null);
            };
        }

        void Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
            this.Dispose();
        }

        private void btn_Back_UpdateClient_Click(object sender, EventArgs e)
        {
             OnClose.Invoke();
             Back();      
        }

        private void txt_UpdateUser_NationalID_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNumber(txt_UpdateUser_NationalID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateUser_NationalID, "Invalid Format!");
            }
            else if (string.IsNullOrEmpty(txt_UpdateUser_Street.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateUser_Street, "This Field is required!");
            }else if (txt_UpdateUser_NationalID.Text.Length != 14)
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateUser_Street, "The National ID Should Contains 14 Numbers !");
            }
            else
            {
                errorProvider1.SetError(txt_UpdateUser_Street, null);
            };
        }

    }
}
