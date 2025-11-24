using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class UpdateClientDTO
    {
        public string NationalID { get; set; }
        public string NewNationalID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClientTypeID { get; set; }
        public string PhotoPath { get; set; }
        public int CountryID { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public List<string> Phones { get; set; } = new List<string>();
    }

}
