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

namespace MyBankSystemManagmentProject
{
    public partial class ctrAddNewUser : UserControl
    {
        public event Action OnClose;

        public ctrAddNewUser()
        {
            InitializeComponent();
        }

        enum enPermission { enAddNewClient = 1, enShowClientList = 2, enDeleteClient = 4, enUpdateclient = 8, enFindClient = 16, enTransaction = 32, enManageUsers = 64, enLoginRegisters = 128, enCurrencyExchange = 256, enManagementDashBoard = 512 }

        int GetSelectedPermissions()
        {
           int _Permission = 0;
            _Permission += ts_AddNewClient.Checked ? (int)enPermission.enAddNewClient : 0;
            _Permission += ts_ShowClientList.Checked ? (int)enPermission.enShowClientList : 0;
            _Permission += ts_FindClient.Checked ? (int)enPermission.enFindClient : 0;
            _Permission += ts_DeleteClient.Checked ? (int)enPermission.enDeleteClient : 0;
            _Permission += ts_UpdateClient.Checked ? (int)enPermission.enUpdateclient : 0;
            _Permission += ts_Transactions.Checked ? (int)enPermission.enTransaction : 0;
            _Permission += ts_ManageUsers.Checked ? (int)enPermission.enManageUsers : 0;
            _Permission += ts_LoginRegisters.Checked ? (int)enPermission.enLoginRegisters : 0;
            _Permission += ts_CurrencyExchange.Checked ? (int)enPermission.enCurrencyExchange : 0;
            _Permission += ts_Managment.Checked ? (int)enPermission.enManagementDashBoard : 0;
            return _Permission;
        }

        void Reset()
        {
            pictureBox1.ImageLocation = "";
            pb_RemovePhoto.Visible = false;
            ts_AddNewClient.Checked = false;
            ts_ShowClientList.Checked = false;
            ts_FindClient.Checked = false;
            ts_DeleteClient.Checked = false;
            ts_UpdateClient.Checked = false;
            ts_Transactions.Checked = false;
            ts_ManageUsers.Checked = false;
            ts_LoginRegisters.Checked = false;
        }

        private void ctrAddNewUser_Load(object sender, EventArgs e)
        {
            pictureBox1.Image= Resources.unknown_icon;
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

            HandleDateTimePicker();


            pb_RemovePhoto.Visible = false;
        }

        void HandleDateTimePicker()
        {
            DateTimePicker.MaxDate = DateTime.Now.AddYears(-21);
            DateTimePicker.MinDate = DateTime.Now.AddYears(-100);
        }

        private void btn_Save_AddNewClient_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix validation errors before saving.");
                return;
            }

            var dto = CollectUserData();

            var result = UserServices.AddUser(dto);

            if (result.IsSuccess)
            {
                if (MessageBox.Show(
                    $"User saved successfully with ID {result.UserId}\n\nDo you want to add another user?",
                    "Success",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Reset(); 
                }
                else
                {
                    Back();
                }
            }
            else
            {
                MessageBox.Show($"Error: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Back();
            }
        }

        private NewUserDTO CollectUserData()
        {
            return new NewUserDTO
            {
                FirstName = txt_FirstName_AddUser.Text,
                SecondName = txt_SecondName_AddUser.Text,
                ThirdName = txt_ThirdName_AddUser.Text,
                LastName = txt_LastName_AddUser.Text,
                Email = txt_Email_AddUser.Text,
                NationalID = txt_AddUser_NationalID.Text,
                UserName = txt_UserName_AddUser.Text,
                Password = Txt_Password_AddUser.Text,
                DateOfBirth = DateTimePicker.Value,
                Gender = (rb_Male.Checked) ? "Male":"Female",
                PhotoPath = pictureBox1.ImageLocation ?? "",
                CountryId = Convert.ToInt32(cb_Country.SelectedValue), 
                City = txt_AddUser_City.Text,
                Street = txt_AddUser_Street.Text,
                Phones = GetPhoneNumbers(),
                Permission = GetSelectedPermissions()
            };
        }

        private List<string> GetPhoneNumbers()
        {
            var phones = new List<string>();
            if (!string.IsNullOrWhiteSpace(txt_Phone1_AddUser.Text))
                phones.Add(txt_Phone1_AddUser.Text);
            if (!string.IsNullOrWhiteSpace(txt_Phone2_AddUser.Text))
                phones.Add(txt_Phone2_AddUser.Text);
            return phones;
        }

        void Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
        }

        private void btn_Back_AddNewClient_Click(object sender, EventArgs e)
        {
            //OnClose?.Invoke();
            OnClose?.Invoke();
            Back();
            this.Dispose();
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

        private void txt_FirstName_AddUser_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_FirstName_AddUser.Text))
            {
                errorProvider1.SetError(txt_FirstName_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_FirstName_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_SecondName_AddUser_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_SecondName_AddUser.Text))
            {
                errorProvider1.SetError(txt_SecondName_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_SecondName_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_ThirdName_AddUser_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_ThirdName_AddUser.Text))
            {
                errorProvider1.SetError(txt_ThirdName_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_ThirdName_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_LastName_AddUser_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_LastName_AddUser.Text))
            {
                errorProvider1.SetError(txt_LastName_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_LastName_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_Email_AddUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Email_AddUser.Text))
            {
                errorProvider1.SetError(txt_Email_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateEmail(txt_Email_AddUser.Text))
            {
                errorProvider1.SetError(txt_Email_AddUser, "This Email is Not Valid!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Email_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_Phone1_AddUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Phone1_AddUser.Text))
            {
                errorProvider1.SetError(txt_Phone1_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateInteger(txt_Phone1_AddUser.Text))
            {
                errorProvider1.SetError(txt_Phone1_AddUser, "This is not valid Format, Please Enter Numbers only.");
                e.Cancel = true;
            }
            else if (clsPhones.FindPhoneByNumber(txt_Phone1_AddUser.Text)!= null)
            {
                errorProvider1.SetError(txt_Phone1_AddUser, "This Number is Used Before, Please Enter New one.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Phone1_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_Phone2_AddUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Phone2_AddUser.Text))
            {
                errorProvider1.SetError(txt_Phone2_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateInteger(txt_Phone2_AddUser.Text))
            {
                errorProvider1.SetError(txt_Phone2_AddUser, "This is not valid Format, Please Enter Numbers only.");
                e.Cancel = true;
            }
            else if (clsPhones.FindPhoneByNumber(txt_Phone2_AddUser.Text) != null)
            {
                errorProvider1.SetError(txt_Phone2_AddUser, "This Number is Used Before, Please Enter New one.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Phone2_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_UserName_AddUser_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_UserName_AddUser.Text))
            {
                errorProvider1.SetError(txt_UserName_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_UserName_AddUser, "");
                e.Cancel = false;
            }
        }

        private void Txt_Password_AddUser_Validating(object sender, CancelEventArgs e)
        {
           if(string.IsNullOrEmpty(Txt_Password_AddUser.Text))
            {
                errorProvider1.SetError(Txt_Password_AddUser, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(Txt_Password_AddUser, "");
                e.Cancel = false;
            }
        }

        private void txt_AddUser_NationalID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddUser_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddUser_NationalID, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateInteger(txt_AddUser_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddUser_NationalID, "This is not valid Format, Please Enter Numbers only.");
                e.Cancel = true;
            }
            else if (txt_AddUser_NationalID.Text.Length != 14)
            {
                errorProvider1.SetError(txt_AddUser_NationalID, "The National ID Should Contain 14 Digit.");
                e.Cancel = true;
            }
            else if (clsPerson.IsExist(txt_AddUser_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddUser_NationalID, "This National ID is Used Before.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddUser_NationalID, "");
                e.Cancel = false;
            }
        }

        private void txt_AddUser_City_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddUser_City.Text))
            {
                errorProvider1.SetError(txt_AddUser_City, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddUser_City, "");
                e.Cancel = false;
            }
        }

        private void txt_AddUser_Street_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddUser_Street.Text))
            {
                errorProvider1.SetError(txt_AddUser_Street, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddUser_Street, "");
                e.Cancel = false;
            }
        }

        private void cb_Country_Validating(object sender, CancelEventArgs e)
        {

            if (cb_Country.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_Country, "Please Choose Country");
            }
            else
            {
                errorProvider1.SetError(cb_Country, "");
            }
        }

    }
}
