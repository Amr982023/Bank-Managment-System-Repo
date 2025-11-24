using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Common.DTOS;
using Data_Access_Layer;

namespace Business_Layer
{
    
        public class clsPhones : IEntityActions
        {
            enum enMode { AddNew = 0, Update = 1 };
            enMode Mode = enMode.AddNew;
            public int ID { get; set; }
            public string Number { get; set; }
            public int PersonID { get; set; }

            public clsPhones()
            {
                this.ID = -1;
                this.Number = string.Empty;
                this.PersonID = -1;
                this.Mode = enMode.AddNew;
            }

            public static clsPhones Find(int ID)
            {
                PhoneDTO phoneDTO = clsPhoneDataAccess.FindPhone(ID);

                if (phoneDTO != null)
                {
                    clsPhones phone = phoneDTO.Adapt<clsPhones>();
                    phone.Mode = enMode.Update;
                    return phone;
                }
                return null;
            }

            public static clsPhones FindPhoneByNumber(string number)
            {
            PhoneDTO DTO = clsPhoneDataAccess.FindPhoneByNumber(number);
            if (DTO != null)
            {
                clsPhones Phone = DTO.Adapt<clsPhones>();
                Phone.Mode = enMode.Update;
                return Phone;
            }
            return null;
            }

            public static List<PhoneDTO> GetPhonesByPersonID(int PersonID)
            {
                 return clsPhoneDataAccess.GetPhonesByPersonID(PersonID);
            }
      
            public static async Task<DataTable> GetAllPhonesAsync(int PageNumber, int PageSize)
            {
                return await clsPhoneDataAccess.GetAllPhones();
            }

            bool AddNewPhone()
            {
                PhoneDTO phoneDTO = this.Adapt<PhoneDTO>();
                this.ID = clsPhoneDataAccess.AddNewPhone(phoneDTO);
                return (this.ID != -1);
            }

            bool UpdatePhone()
            {
                PhoneDTO phoneDTO = this.Adapt<PhoneDTO>();
                return clsPhoneDataAccess.UpdatePhone(phoneDTO);
            }

            public bool Delete()
            {
                return clsPhoneDataAccess.DeletePhone(this.ID);
            }

            public static bool DeletePhone(int id)
            {
                return clsPhoneDataAccess.DeletePhone(id);
            }

            public static bool IsExist(int ID)
            {
                return clsPhoneDataAccess.IsExist(ID);
            }

            public bool Save()
            {
                if (this.Mode == enMode.AddNew)
                {
                    
                        return AddNewPhone();
                }
                else
                {
                    return UpdatePhone();
                      
                }
               
            }

        }
}


