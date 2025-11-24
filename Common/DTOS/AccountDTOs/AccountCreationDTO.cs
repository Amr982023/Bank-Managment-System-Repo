using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
   
        public class AccountCreationDTO
        {
            public string NationalId { get; set; }
            public string AccountNumber { get; set; }
            public decimal Balance { get; set; }
            public int AccountTypeId { get; set; }
            public int CurrencyId { get; set; }
            public int CardTypeId { get; set; }
            public int CardNetworkId { get; set; }
            public string CardPassword { get; set; }
            public string CardNumber { get; set; }
    }

    
}
