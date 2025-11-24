using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsCurrency
    {
        public int ID {  get; set; }

        public string Name { get; set; }

        public string CurrencyCode { get; set; }

        public clsCountry Country { get; set; }

        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyDataAccess.GetAllCurrencies();
        }

        public static clsCurrency GetCurrency(int id)
        {
            clsCurrency Currency = new clsCurrency();
            var (Code,Name,CountryID) =clsCurrencyDataAccess.GetCurrency(id);
            Currency.ID = id;
            Currency.Name = Name;
            Currency.CurrencyCode = Code;
            Currency.Country = clsCountry.GetCountry(CountryID);
            return Currency;
        }

        public static DateTime? LastUpdate()
        {
            return clsCurrencyDataAccess.LastUpdate();
        }

        public static void SaveCurrencyRates(Dictionary<string, double> quotes, DateTime Today)
        {
            clsCurrencyDataAccess.SaveCurrencyRates(quotes, Today);
        }

        public static double GetLatestCurrencyRateByCode(string currencyCode)
        {
           return clsCurrencyDataAccess.GetLatestCurrencyRateByCode(currencyCode);
        }

    }
}
