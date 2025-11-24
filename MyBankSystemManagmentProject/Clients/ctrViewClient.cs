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
using MyBankSystemManagmentProject.Properties;
using Newtonsoft.Json.Linq;

namespace MyBankSystemManagmentProject
{
    public partial class ctrViewClient : UserControl
    {
        public ctrViewClient()
        {
            InitializeComponent();
        }


        public string NationalID
        {
            set { FillInformations(value); }
        }

        string GetClientType(int ID)
        {
            switch (ID)
            {
                case 1: return "Individual";
                case 2: return "Company";
                case 3: return "VIP";
                case 4: return "Government";
                default: return "UnKnown";
            }
        }

        void FillInformations(string NationalID)
        {
            clsClient Client = clsClient.FindByNationalID(NationalID);
            lbl_ClientID.Text = Client.ID.ToString();
            lbl_ClientName.Text = Client.FullName;
            lbl_ClientType.Text = GetClientType(Client.ClientTypeID);
            lbl_Gender.Text = Client.Gender;
            lbl_NationalID.Text = Client.NationalID;
            lbl_Email.Text = Client.Email;
            lbl_DateOfBirth.Text = Client.DateOfBirth.ToString();
            lbl_Registrationdate.Text = Client.RegistrationDate.ToString();
            lbl_Address.Text = Client.Address.FullAddress;

            if (string.IsNullOrEmpty(Client.PhotoPath))
            {
                PictureBox_Client.Image = Resources.unknown_icon;
            }
            else
            {
                PictureBox_Client.ImageLocation = Client.PhotoPath;
            }

        }

        
    }
}
