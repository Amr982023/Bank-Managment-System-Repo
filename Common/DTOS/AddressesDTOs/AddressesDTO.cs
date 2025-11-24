using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOS
{
    public class AddressDTO
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public CountryDTO Country { get; set; }
    }
}
