using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class TransactionDTO
    {
       public string AccountNumber { get; set; }
       public decimal Amount { get; set; }
       public int CreatedByUserID { get; set; }
       public string Description { get; set; }
    }
}
