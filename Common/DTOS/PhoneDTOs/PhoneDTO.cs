using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class PhoneDTO
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public int PersonID { get; set; }

        public PhoneDTO()
        {
            this.ID = -1;
            this.Number = string.Empty;
            this.PersonID = -1;
        }

        public PhoneDTO(int id, string number, int personId)
        {
            this.ID = id;
            this.Number = number;
            this.PersonID = personId;
        }
    }
}
