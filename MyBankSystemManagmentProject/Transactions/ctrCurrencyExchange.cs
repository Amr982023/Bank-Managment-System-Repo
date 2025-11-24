using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Common;
using Common.DTOS;

namespace MyBankSystemManagmentProject
{
    public partial class ctrCurrencyExchange : UserControl
    {
        public ctrCurrencyExchange()
        {
            InitializeComponent();
            BindCurrencyComboBox(cb_SourceCurrency, "Code", "ID");
            BindCurrencyComboBox(cb_DestinationCurrency, "Code", "ID");
            BindCurrencyComboBox(comboBoxSourceCurrency, "Code", "Code");
            BindCurrencyComboBox(comboBoxTargetCurrency, "Code", "Code");
        }

        #region Helpers

        private void BindCurrencyComboBox(ComboBox comboBox, string displayMember, string valueMember)
        {
            comboBox.DataSource = clsCurrency.GetAllCurrencies();
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        private double CalculateExchange(double amount, double rateSource, double rateTarget)
        {
            if (rateSource == 0)
                throw new DivideByZeroException("Rate source cannot be zero.");

            return amount * (rateTarget / rateSource);
        }

        private void ShowMessage(string message, bool isError = false)
        {
            if (isError)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, message, "Application");
                clsErrorEvents.onError(message);
            }
            MessageBox.Show(message);
        }

        #endregion

        #region Currency Updates

        private async Task UpdateCurrencies()
        {
            try
            {
                if (clsCurrency.LastUpdate()?.Date != DateTime.Today)
                {
                    var content = await CurrencyExchangeApiService.GetExchangeRatesAsync();
                    if (content != null)
                        clsCurrency.SaveCurrencyRates(content.quotes, DateTime.Today);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Failed to update currencies: " + ex.Message, true);
            }
        }

        #endregion

        #region Events

        private void btn_Exchange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txt_ExchangeAmount.Text, out double sourceAmount))
                {
                    ShowMessage("Invalid source amount", true);
                    return;
                }

                string sourceCurrencyCode = cb_SourceCurrency.Text;
                string destCurrencyCode = cb_DestinationCurrency.Text;

                double rateSource = clsCurrency.GetLatestCurrencyRateByCode(sourceCurrencyCode);
                double rateTarget = clsCurrency.GetLatestCurrencyRateByCode(destCurrencyCode);

                double amountInTarget = CalculateExchange(sourceAmount, rateSource, rateTarget);

                txt_DestinationAmount.Text = $"{amountInTarget:F2} {destCurrencyCode}";

                var dto = new CurrencyExchangeDTO
                {
                    Amount = sourceAmount,
                    Rate = rateTarget / rateSource,
                    SourceCurrency = Convert.ToInt32(cb_SourceCurrency.SelectedValue),
                    DestinationCurrency = Convert.ToInt32(cb_DestinationCurrency.SelectedValue),
                    CreatedBy = clsGlobal.CurrentUser.ID
                };

                if (!clsCurrencyExchange.AddCurrencyExchange(dto))
                    ShowMessage("The Currency Exchange Process has not been recorded in log", true);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, true);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) => ShowTargetRate();
        private void comboBoxSourceCurrency_SelectedIndexChanged(object sender, EventArgs e) => ShowTargetRate();
        private void comboBoxTargetCurrency_SelectedIndexChanged(object sender, EventArgs e) => ShowTargetRate();
        private void ShowTargetRate()
        {
            try
            {
                if (!double.TryParse(txt_SourceAmount.Text, out double sourceAmount))
                {
                    txt_Target.Text = "Invalid Amount";
                    return;
                }

                if (comboBoxSourceCurrency.SelectedValue == null || comboBoxTargetCurrency.SelectedValue == null)
                {
                    txt_Target.Text = "0.0";
                    return;
                }

                string sourceCurrencyCode = comboBoxSourceCurrency.SelectedValue.ToString();
                string targetCurrencyCode = comboBoxTargetCurrency.SelectedValue.ToString();

                double rateSource = clsCurrency.GetLatestCurrencyRateByCode(sourceCurrencyCode);
                double rateTarget = clsCurrency.GetLatestCurrencyRateByCode(targetCurrencyCode);

                double targetAmount = CalculateExchange(sourceAmount, rateSource, rateTarget);
                txt_Target.Text = $"{targetAmount:F2} {targetCurrencyCode}";
            }
            catch (Exception ex)
            {
                Common.clsEventLogger.Event_Logger(EventLogEntryType.Error, ex.Message, "Application");
                clsErrorEvents.onError(ex.Message);
            }
        }
        private async void ctrCurrencyExchange_Load(object sender, EventArgs e) => await UpdateCurrencies();
        private void guna2Button1_Click(object sender, EventArgs e) => CloseControl();
        private void btn_Back_Click(object sender, EventArgs e) => CloseControl();
        private void CloseControl()
        {
            clsGlobal.Form.LoadPage(clsGlobal.History.Peek());
            if (clsGlobal.History.Count > 1)
                clsGlobal.History.Pop();
            this.Dispose();
        }

        #endregion

    }
}
