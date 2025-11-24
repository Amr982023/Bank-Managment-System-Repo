using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;

namespace Common
{
    public class UserDTO:PersonDTO
    {
        public string UserName { get; set; }
        public int Permission { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }

    }
}
