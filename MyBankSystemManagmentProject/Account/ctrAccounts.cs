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
    public partial class ctrAccounts : UserControl
    {
        public ctrAccounts()
        {
            InitializeComponent();
        }

        private void btn_ActivateAccount_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrAccountStatusChange StatusChange = new ctrAccountStatusChange(ctrAccountStatusChange.EnMode.Activate);
            clsGlobal.Form.LoadPage(StatusChange);
           
        }

        private void btn_FreezeAccount_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrAccountStatusChange StatusChange = new ctrAccountStatusChange(ctrAccountStatusChange.EnMode.Freeze);
            clsGlobal.Form.LoadPage(StatusChange);    
        }

        private void btn_BlockAccount_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrAccountStatusChange StatusChange = new ctrAccountStatusChange(ctrAccountStatusChange.EnMode.Block);
            clsGlobal.Form.LoadPage(StatusChange);
        }

        private void btn_ShowAccountList_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrShowList ShowList = new ctrShowList();
            ShowList.Subscribe(clsAccounts.GetAccountsWithPagingAsync);
            ShowList.SetLabel("Show Account List");
            clsGlobal.Form.LoadPage(ShowList);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            clsGlobal.History.Pop();
            this.Dispose();
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            clsGlobal.LoadMainPage();
            this.Dispose();
        }

        private void btn_AddNewAccount_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrAddNewAccount ctrAddNewAccount = new ctrAddNewAccount();
            clsGlobal.Form.LoadPage(ctrAddNewAccount);
        }

        private void btn_FindAccount_Click(object sender, EventArgs e)
        {
            clsGlobal.History.Push(this);
            ctrlGeneralOperations FindAccount = new ctrlGeneralOperations();
            FindAccount.Mode = ctrlGeneralOperations.enMode.FindAccount;
            clsGlobal.Form.LoadPage(FindAccount);
        }
    }
}
