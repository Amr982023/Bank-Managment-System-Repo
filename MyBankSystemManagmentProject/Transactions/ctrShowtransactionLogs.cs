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

namespace MyBankSystemManagmentProject.Transactions
{
    public partial class ctrShowtransactionLogs : UserControl
    {
        public ctrShowtransactionLogs()
        {
            InitializeComponent();
        }

        private short CurrentPageNumber = 1;
        private short PageSize = 15;
        private int TotalRecords = 0;

        Func<short, short, Task<(DataTable, int)>> FunctionalMethod;

        void _Back()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
            {
                clsGlobal.History.Pop();
            }
            this.Dispose();

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

        private async void ctrShowtransactionLogs_Load(object sender, EventArgs e)
        {
            dgv_ShowClientList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cb_Selection.SelectedIndex = 0;
            await RefreshForm();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            _Back();
        }

        private async void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FunctionalMethod = null;
            if (cb_Selection.SelectedIndex == 1)
            {
                FunctionalMethod += clsTransactionsBusiness.GetTransfersPaged;
                await RefreshForm();

            }
            else if (cb_Selection.SelectedIndex == 2)
            {
                FunctionalMethod += clsTransactionsLogs.GetWithdrawTransactionsWithPagination;
                await RefreshForm();
            }
            else if (cb_Selection.SelectedIndex == 3)
            {
                FunctionalMethod += clsTransactionsLogs.GetDepositTransactionsWithPagination;
                await RefreshForm();
            }
            else
            {
                FunctionalMethod += clsTransactionsLogs.GetAllWithPagination;
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

        private async void btn_Previous_Click(object sender, EventArgs e)
        {
            if (CurrentPageNumber > 1)
            {
                CurrentPageNumber--;
                await RefreshForm();
            }
        }

    }
}
