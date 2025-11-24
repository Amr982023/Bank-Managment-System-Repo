using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;

namespace Common
{

    public class ClientDTO : PersonDTO
    {
        public DateTime? RegistrationDate { get; set; }
        public int ClientTypeID { get; set; }
        public int PersonID { get; set; }

    }


}
