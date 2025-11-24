using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Common;
using Data_Access_Layer;
using Mapster;

namespace Business_Layer
{

    public class clsClient : clsPerson, IEntityActions
    {
        enum enMode { AddNew = 0, Update = 1 };

        enMode Mode = enMode.AddNew;
        public enum enType { Individual = 1, Company = 2, VIP = 3, Government = 4 }

        public DateTime RegistrationDate { get; set; }
        public int ClientTypeID { get; set; }
        public int PersonID { get; set; }

        public clsClient()
        {
            this.ID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
            this.PhotoPath = string.Empty;
            this.DateOfBirth = null;
            this.NationalID = string.Empty;
            this.Gender =string.Empty;
            this.Address = new clsAddress();
            this.RegistrationDate = DateTime.Now;
            this.ClientTypeID = -1;
            this.PersonID = -1;

            this.Mode = enMode.AddNew;
        }

        public static clsClient Find(int ID)
        {
            ClientDTO clientDTO = clsClientDataAccess.FindClient(ID);
           
            if (clientDTO!=null)
            {
                clsClient Client = clientDTO.Adapt<clsClient>();
                Client.Mode = enMode.Update;
                Client.Address = clsAddress.Find(clientDTO.Address.ID);
                return Client;    
            }

            return null;
        }

        public static clsClient FindByNationalID(string NationalID)
        {    
            ClientDTO clientDTO = clsClientDataAccess.FindClientByNationalID(NationalID);
            if (clientDTO != null)
            {
                clsClient Client = clientDTO.Adapt<clsClient>();
                Client.Address = clsAddress.Find(clientDTO.Address.ID);
                Client.Mode = enMode.Update;
                return Client;
            }

            return null;
        }

        public async static Task<(DataTable, int)> GetAllClientsasync(short PageNumber, short PageSize)
        {
            return await clsClientDataAccess.GetAllClients(PageNumber, PageSize);
        }

        public static DataTable SearchWithNationalID(string NationalID, short PageNumber, short PageSize, ref int TotalRows)
        {
            return clsClientDataAccess.SearchWithNationalID(NationalID, PageNumber, PageSize, ref TotalRows);
        }

        public static DataTable SearchWithFirstName(string FirstName, short PageNumber, short PageSize, ref int TotalRows)
        {
            return clsClientDataAccess.SearchWithFirstName(FirstName, PageNumber, PageSize, ref TotalRows);
        }

        bool AddNewClient()
        {
            ClientDTO clientDTO = this.Adapt<ClientDTO>();

            this.ID = clsClientDataAccess.AddNewClient(ref clientDTO);
            this.PersonID = clientDTO.PersonID;
            return (this.ID != -1);
        }

        bool UpdateClient()
        {
            ClientDTO clientDTO = this.Adapt<ClientDTO>();
            return clsClientDataAccess.UpdateClient(clientDTO);
        }

        public bool Delete()
        {
            return clsClientDataAccess.DeleteClient(this.ID);
        }

        public static int TotalClientsNumber()
        {
            return clsClientDataAccess.TotalClientsNumber();
        }

        public static decimal AverageBalances()
        {
            return clsClientDataAccess.AverageBalances();
        }

        public static decimal TotalBalances()
        {
            return clsClientDataAccess.TotalBalances();
        }

        public static bool IsExist(int ID)
        {
            return clsClientDataAccess.IsExist(ID);
        }

        public int CloseAccounts()
        {
            return clsClientDataAccess.CloseAccounts(this.ID);
        }

        public bool Save()
        {
            if (this.Mode == enMode.AddNew)
            {
                return AddNewClient();
            }
            else
                return UpdateClient();
        }

    }
}
