using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class UpdateUserDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public string NationalID { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Address
        public int AddressId { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        // Phones
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        // Permission
        public int Permission { get; set; }
    }
}
