using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class NewUserDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NationalID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }

        // Address
        public int CountryId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        // Phones
        public List<string> Phones { get; set; } = new List<string>();

        // Permissions
        public int Permission { get; set; }
    }

}
