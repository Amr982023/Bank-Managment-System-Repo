using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class NewClientDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NationalID { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhotoPath { get; set; }

        public int ClientTypeID { get; set; }
        public int CountryID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public List<string> Phones { get; set; } = new List<string>();

        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public int CurrencyID { get; set; }
        public int AccountTypeID { get; set; }

        public int CardTypeID { get; set; }
        public int NetworkTypeID { get; set; }
        public string CardPassword { get; set; }

        public string CardNumber { get; set; }
    }

}
