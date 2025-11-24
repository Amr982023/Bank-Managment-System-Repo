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
using static System.Net.Mime.MediaTypeNames;

namespace MyBankSystemManagmentProject
{
    public partial class ctrAddNewClient : UserControl
    {
        public event Action OnClose;

        public ctrAddNewClient()
        {
            InitializeComponent();
        }

        int GetCardTypeID()
        {
            switch (cb_CreditCardType.SelectedItem.ToString())
            {
                case "Debit Card": return 1;
                case "Credit Card": return 2;
                case "Prepaid Card": return 3;
                case "Charge Card": return 4;
                default: return 0;
            }
        }

        int GetNetworkTypeID()
        {
            switch (cb_CreditCardNetwork.SelectedItem.ToString())
            {
                case "Visa": return 1;
                case "MasterCard": return 2;
                case "American Express": return 3;
                case "Discover": return 4;
                case "UnionPay": return 5;
                default: return 0;
            }
        }

        int GetClientTypeID()
        {
            switch (cb_ClientType.SelectedItem.ToString())
            {
                case "Individual": return 1;
                case "Company": return 2;
                case "VIP": return 3;
                case "Government": return 4;
                default: return 0;
            }
        }

        int GetAccountTypeID()
        {
            switch (cb_AccountType.SelectedItem.ToString())
            {
                case "Current": return 1;
                case "Saving": return 2;
                case "Fixed": return 3;
                case "Deposit": return 4;
                case "Salary": return 5;
                case "Joint": return 6;
                case "Student": return 7;
                default: return 0;
            }
        }

        void CurrencyHandle()
        {
            //Currency Handling
            DataTable dt = clsCurrency.GetAllCurrencies();

            //placeholder
            DataRow dr = dt.NewRow();
            dr["ID"] = 0;
            dr["Code"] = "Currency";
            dr["Name"] = "Select Currency";
            dt.Rows.InsertAt(dr, 0);
            cb_Currency.DataSource = dt;
            cb_Currency.DisplayMember = "Code";
            cb_Currency.ValueMember = "ID";
            cb_Currency.SelectedIndex = 0;
        }

        void CountriesHandle()
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

        void HandleComboBoxes()
        {
            CurrencyHandle();

            CountriesHandle();

            cb_ClientType.SelectedIndex = 0;
            cb_CreditCardNetwork.SelectedIndex = 0;
            cb_CreditCardType.SelectedIndex = 0;
            cb_AccountType.SelectedIndex = 0;
        }

        void HandleDateTimePicker()
        {
            DateTimePicker.MaxDate = DateTime.Now.AddYears(-21);
            DateTimePicker.MinDate = DateTime.Now.AddYears(-100);
        }

        private void ctrAddNewClient_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.unknown_icon;
            pictureBox1.Image.Tag = "unknown";

            ll_ChangePhoto.Text = "Add Picture";
            ll_RemovePhoto.Visible = false;

            HandleComboBoxes();

            HandleDateTimePicker();
        }

        void Reset()
        {
            pictureBox1.Image = Resources.unknown_icon;
            ll_RemovePhoto.Visible = false;
            ll_ChangePhoto.Text = "Add Picture";
            txt_FirstName_AddClient.Text = "";
            txt_LastName_AddClient.Text = "";
            txt_Email_AddClient.Text = "";
            txt_Phone1_AddClient.Text = "";
            txt_Balance_AddClient.Text = "";
            txt_AddClient_AccountNumber.Text = "";
            Txt_CreditPassword_AddClient.Text = "";
        }

        private void txt_Balance_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Balance_AddClient.Text))
            {
                errorProvider1.SetError(txt_Balance_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.IsNumber(txt_Balance_AddClient.Text))
            {
                errorProvider1.SetError(txt_Balance_AddClient, "This field Should Contains only numbers.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Balance_AddClient, "");
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
                e.Cancel = false;
            }
        }

        private void cb_ClientType_Validating(object sender, CancelEventArgs e)
        {
            if (cb_ClientType.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_ClientType, "Please Choose Client Type");
            }
            else
            {
                errorProvider1.SetError(cb_ClientType, "");
                e.Cancel = false;
            }

        }

        private void cb_CreditCardType_Validating(object sender, CancelEventArgs e)
        {
            if (cb_CreditCardType.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_CreditCardType, "Please Choose Credit Card Type");
            }
            else
            {
                errorProvider1.SetError(cb_CreditCardType, "");
                e.Cancel = false;
            }
        }

        private void cb_CreditCardNetwork_Validating(object sender, CancelEventArgs e)
        {
            if (cb_CreditCardNetwork.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_CreditCardNetwork, "Please Choose Credit Card Network");
            }
            else
            {
                errorProvider1.SetError(cb_CreditCardNetwork, "");
                e.Cancel = false;
            }
        }

        private void Txt_CreditPassword_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_CreditPassword_AddClient.Text))
            {
                errorProvider1.SetError(Txt_CreditPassword_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(Txt_CreditPassword_AddClient, "");
                e.Cancel = false;
            }
        }

        private void txt_AddClient_AccountNumber_Validating_1(object sender, CancelEventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txt_AddClient_AccountNumber.Text))
            {
                errorProvider1.SetError(txt_AddClient_AccountNumber, "This field is required.");
                e.Cancel = true;
            }
            else if(clsAccounts.IsAccountExist(txt_AddClient_AccountNumber.Text))
            {
                errorProvider1.SetError(txt_AddClient_AccountNumber, "This Account Number is Taken Before.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddClient_AccountNumber, "");
                e.Cancel = false;
            }
        }

        private void txt_Phone_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Phone1_AddClient.Text))
            {
                errorProvider1.SetError(txt_Phone1_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateInteger(txt_Phone1_AddClient.Text))
            {
                errorProvider1.SetError(txt_Phone1_AddClient, "This is not valid Format, Please Enter Numbers only.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Phone1_AddClient, "");
                e.Cancel = false;
            }
        }

        private void txt_Email_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Email_AddClient.Text))
            {
                errorProvider1.SetError(txt_Email_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateEmail(txt_Email_AddClient.Text))
            {
                errorProvider1.SetError(txt_Email_AddClient, "This Email is Not Valid!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Email_AddClient, "");
                e.Cancel = false;
            }
        }

        private void txt_LastName_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_LastName_AddClient.Text))
            {
                errorProvider1.SetError(txt_LastName_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_LastName_AddClient, "");
                e.Cancel = false;
            }
        }

        private void txt_FirstName_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FirstName_AddClient.Text))
            {
                errorProvider1.SetError(txt_FirstName_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_FirstName_AddClient, "");
                e.Cancel = false;
            }
        }

        private void txt_SecondName_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SecondName_AddClient.Text))
            {
                errorProvider1.SetError(txt_SecondName_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_SecondName_AddClient, "");
                e.Cancel = false;
            }
        }

        private void txt_ThirdName_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ThirdName_AddClient.Text))
            {
                errorProvider1.SetError(txt_ThirdName_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_ThirdName_AddClient, "");
                e.Cancel = false;
            }
        }

        private void txt_AddClient_Street_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddClient_Street.Text))
            {
                errorProvider1.SetError(txt_AddClient_Street, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddClient_Street, "");
                e.Cancel = false;
            }
        }

        private void txt_AddClient_City_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddClient_City.Text))
            {
                errorProvider1.SetError(txt_AddClient_City, "This field is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddClient_City, "");
                e.Cancel = false;
            }
        }

        private void txt_Phone2_AddClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Phone2_AddClient.Text))
            {
                errorProvider1.SetError(txt_Phone2_AddClient, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateInteger(txt_Phone2_AddClient.Text))
            {
                errorProvider1.SetError(txt_Phone2_AddClient, "This is not valid Format, Please Enter Numbers only.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Phone2_AddClient, "");
                e.Cancel = false;
            }
        }

        private void btn_Save_AddNewClient_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new NewClientDTO
            {
                FirstName = txt_FirstName_AddClient.Text.Trim(),
                SecondName = txt_SecondName_AddClient.Text.Trim(),
                ThirdName = txt_ThirdName_AddClient.Text.Trim(),
                LastName = txt_LastName_AddClient.Text.Trim(),
                Email = txt_Email_AddClient.Text.Trim(),
                NationalID = txt_AddClient_NationalID.Text.Trim(),
                DateOfBirth = DateTimePicker.Value,
                Gender = rb_Male.Checked ? "Male" : "Female",
                PhotoPath = pictureBox1.Image.Tag?.ToString() == "unknown" ? "" : pictureBox1.ImageLocation,

                ClientTypeID = GetClientTypeID(),
                CountryID = Convert.ToInt32(cb_Country.SelectedValue),
                Street = txt_AddClient_Street.Text.Trim(),
                City = txt_AddClient_City.Text.Trim(),
                Phones = new List<string> { txt_Phone1_AddClient.Text.Trim(), txt_Phone2_AddClient.Text.Trim() },

                Balance = Convert.ToDecimal(txt_Balance_AddClient.Text.Trim()),
                AccountNumber = txt_AddClient_AccountNumber.Text.Trim(),
                CurrencyID = Convert.ToInt32(cb_Currency.SelectedValue),
                AccountTypeID = GetAccountTypeID(),

                CardTypeID = GetCardTypeID(),
                NetworkTypeID = GetNetworkTypeID(),
                CardPassword = Txt_CreditPassword_AddClient.Text.Trim(),
                CardNumber = clsGlobal.GenerateRandomNumber(16)

            };

            var result = ClientServices.AddNewClient_FullTransaction(dto);

            MessageBox.Show(result.Message, result.Success ? "Success" : "Error");

            if (result.Success)
            {
                if (MessageBox.Show("Do You Want To Add Another New Client ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    OnClose?.Invoke();
                    Back();
                }
            }
            else
            {
                OnClose?.Invoke();
                Back();
            }
        }

        private void ll_RemovePhoto_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = Resources.unknown_icon;
            pictureBox1.Image.Tag = "unknown";
            ll_RemovePhoto.Visible = false;
            ll_ChangePhoto.Text = "Add Picture";
        }

        private void ll_ChangePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Select a PhotoPath";
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string PhotoPath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = PhotoPath;
                ll_RemovePhoto.Visible = true;
                ll_ChangePhoto.Text = "Change Picture";
            }
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

        private void btn_Back_AddNewClient_Click_1(object sender, EventArgs e)
        {
            // OnClose.Invoke();           
            Back();
        }

        private void txt_AddClient_NationalID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AddClient_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddClient_NationalID, "This field is required.");
                e.Cancel = true;
            }
            else if (!clsValidation.ValidateInteger(txt_AddClient_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddClient_NationalID, "This is not valid Format, Please Enter Numbers only.");
                e.Cancel = true;
            }
            else if (txt_AddClient_NationalID.Text.Length != 14)
            {
                errorProvider1.SetError(txt_AddClient_NationalID, "The National ID Should Contain 14 Digit.");
                e.Cancel = true;
            }
            else if (clsPerson.IsExist(txt_AddClient_NationalID.Text))
            {
                errorProvider1.SetError(txt_AddClient_NationalID, "This National ID is Used Before.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_AddClient_NationalID, "");
                e.Cancel = false;
            }
        }

        private void cb_Currency_Validating(object sender, CancelEventArgs e)
        {
            if (cb_Currency.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_Currency, "Please Choose Currency");
            }
            else
            {
                errorProvider1.SetError(cb_Currency, "");
                e.Cancel= false;
            }
        }

        private void cb_AccountType_Validating(object sender, CancelEventArgs e)
        {
            if (cb_AccountType.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_AccountType, "Please Choose Currency");
            }
            else
            {
                errorProvider1.SetError(cb_AccountType, "");
                e.Cancel= false;
            }
        }

    }
    
}
