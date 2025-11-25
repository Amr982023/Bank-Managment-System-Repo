using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using Business_Layer;
using Common;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyBankSystemManagmentProject
{
    public partial class ctrlGeneralOperations : UserControl
    {
        public event Action OnClose;
        public enum enMode { DeleteClients, UpdateClients, FindClients, DeleteUsers, UpdateUsers, FindUsers ,FindAccount }
  
        private enMode _Mode = enMode.FindClients;

        public enMode Mode
        {
            set
            {
                _Mode = value;
                switch (value)
                {
                    case enMode.UpdateClients:
                        dgv_Search.ContextMenuStrip = cms_UpdateClient;
                        rb_NationalID_UserName_AccountNumber.Text = "National ID";
                        lbl_Title.Text = "Update Clients";
                        break;

                    case enMode.DeleteClients:
                        dgv_Search.ContextMenuStrip = cms_deleteClient;
                        rb_NationalID_UserName_AccountNumber.Text = "National ID";
                        lbl_Title.Text = "Delete Clients";
                        break;

                    case enMode.FindClients:
                        rb_NationalID_UserName_AccountNumber.Text = "National ID";
                        lbl_Title.Text = "Find Clients";
                        dgv_Search.ContextMenuStrip = cms_ViewClient;
                        break;

                    case enMode.UpdateUsers:
                        dgv_Search.ContextMenuStrip = cms_UpdateUser;
                        rb_NationalID_UserName_AccountNumber.Text = "User Name";
                        lbl_Title.Text = "Update Users";
                        break;

                    case enMode.DeleteUsers:
                        dgv_Search.ContextMenuStrip = cms_DeleteUser;
                        rb_NationalID_UserName_AccountNumber.Text = "User Name";
                        lbl_Title.Text = "Delete Users";
                        break;

                    case enMode.FindUsers:
                        rb_NationalID_UserName_AccountNumber.Text = "User Name";
                        lbl_Title.Text = "Find Users";
                        dgv_Search.ContextMenuStrip = null;
                        break;

                    case enMode.FindAccount:   
                        rb_NationalID_UserName_AccountNumber.Text = "Account Number";
                        lbl_Title.Text = "Find Account";
                        dgv_Search.ContextMenuStrip = cms_ViewAccount;
                        break;
                }
            }
        }

        private short CurrentPageNumber = 1;
        private short PageSize = 10;
        private int TotalRecords = 0;

        public ctrlGeneralOperations()
        {
            InitializeComponent();
            Mode = enMode.FindClients; // Default mode
            dgv_Search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rb_NationalID_UserName_AccountNumber.Checked = true;
            dgv_Search.AutoGenerateColumns = true;
            OnClose += back;
        }

        void _LoadUpdateUserSub(string UserName)
        {
            ctrUpdateUserSub Sub = new ctrUpdateUserSub(UserName);
            Sub.OnClose += RefreshPage;
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(Sub);
        }

        void _LoadUpdateClientSub(string NationalID)
        {
            ctrUpdateClientSub Sub = new ctrUpdateClientSub(NationalID);
            Sub.OnClose += RefreshPage;
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(Sub);
        }

        void _CurrentRowCheck(string Message)
        {
            if (dgv_Search.Rows.Count == 0 || dgv_Search.CurrentRow == null)
            {
                MessageBox.Show(Message, "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OnClose?.Invoke();
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (CurrentPageNumber > 1)
            {
                CurrentPageNumber--;
                RefreshPage();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (CurrentPageNumber < Math.Ceiling((double)TotalRecords / PageSize))
            {
                CurrentPageNumber++;
                RefreshPage();
            }
        }

        public async void RefreshPage()
        {
            
            try
            {
                string searchText = txt_Search.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    dgv_Search.DataSource = null;
                    label2.Text = $"Page {CurrentPageNumber} From 1";
                    btn_Previous.Enabled = false;
                    btn_Next.Enabled = false;
                    return;
                }

                DataTable dataSource ;
                if (_Mode == enMode.DeleteClients || _Mode == enMode.FindClients || _Mode == enMode.UpdateClients)
                {
                    dataSource = rb_FirstName_Name.Checked
                        ? clsClient.SearchWithFirstName(searchText, CurrentPageNumber, PageSize, ref TotalRecords)
                        : clsClient.SearchWithNationalID(searchText, CurrentPageNumber, PageSize, ref TotalRecords);
                    
                }else if(_Mode == enMode.FindAccount)
                {
                   (dataSource,TotalRecords) = rb_FirstName_Name.Checked
                        ? await clsAccounts.SearchWithName(searchText, CurrentPageNumber, PageSize)
                        :await clsAccounts.SearchWithAccountNumber(searchText, CurrentPageNumber, PageSize);
                }
                else
                {
                    dataSource = rb_FirstName_Name.Checked
                        ? clsUser.SearchWithFirstName(searchText, CurrentPageNumber, PageSize, ref TotalRecords)
                        : clsUser.SearchWithUserName(searchText, CurrentPageNumber, PageSize, ref TotalRecords);
                }


                dgv_Search.DataSource = dataSource;
                label2.Text = TotalRecords != 0
                    ? $"Page {CurrentPageNumber} From {Math.Ceiling((double)TotalRecords / PageSize)}"
                    : $"Page {CurrentPageNumber} From 1";

                btn_Previous.Enabled = CurrentPageNumber > 1;
                btn_Next.Enabled = CurrentPageNumber < Math.Ceiling((double)TotalRecords / PageSize);
            }
            catch (Exception ex)
            {
                clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            _CurrentRowCheck("Please select a Client to delete.");

            string NationalID = dgv_Search.CurrentRow.Cells["NationalID"].Value.ToString().Trim();
            clsClient Client = clsClient.FindByNationalID(NationalID);

            if (Client == null)
            {
                MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnClose?.Invoke();
            }

            if (MessageBox.Show($"Are you sure you want to delete client with National ID : {NationalID}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Client.Delete())
                {
                   // Client.CloseAccounts();

                    MessageBox.Show($"Client with National ID : {NationalID} deleted successfully.", "Deleted", MessageBoxButtons.OK);
                    RefreshPage();
                }
                else
                {
                    MessageBox.Show("Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OnClose?.Invoke();
                }
            }
        }

        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CurrentRowCheck("Please select a user to delete.");

            string UserName = dgv_Search.CurrentRow.Cells["UserName"].Value.ToString().Trim();
            clsUser User = clsUser.Find(UserName);

            if (User == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnClose?.Invoke();
            }

            if (MessageBox.Show($"Are you sure you want to delete user with User Name: {UserName}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (User.Delete())
                {
                    MessageBox.Show($"User with User Name: {UserName} deleted successfully.", "Deleted", MessageBoxButtons.OK);
                    RefreshPage();
                }
                else
                {
                    MessageBox.Show("Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OnClose?.Invoke();
                }
            }
        }

        private void UpdateUsertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _CurrentRowCheck("Please select a user to update.");

            string UserName = dgv_Search.CurrentRow.Cells["UserName"].Value.ToString();

            // OpenUpdateUserSub?.Invoke(UserName);
            _LoadUpdateUserSub(UserName);
        }

        private void UpdateClienttoolStripMenuItem2_Click(object sender, EventArgs e)
        {   
            _CurrentRowCheck("Please select a Client to update.");

            string NationalID = dgv_Search.CurrentRow.Cells["NationalID"].Value.ToString();
            // OpenUpdateClientSub?.Invoke(NationalID);
            _LoadUpdateClientSub(NationalID);
        }

        private void ctrlSearch_Load(object sender, EventArgs e)
        {
            dgv_Search.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rb_NationalID_UserName_AccountNumber.Checked = true;
            dgv_Search.AutoGenerateColumns = true;
            btn_Previous.Enabled = false;
            btn_Next.Enabled = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            OnClose?.Invoke(); 
        }

        void back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
            this.Dispose();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            CurrentPageNumber = 1;
            RefreshPage();
        }

        private void rb_FirstName_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void rb_NationalID_UserName_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void ViewAccount_Click(object sender, EventArgs e)
        { 
            _CurrentRowCheck("Please select an Account to View.");

            string AccountNumber = dgv_Search.CurrentRow.Cells["AccountNumber"].Value.ToString();

            frmShowAccount showAccount = new frmShowAccount(AccountNumber);
            showAccount.ShowDialog();
        }

        private void ViewClient_Click(object sender, EventArgs e)
        {
            _CurrentRowCheck("Please select an Client to View.");

            string NationalID = dgv_Search.CurrentRow.Cells["NationalID"].Value.ToString();

            FormViewClient showClient = new FormViewClient(NationalID);
            showClient.ShowDialog();
        }

    }
}

