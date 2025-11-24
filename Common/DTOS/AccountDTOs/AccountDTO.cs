using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class AccountDTO
    {
        public int ID { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }

        public int StatusID { get; set; }
        public int CurrencyID { get; set; }
        public int AccountTypeID { get; set; }
        public int ClientID { get; set; }

        public DateTime? LastFeeProcessedDate { get; set; }

        public DateTime? LastTransactionDate { get; set; }


    }
}
