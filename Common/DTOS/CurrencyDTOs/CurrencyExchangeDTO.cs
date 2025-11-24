using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class CurrencyExchangeDTO
    {
       public double Amount {  get; set; }
       public double Rate { get; set; }
       public int SourceCurrency { get; set; }
       public int DestinationCurrency { get; set; }
       public int CreatedBy { get; set; }
    }

}
