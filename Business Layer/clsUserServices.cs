using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.DTOS;
using Mapster;

namespace Business_Layer
{
    public class UserServices
    {
        public static (bool IsSuccess, int UserId, string ErrorMessage) AddUser(NewUserDTO dto)
        {
            try
            {
                // 1. Create Address
                clsCountry Country = clsCountry.GetCountry(dto.CountryId);
                clsAddress Address = new clsAddress();
                Address.Country = Country;
                Address.City = dto.City;
                Address.Street = dto.Street;
                Address.Save();  
                if (!Address.Save())
                    return (false, 0, "Failed to save address.");

                // 2. Create User
                var user = new clsUser
                {
                    FirstName = dto.FirstName,
                    SecondName = dto.SecondName,
                    ThirdName = dto.ThirdName,
                    LastName = dto.LastName,
                    Email = dto.Email,
                    NationalID = dto.NationalID,
                    UserName = dto.UserName,
                    Password = dto.Password,
                    DateOfBirth = dto.DateOfBirth,
                    Gender = dto.Gender,
                    Address = Address,
                    Permission = dto.Permission,
                    PhotoPath = dto.PhotoPath
                };

                if (!user.Save())
                    return (false, 0, "Failed to save user.");

                // 3. Save Phones
                foreach (var phoneNumber in dto.Phones)
                {
                    var phoneObj = new clsPhones();
                    phoneObj.Number = phoneNumber;
                    phoneObj.PersonID= user.PersonID;
                    phoneObj.Save();
                }

                return (true, user.ID, null);
            }
            catch (Exception ex)
            {
                return (false, 0, ex.Message);
            }
        }

        public static (bool IsSuccess, string ErrorMessage, int UserId) UpdateUser(UpdateUserDTO dto)
        {
            try
            {
                var user = clsUser.Find(dto.UserName);

                if (user == null)
                    return (false, "User not found.", 0);

                // Update user data
                user.FirstName = dto.FirstName;
                user.SecondName = dto.SecondName;
                user.ThirdName = dto.ThirdName;
                user.LastName = dto.LastName;
                user.Email = dto.Email;
                user.PhotoPath = dto.PhotoPath;
                user.NationalID = dto.NationalID;
                user.UserName = dto.UserName;
                user.Gender = dto.Gender;
                user.DateOfBirth = dto.DateOfBirth;
                user.Permission = dto.Permission;

                // Update address
                var address = clsAddress.Find(dto.AddressId);
                if (address == null)
                    return (false, "Address not found.", 0);

                address.Country = clsCountry.GetCountry(dto.CountryId).Adapt<clsCountry>();
                address.City = dto.City;
                address.Street = dto.Street;
                address.Save();

                user.Address = address;

                // Phones
                if (clsPhones.FindPhoneByNumber(dto.Phone1) == null)
                {
                    var phone1 = new clsPhones
                    {
                        Number = dto.Phone1,
                        PersonID = user.PersonID
                    };
                    phone1.Save();
                }

                if (clsPhones.FindPhoneByNumber(dto.Phone2) == null)
                {
                    var phone2 = new clsPhones
                    {
                        Number = dto.Phone2,
                        PersonID = user.PersonID
                    };
                    phone2.Save();
                }

                // Save user
                bool success = user.Save();

                return success
                    ? (true, null, user.ID)
                    : (false, "Failed to update user.", 0);
            }
            catch (Exception ex)
            {
                return (false, $"Exception: {ex.Message}", 0);
            }
        }

    }
}




