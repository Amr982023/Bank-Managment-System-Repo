using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class BeneficiaryDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClientID { get; set; }
        public string AccountNumber {  get; set; }
        public int BankID { get; set;}
        public string IBAN { get; set; }
        public string NationalID { get; set; }

    }
}
