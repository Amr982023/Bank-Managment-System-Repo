using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using Data_Access_Layer;

namespace Business_Layer
{
    public class ClientServices
    {
        public static (bool Success, string Message, int PersonId, int ClientId, int AccountId, int CardId)AddNewClient_FullTransaction(NewClientDTO dto)
        {
            // ------------------------------
            // 1. Validation (optional)
            // ------------------------------
            if (dto == null)
                return (false, "Client data cannot be null.", 0, 0, 0, 0);

            if (string.IsNullOrWhiteSpace(dto.FirstName))
                return (false, "First name is required.", 0, 0, 0, 0);

            if (string.IsNullOrWhiteSpace(dto.LastName))
                return (false, "Last name is required.", 0, 0, 0, 0);

            if (dto.NationalID?.Length != 14)
                return (false, "NationalID must be 14 characters.", 0, 0, 0, 0);

            if (!string.IsNullOrWhiteSpace(dto.CardNumber) && dto.CardNumber.Length != 16)
                return (false, "Card number must be 16 digits.", 0, 0, 0, 0);

            if (dto.CurrencyID <= 0 || dto.AccountTypeID <= 0)
                return (false, "Invalid Account or Currency type.", 0, 0, 0, 0);
          
            // ------------------------------
            // 2. Call DAL
            // ------------------------------
            var result = clsClientDataAccess.AddNewClient_FullTransaction(dto);
            // ------------------------------
            // 3. Add Phones
            // ------------------------------
            if (result.Success == true)
            {
                foreach (var phoneNumber in dto.Phones.Where(p => !string.IsNullOrEmpty(p)))
                {
                    var phone = new clsPhones { PersonID = result.PersonId, Number = phoneNumber };
                    phone.Save();
                }
            }

                return result;
        }
 
        public static bool UpdateClient(UpdateClientDTO dto, out string errorMessage)
        {
            errorMessage = "";

            var client = clsClient.FindByNationalID(dto.NationalID);
            if (client == null)
            {
                errorMessage = "Client not found!";
                return false;
            }

            client.FirstName = dto.FirstName;
            client.SecondName = dto.SecondName;
            client.ThirdName = dto.ThirdName;
            client.LastName = dto.LastName;
            client.Email = dto.Email;
            client.PhotoPath = dto.PhotoPath;
            client.NationalID = dto.NewNationalID;
            client.ClientTypeID = dto.ClientTypeID;
            client.Gender = dto.Gender;
            client.DateOfBirth = dto.DateOfBirth;

            var address = clsAddress.Find(client.Address.ID);
            address.Country = clsCountry.GetCountry(dto.CountryID);
            address.Street = dto.Street;
            address.City = dto.City;
            address.Save();

            client.Address = address;

            foreach (var phone in dto.Phones.Where(p => !string.IsNullOrWhiteSpace(p)))
            {
                var existing = clsPhones.FindPhoneByNumber(phone);
                if (existing == null)
                {
                    var ph = new clsPhones
                    {
                        Number = phone,
                        PersonID = client.PersonID
                    };
                    ph.Save();
                }
            }
            return client.Save();
        }


    }

}
