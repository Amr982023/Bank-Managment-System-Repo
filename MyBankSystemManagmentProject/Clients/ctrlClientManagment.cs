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
    public partial class ctrlClientManagment : UserControl
    {
        public ctrlClientManagment()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            clsGlobal.History.Pop();
            this.Dispose();
        }

        private void btn_AddNewClient_Click(object sender, EventArgs e)
        {
            ctrAddNewClient addNewClient = new ctrAddNewClient();
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(addNewClient);
        }

        private void btn_ShowClientList_Click(object sender, EventArgs e)
        {

            ctrShowList ctrShowClientList = new ctrShowList();
            ctrShowClientList.Subscribe(clsClient.GetAllClientsasync);
            ctrShowClientList.SetLabel("Client List");
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(ctrShowClientList);
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            ctrlGeneralOperations ctrGeneral = new ctrlGeneralOperations();
            ctrGeneral.Mode = ctrlGeneralOperations.enMode.DeleteClients;
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(ctrGeneral);
        }

        private void btn_UpdateClient_Click(object sender, EventArgs e)
        {
            ctrlGeneralOperations ctrGeneral = new ctrlGeneralOperations();
            ctrGeneral.Mode = ctrlGeneralOperations.enMode.UpdateClients;
            //  ctrGeneral.OnClose += OnClose_Back;
            clsGlobal.History.Push(this);
            clsGlobal.Form.LoadPage(ctrGeneral);
        }

        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            clsGlobal.LoadMainPage();
            this.Dispose();
        }
    }
}
