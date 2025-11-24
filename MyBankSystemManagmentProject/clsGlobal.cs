using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using Microsoft.Win32;
using System.Windows.Forms;

namespace MyBankSystemManagmentProject
{
    public class clsGlobal
    {
        public static clsUser CurrentUser;
        public static Form1 Form;
        public static int LoginID;
        public static Stack<UserControl> History = new Stack<UserControl>(); 
        public static ctrlMain MainControl = null;

        private static readonly Random _rnd = new Random();

        public static void LoadMainPage()
        {  
            clsGlobal.Form.LoadMainPage();      
            clsGlobal.History.Clear();
            clsGlobal.History.Push(MainControl);
            MainControl.RefreshPage();
        }

        public static bool RememberUsernameAndPassword_Registry(string Username, string Password)
        {
            bool Flag = false;
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\BankSystem";

            try
            {
                Registry.SetValue(keyPath, "UserName", Username, RegistryValueKind.String);
                Registry.SetValue(keyPath, "Password", Password, RegistryValueKind.String);
                Flag = true;
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Security");
                Flag = false;
            }

            return Flag;
        }

        public static bool GetStoredCredential_Registry(ref string Username, ref string Password)
        {
            bool Flag = false;

            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\BankSystem";

            try
            {
                Username = Registry.GetValue(keyPath, "UserName", null) as string;
                Password = Registry.GetValue(keyPath, "Password", null) as string;
                Flag = true;
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Security");
                Flag = false;
            }

            return Flag;
        }

        public static string GenerateRandomNumber(int Length)
        {
            string Number = _rnd.Next(1, 10).ToString(); // Make sure the first number is not zero
            for (int i = 1; i < Length; i++)
                Number += _rnd.Next(0, 10);

            return Number;
        }

    }
}
