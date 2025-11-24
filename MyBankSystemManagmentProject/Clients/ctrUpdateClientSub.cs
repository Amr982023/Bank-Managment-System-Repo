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
using Common.DTOS;
using Mapster;
using Microsoft.Win32;
using MyBankSystemManagmentProject.Properties;

namespace MyBankSystemManagmentProject
{
    public partial class ctrUpdateClientSub : UserControl
    {
        public ctrUpdateClientSub(string NationalID)
        {
            InitializeComponent();
            _NationalID = NationalID;
        }

        string _NationalID;
        public event Action OnClose;
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

        private void btn_Save_UpdateClient_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dto = new UpdateClientDTO
            {
                NationalID = _NationalID,
                NewNationalID = txt_UpdateClient_NationalID.Text,
                FirstName = txt_FirstName_UpdateClient.Text,
                SecondName = txt_SecondName_UpdateClient.Text,
                ThirdName = txt_ThirdName_UpdateClient.Text,
                LastName = txt_LastName_UpdateClient.Text,
                Email = txt_Email_UpdateClient.Text,
                Gender = rb_Male.Checked ? "Male" : "Female",
                DateOfBirth = DateTimePicker.Value,
                ClientTypeID = cb_ClientType.SelectedIndex,
                PhotoPath = pictureBox1.ImageLocation,
                CountryID = (int)cb_Country.SelectedValue,
                City = txt_UpdateClient_City.Text,
                Street = txt_UpdateClient_Street.Text,
                Phones = new List<string>
        {
            txt_Phone1_UpdateClient.Text,
            txt_Phone2_UpdateClient.Text
        }
            };

            if (ClientServices.UpdateClient(dto, out string error))
            {
                MessageBox.Show($"Client updated successfully.", "Success");
                OnClose?.Invoke();
                Back();
            }
            else
            {
                MessageBox.Show($"Update failed: {error}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_UpdateClient_Click(object sender, EventArgs e)
        {
            OnClose?.Invoke();
            Back();
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

        private void ctrUpdateClientSub_Load(object sender, EventArgs e)
        {   
            //Client Basic Information
            clsClient Client = clsClient.FindByNationalID(_NationalID);
            lbl_UpdateClients.Text += " With ID : " + Client.ID.ToString();
            txt_FirstName_UpdateClient.Text = Client.FirstName.ToString();
            txt_SecondName_UpdateClient.Text = Client.SecondName.ToString();
            txt_ThirdName_UpdateClient.Text = Client.ThirdName.ToString();
            txt_LastName_UpdateClient.Text = Client.LastName.ToString();
            txt_Email_UpdateClient.Text = Client.Email.ToString();
            List<PhoneDTO> phonesList = clsPhones.GetPhonesByPersonID(Client.PersonID);
            txt_Phone1_UpdateClient.Text = (phonesList.Count > 0) ? phonesList[0].Number : "";
            txt_Phone2_UpdateClient.Text = (phonesList.Count > 1) ? phonesList[1].Number : "";
            txt_UpdateClient_NationalID.Text = Client.NationalID;
            cb_ClientType.SelectedIndex = Client.ClientTypeID;
            DateTimePicker.Value = Client.DateOfBirth.Value;


            //Gender
            if (Client.Gender == "Male")
            {
                rb_Male.Checked = true;
            }
            else
            {
                rb_Female.Checked = true;
            }

            // Address
            LoadCountries();
            cb_Country.DataSource = clsCountry.GetCountryList();
            cb_Country.SelectedValue = Client.Address.Country.CountryID;
            txt_UpdateClient_Street.Text = Client.Address.Street;
            txt_UpdateClient_City.Text = Client.Address.City;


            pictureBox1.ImageLocation = Client.PhotoPath.ToString();

            if (string.IsNullOrWhiteSpace(pictureBox1.ImageLocation))
            {
                pictureBox1.Image = Resources.unknown_icon;
                ll_RemovePhoto.Visible = false;
                ll_ChangePhoto.Text = "Add Picture";
            }
            else
            {
                ll_RemovePhoto.Visible = true;
            }
        }
  
        private void ll_ChangePhoto_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void ll_RemovePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = Resources.unknown_icon;
            ll_RemovePhoto.Visible = false;
            ll_ChangePhoto.Text = "Add Picture";
        }

        private void txt_LastName_UpdateClient_Validating(object sender, CancelEventArgs e)
        {      
            if (!clsValidation.ValidateLetter(txt_LastName_UpdateClient.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_LastName_UpdateClient, "Invalid Format!");
            }else if(txt_LastName_UpdateClient.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_LastName_UpdateClient, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_LastName_UpdateClient, null);
            };
        }

        private void txt_FirstName_UpdateClient_Validating(object sender, CancelEventArgs e)
        {

            if (!clsValidation.ValidateLetter(txt_FirstName_UpdateClient.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_FirstName_UpdateClient, "Invalid Format!");
            }
            else if (txt_FirstName_UpdateClient.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_FirstName_UpdateClient, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_FirstName_UpdateClient, null);
            };
        }

        private void txt_ThirdName_UpdateClient_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateLetter(txt_ThirdName_UpdateClient.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_ThirdName_UpdateClient, "Invalid Format!");
            }
            else if (txt_ThirdName_UpdateClient.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_ThirdName_UpdateClient, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_ThirdName_UpdateClient, null);
            };
        }

        private void txt_SecondName_UpdateClient_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateLetter(txt_SecondName_UpdateClient.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_SecondName_UpdateClient, "Invalid Format!");
            }
            else if (txt_SecondName_UpdateClient.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_SecondName_UpdateClient, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_SecondName_UpdateClient, null);
            };
        }

        private void txt_UpdateClient_NationalID_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateInteger(txt_UpdateClient_NationalID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateClient_NationalID, "Invalid Format!");
            }
            else if (!clsValidation.IsNumber(txt_UpdateClient_NationalID.Text))
            {
                errorProvider1.SetError(txt_UpdateClient_NationalID, "This field Should Contains only numbers.");
                e.Cancel = true;
            }
            else if (txt_UpdateClient_NationalID.Text.Length != 14)
            {
                errorProvider1.SetError(txt_UpdateClient_NationalID, "The National ID Should Contain 14 Digit.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_UpdateClient_NationalID, null);
            };
        }

        private void txt_Email_UpdateClient_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateEmail(txt_Email_UpdateClient.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Email_UpdateClient, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txt_Email_UpdateClient, null);
            };
        }

        private void txt_Phone1_UpdateClient_Validating(object sender, CancelEventArgs e)
        {
            clsPhones Phone = clsPhones.FindPhoneByNumber(txt_Phone1_UpdateClient.Text);
            clsClient Client = clsClient.FindByNationalID(_NationalID);
            if (!clsValidation.ValidateInteger(txt_Phone1_UpdateClient.Text) || string.IsNullOrEmpty(txt_Phone1_UpdateClient.Text) )
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Phone1_UpdateClient, "Invalid Format!");
            }
            else if(Phone!=null)
            {
                if(Client.PersonID != Phone.PersonID)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txt_Phone1_UpdateClient, "This Phone Number is already Taken by another Client!");
                }

            }
            else
            {
                errorProvider1.SetError(txt_Phone1_UpdateClient, null);
            };
        }

        private void txt_Phone2_UpdateClient_Validating(object sender, CancelEventArgs e)
        {
            clsPhones Phone = clsPhones.FindPhoneByNumber(txt_Phone2_UpdateClient.Text);
            clsClient Client = clsClient.FindByNationalID(_NationalID);
            if (!clsValidation.ValidateInteger(txt_Phone1_UpdateClient.Text) || string.IsNullOrEmpty(txt_Phone1_UpdateClient.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_Phone2_UpdateClient, "Invalid Format!");
            }
            else if (Phone != null)
            {
                if (Client.PersonID != Phone.PersonID)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txt_Phone2_UpdateClient, "This Phone Number is already Taken by another Client!");
                }

            }
            else
            {
                errorProvider1.SetError(txt_Phone2_UpdateClient, null);
            };
        }

        private void cb_ClientType_Validating(object sender, CancelEventArgs e)
        {
            if (cb_ClientType.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cb_ClientType, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(cb_ClientType, null);
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

        private void txt_UpdateClient_City_Validating(object sender, CancelEventArgs e)
        {
            if (txt_UpdateClient_City.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateClient_City, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_UpdateClient_City, null);
            };
        }

        private void txt_UpdateClient_Street_Validating(object sender, CancelEventArgs e)
        {
           
            if (txt_UpdateClient_Street.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_UpdateClient_Street, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txt_UpdateClient_Street, null);
            };
        }
     
    }
}
