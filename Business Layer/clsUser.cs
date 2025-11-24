using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Common;
using Data_Access_Layer;
using Mapster;

namespace Business_Layer
{
    public class clsUser:clsPerson,IEntityActions
    {     
         enum enMode { AddNew = 0, Update = 1 };

         enMode Mode = enMode.AddNew;

        public string UserName { get; set; }
        public int Permission { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }

        public clsUser()
        {
            
            this.ID = -1;
            this.Permission = -1;
            this.FirstName =string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName =string.Empty;
            this.Email = string.Empty;
            this.PhotoPath = string.Empty;
            this.DateOfBirth = null;
            this.NationalID = string.Empty;
            this.Gender = string.Empty;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.Address =new clsAddress();
            this.PersonID = -1;
            this.Mode = enMode.AddNew;
        }

        public static clsUser Find(int ID)
        {
            UserDTO userDTO = clsUserDataAccess.FindUser(ID);
            if (userDTO != null)
            {
                clsUser User = userDTO.Adapt<clsUser>();
                User.Address = clsAddress.Find(User.Address.ID);
                User.Mode = enMode.Update;              
                return User;     
            }
            return null;
        }

        public static clsUser Find(string UserName)
        { 
            UserDTO userDTO = clsUserDataAccess.FindUserWithUserName(UserName);

            if (userDTO != null)
            {
                clsUser User = userDTO.Adapt<clsUser>();
                User.Address = clsAddress.Find(User.Address.ID);
                User.Mode = enMode.Update;
                return User;
            }
            return null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            Password= clsSecurity.HashPassword(Password);
            UserDTO userDTO = clsUserDataAccess.FindByUserNameAndPassword(UserName, Password);

            if (userDTO != null)
            {
                clsUser User = userDTO.Adapt<clsUser>();
                User.Address = clsAddress.Find(User.Address.ID);
                User.Mode = enMode.Update;
                return User;            
            }
            return null;
        }

        public static DataTable SearchWithUserName(string UserName, short PageNumber, short PageSize, ref int TotalRows)
        {
            return clsUserDataAccess.SearchWithUserName( UserName,  PageNumber,  PageSize, ref  TotalRows);
        }

        public static DataTable SearchWithFirstName(string FirstName, short PageNumber, short PageSize, ref int TotalRows)
        {
            return clsUserDataAccess.SearchWithFirstName(FirstName, PageNumber, PageSize, ref TotalRows);
        }

        public async static Task<(DataTable,int)> GetAllUsers(short PageNumber, short PageSize)
        {
            return await clsUserDataAccess.GetAllUsersWithPaging( PageNumber, PageSize);
        }

        bool AddNew()
        {
            this.Password = clsSecurity.HashPassword(this.Password);
            UserDTO userDTO = this.Adapt<UserDTO>();
            this.ID = clsUserDataAccess.AddNewUser(ref userDTO);
            this.PersonID = userDTO.PersonID;

            return (this.ID != -1);
        }

        bool Update()
        {      
            UserDTO userDTO = this.Adapt<UserDTO>();
            return clsUserDataAccess.UpdateUser(userDTO);
        }

        public bool Delete()
        {
            return clsUserDataAccess.DeleteUser(this.ID);
        }

        public static bool IsExistByUserName(string UserName)
        {
            return clsUserDataAccess.IsExist(UserName);
        }
       
        public bool Save()
        {
            if (this.Mode == enMode.AddNew)                      
                return AddNew();
            else
                return Update();      
          
        }

    }
}
