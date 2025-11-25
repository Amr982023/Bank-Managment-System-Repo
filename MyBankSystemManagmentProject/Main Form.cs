using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using MyBankSystemManagmentProject.Transactions;

namespace MyBankSystemManagmentProject
{
    public partial class MainForm : Form
    {

        enum enPermission {enAddNewClient=1,enShowClientList=2,enDeleteClient=4,enUpdateclient=8,enFindClient=16,enTransaction=32,enManageUsers=64,enLoginRegisters=128,enCurrencyExchange=256,enManagementDashBoard=512}
        
        LoginUserForm loginUserForm;
        public event Action onLoad;

        public MainForm(LoginUserForm frm)
        {
            this.loginUserForm = frm;
            InitializeComponent();
            SideBarControlsRefresh();

            Make_Permissions(clsGlobal.CurrentUser.Permission);
            ctrlMain Main = new ctrlMain();
            clsGlobal.MainControl = Main;
            onLoad += Main.RefreshPage;
            clsGlobal.History.Push(Main);
            LoadPage(Main);
            Common.clsErrorEvents.on_Error += ((string msg) => MessageBox.Show(msg));
           
        }

        private void Make_Permissions(int Permission_Num)
        {
            var permissionsMap = new Dictionary<enPermission, Button>
               {
                   { enPermission.enAddNewClient, btn_AddNewClient },
                   { enPermission.enShowClientList, btn_ShowClientList },
                   { enPermission.enDeleteClient, btn_Delete },
                   { enPermission.enUpdateclient, btn_UpdateClient },
                   { enPermission.enFindClient, btn_FindClient },
                   { enPermission.enTransaction, btn_Transactions },
                   { enPermission.enManageUsers, btn_ManageUsers },
                   { enPermission.enLoginRegisters, btn_LoginRegisters },
                   { enPermission.enCurrencyExchange, btn_Currency_Exchange },
                   { enPermission.enManagementDashBoard, btn_ManagmentDashboard }
               };

            foreach (var kvp in permissionsMap)
            {
                var permission = kvp.Key;
                var button = kvp.Value;
            
                //disable if not available
                button.Enabled = (Permission_Num & (int)permission) != 0;
            }

        }
     
        private void SideBarControlsRefresh()
        {
            if (SideBarExpand == false)
            {
                foreach (Control ctrl in MenuSideBar.Controls)
                {
                    ctrl.Visible = false; 
                }
            }
            else
            {
                foreach (Control ctrl in MenuSideBar.Controls)
                {
                    ctrl.Visible = true;   
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool TransactionMenuExpand = false;
        bool ManageUsersMenuExpand = false;
        bool SideBarExpand = false;

        public void LoadMainPage()
        {
            LoadPage(clsGlobal.MainControl);
        }

        public void LoadPage(UserControl uc)
        {
            Welcomepanel.Controls.Clear();   
            uc.Dock = DockStyle.Fill;
            Welcomepanel.Controls.Add(uc);

            // if uc = Main control The Event Will invoke To Refresh it.
            onLoad?.Invoke();
        }

        private void MenuTransitionTimer_Tick(object sender, EventArgs e)
        {
            if (TransactionMenuExpand == false)
            {
                TransactionContainer.Height += 10;
                if(TransactionContainer.Height >= 342)
                {
                    TransactionMenuTransitionTimer.Stop();
                    TransactionMenuExpand = true;
                }
                MenuSideBar.AutoScrollMargin = new Size(20, 20);
            }
            else
            {
                TransactionContainer.Height -= 10;
                if (TransactionContainer.Height <=59)
                {
                    TransactionMenuTransitionTimer.Stop();
                    TransactionMenuExpand = false;
                }
            }
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            TransactionMenuTransitionTimer.Start();
            if (ManageUsersMenuExpand == true)
            {
                ManageUserTimer.Start();
            }
        }
     
        private void ManageUserTimer_Tick(object sender, EventArgs e)
        {
            if (ManageUsersMenuExpand == false)
            {
                ManageUserContainer.Height += 10;
                if (ManageUserContainer.Height>=326)
                {
                    ManageUserTimer.Stop();
                    ManageUsersMenuExpand = true;
                    
                }
                MenuSideBar.AutoScrollMargin = new Size(20, 20);
            }
            else
            {
                ManageUserContainer.Height -= 10;
                if (ManageUserContainer.Height<=59)
                {
                    ManageUserTimer.Stop();
                    ManageUsersMenuExpand = false;
                    
                }
            }
           
        }

        private void btn_ManageUsers_Click(object sender, EventArgs e)
        {
            ManageUserTimer.Start();
            if (TransactionMenuExpand == true)
            {
                TransactionMenuTransitionTimer.Start();
            }
        }

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_Menu_Click(object sender, EventArgs e)
        {   

            if (SideBarExpand == false)
            {
                SideBarExpand = true;
                SideBarControlsRefresh();
                lblMenu.Visible = true;
                MenuSideBar.Visible = true;    
            }
            else
            {
            
                SideBarExpand = false;
                SideBarControlsRefresh();
                lblMenu.Visible = false;
                MenuSideBar.Visible = false;
        
            }
        }

        private void btn_AddNewClient_Click(object sender, EventArgs e)
        {
           LoadPage(new ctrAddNewClient());
        }

        private void btn_LogoutUser_Click(object sender, EventArgs e)
        {
            clsLoginLogs.Logout(clsGlobal.LoginID);
            clsGlobal.History.Clear();
            clsGlobal.CurrentUser = null;
            clsGlobal.LoginID = 0;
            loginUserForm.Show();     
            this.Dispose();
        }

        private void btn_ShowClientList_Click(object sender, EventArgs e)
        {
            ctrShowList ctrShowClientList = new ctrShowList();
            ctrShowClientList.Subscribe(clsClient.GetAllClientsasync);
            ctrShowClientList.SetLabel("Client List");
           
            LoadPage(ctrShowClientList);
        }

        private void btn_FindClient_Click(object sender, EventArgs e)
        {
            ctrlGeneralOperations FindClient = new ctrlGeneralOperations();
            FindClient.Mode= ctrlGeneralOperations.enMode.FindClients;
           
            LoadPage(FindClient);
        }

        private void btn_LoginRegisters_Click(object sender, EventArgs e)
        {        
            ctrShowList ctrShowLoginRegisters = new ctrShowList();
            ctrShowLoginRegisters.Subscribe(clsLoginLogs.GetAllWithPagination);
            ctrShowLoginRegisters.SetLabel("LoginRegisters");
           
            LoadPage(ctrShowLoginRegisters);
           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ctrlGeneralOperations DeleteClient = new ctrlGeneralOperations();
            DeleteClient.Mode = ctrlGeneralOperations.enMode.DeleteClients;
         
            LoadPage(DeleteClient);
        }

        private void btn_UpdateClient_Click(object sender, EventArgs e)
        {
            ctrlGeneralOperations UpdateClient = new ctrlGeneralOperations();
            UpdateClient.Mode = ctrlGeneralOperations.enMode.UpdateClients;
         
            LoadPage(UpdateClient);
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {    
            ctrDeposit_Withdraw ctrDeposit= new ctrDeposit_Withdraw();
            ctrDeposit.Mode = ctrDeposit_Withdraw.enMode.Deposit;
 
            LoadPage(ctrDeposit);      
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            ctrDeposit_Withdraw ctrWithdraw = new ctrDeposit_Withdraw();
            ctrWithdraw.Mode = ctrDeposit_Withdraw.enMode.Withdraw;
           
            LoadPage(ctrWithdraw);    
        }

        private void btn_TotalBalances_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "The Total Balances is : "+Convert.ToString(clsAccounts.GetTotalBalance()));
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
           LoadPage(new ctrTransfer());
        }

        private void btn_TransferLog_Click(object sender, EventArgs e)
        {
            //ctrShowList ctrShowList = new ctrShowList();
            //ctrShowList.Subscribe(clsTransactionsBusiness.GetTransfersPaged);
            //ctrShowList.SetLabel("Transfer Registers");
            ctrShowtransactionLogs ctrlShow = new ctrShowtransactionLogs();
            LoadPage(ctrlShow);     
        }

        private void btn_UsersList_Click(object sender, EventArgs e)
        {        
            ctrShowList ctrShowList = new ctrShowList();
            ctrShowList.Subscribe(clsUser.GetAllUsers);
            ctrShowList.SetLabel("Users List");
          
            LoadPage(ctrShowList);
        }

        private void btn_AddNewUser_Click(object sender, EventArgs e)
        {   
           LoadPage(new ctrAddNewUser());   
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            ctrlGeneralOperations DeleteUser = new ctrlGeneralOperations();
            DeleteUser.Mode = ctrlGeneralOperations.enMode.DeleteUsers;
            LoadPage(DeleteUser);
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            //updateUserForm = new UpdateUserForm();
            //updateUserForm.ShowDialog();

            ctrlGeneralOperations ctrlGeneral = new ctrlGeneralOperations();
            ctrlGeneral.Mode = ctrlGeneralOperations.enMode.UpdateUsers;
           //  ctrlGeneral.OnClose += OnClose_Back; 
           LoadPage(ctrlGeneral);

        }

        private void btn_FindUser_Click(object sender, EventArgs e)
        {
            //findUserForm = new FindUserForm();
            //findUserForm.ShowDialog();

            ctrlGeneralOperations ctrlSearch = new ctrlGeneralOperations();
            ctrlSearch.Mode = ctrlGeneralOperations.enMode.FindUsers;
           //   DeleteUser.OnClose += OnClose_Back;
           LoadPage(ctrlSearch);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // guna2HtmlLabel1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timerForTime.Start();
            MenuSideBar.Visible = false;
            MenuSideBar.AutoScroll = true;
            MenuSideBar.VerticalScroll.Visible = true;
            MenuSideBar.HorizontalScroll.Visible = false;
            MenuSideBar.HorizontalScroll.Enabled = false;

        }

        private void btn_CurrencyExchange_Click(object sender, EventArgs e)
        { 
         //   ctrCurrencyExchange.OnClose += OnClose_Back;
            LoadPage(new ctrCurrencyExchange());
        }

        private void btn_ManagmentDashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new ctrManagment());
        }

        private void btn_About_us_Click(object sender, EventArgs e)
        { 
            LoadPage(new ctrAboutMe());
        }

    }
}
