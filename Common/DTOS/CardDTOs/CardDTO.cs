using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class CardDTO
    {
        public int ID { get; set; }
        public int Card_Status_ID { get; set; }
        public int Account_ID { get; set; }
        public int Card_Type_ID { get; set; }
        public int Card_Network_ID { get; set; }


        public string Card_Number { get; set; }
        public DateTime? Expiration_Date { get; set; }
        public string Password { get; set; }
    }
}
