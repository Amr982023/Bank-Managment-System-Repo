using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Data_Access_Layer;
using Mapster;

namespace Business_Layer
{
    public class clsCountry
    {
        enum enMode { AddNew = 0, Update = 1 };

        public int CountryID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

         public clsCountry() 
        { 
            CountryID = -1;
            Name = "Unknown";
            Code = "Unknown";     
        }

        public static DataTable GetCountryList() 
        {
            return clsCountryDataAccess.GetAllCountries();
        }

        public static clsCountry GetCountry(int ID)
        {
            clsCountry Country = clsCountryDataAccess.GetCountry(ID).Adapt<clsCountry>();
            return Country;
        }

        public static CountryDTO GetCountryDTO(int ID)
        {
            return clsCountryDataAccess.GetCountry(ID);
        }

    }
}
