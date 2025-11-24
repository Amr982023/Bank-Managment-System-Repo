using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class TransferDTO
    {
       public string SourceAccountNumber { get; set; }
       public string DestinationAccountNumber { get; set; }
       public decimal Amount { get; set; }
       public int CreatedByUserId {  get; set; }
       public int DestinationBankID   { get; set; }

       public string Description = "";
    }
}
