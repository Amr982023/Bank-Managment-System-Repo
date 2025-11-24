using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using Data_Access_Layer;
using Mapster;

namespace Business_Layer
{
    public class clsAddress: IEntityActions
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public clsCountry Country { get; set; }

        public string FullAddress { get { return Street + " Street - " + City + " - " + Country.Name; } }

        enum Mode {AddNew=1,Update=2}

        private Mode _Mode;

        public clsAddress() { 
        
            ID = -1;
            City = string.Empty;
            Street = string.Empty;
            _Mode = Mode.AddNew;
        }

        public static clsAddress Find (int ID)
        {
            AddressDTO AddressDTO = clsAddressesDataAccess.Find(ID);
            if (AddressDTO != null)
            {
                clsAddress Address = AddressDTO.Adapt<clsAddress>();
                Address._Mode = Mode.Update;
                Address.Country = clsCountry.GetCountry(Address.Country.CountryID).Adapt<clsCountry>();
                return Address;
            }
            return null;
        }

        private bool AddNew()
        {
            AddressDTO addressDTO = this.Adapt<AddressDTO>();
            this.ID = clsAddressesDataAccess.AddNew(addressDTO);
            
                return this.ID != -1;
        }

        private bool Update()
        {
            AddressDTO DTO = this.Adapt<AddressDTO>();
            
            return clsAddressesDataAccess.Update(DTO);
        }

        public bool Delete()
        {
            return clsAddressesDataAccess.Delete(this.ID);
        }

        public bool Save()
        {
            if(_Mode==Mode.AddNew)
                return AddNew();
            else            
                return Update();
        }

        public static bool IsExist(int ID)
        {
            return clsAddressesDataAccess.IsExist(ID);
        }

    }
}
