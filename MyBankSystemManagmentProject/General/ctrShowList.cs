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
    public partial class ctrShowList : UserControl
    {     
        public ctrShowList()
        {   
            InitializeComponent();
        }

        private short CurrentPageNumber = 1;
        private short PageSize = 15;
        private int TotalRecords = 0;

        public enum enList {ShowClientList,ShowUserList,LoginRegisters,TransferLog}; 

        void _Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
            this.Dispose();
        
        }

        Func<short, short, Task<(DataTable, int)>> FunctionalMethod;

        public void Subscribe(Func<short, short, Task<(DataTable, int)>> TargetMethod)
        {
            FunctionalMethod += TargetMethod;
        }

        public void SetLabel(string LabelText)
        {
            lbl_ShowList.Text = LabelText;
        }

        async Task RefreshForm()
        {
            var (Table, totalRecords) = await FunctionalMethod.Invoke(CurrentPageNumber, PageSize);

            dgv_ShowClientList.DataSource = Table;

            TotalRecords = totalRecords;

            dgv_ShowClientList.DataSource = Table;
            label2.Text = TotalRecords != 0
                    ? $"Page {CurrentPageNumber} From {Math.Ceiling((double)TotalRecords / PageSize)}"
                    : $"Page {CurrentPageNumber} From 1";

            btn_Previous.Enabled = CurrentPageNumber > 1;
            btn_Next.Enabled = CurrentPageNumber < Math.Ceiling((double)TotalRecords / PageSize);
        }

        private async void ctrShowClientList_Load(object sender, EventArgs e)
        {
            dgv_ShowClientList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await RefreshForm();
        }

        private async void btn_Previous_Click(object sender, EventArgs e)
        {
            if (CurrentPageNumber > 1)
            {
                CurrentPageNumber--;
               await RefreshForm();
            }
        }

        private async void btn_Next_Click(object sender, EventArgs e)
        {
            if (CurrentPageNumber < Math.Ceiling((double)TotalRecords / PageSize))
            {
                CurrentPageNumber++;
               await RefreshForm();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {  
            _Back();
        }

    }
}
