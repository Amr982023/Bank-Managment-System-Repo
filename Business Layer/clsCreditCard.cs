using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.DTOS;
using Data_Access_Layer;
using Mapster;

namespace Business_Layer
{
    public class clsCreditCard
    {

        public enum enStatus { Active = 1, PendingActivation = 2, Frozen = 3, Lost = 4, Expired = 5, Cancelled = 6, Reissued = 7 }
        public enum enType { DebitCard = 1, CreditCard = 2, PrepaidCard = 3, ChargeCard = 4 }

        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode = enMode.AddNew;
        public int ID { get; set; }
        public int Card_Status_ID { get; set; }
        public int Account_ID { get; set; }
        public int Card_Type_ID { get; set; }
        public int Card_Network_ID { get; set; }


        public string Card_Number { get; set; }
        public DateTime? Expiration_Date { get; set; }
        public string Password { get; set; }


        public clsCreditCard()
        {
            ID = -1;
            Card_Status_ID = 2;
            Card_Network_ID = -1;
            Account_ID = -1;
            Card_Type_ID = -1;

            Card_Number = string.Empty;
            Expiration_Date = DateTime.Now.AddYears(3);
            Password = string.Empty;

            _Mode= enMode.AddNew;
        }

        bool AddNewCard()
        {         
            this.Password = clsSecurity.HashPassword(this.Password);
            CardDTO DTO = this.Adapt<CardDTO>();
            this.ID = clsCardDataAccess.AddNewCard(DTO);
            return (this.ID != -1);
        }

        public static clsCreditCard GetCardByID(int CardID)
        {
            if (CardID <= 0)
                throw new ArgumentException("Invalid Card ID.");


            CardDTO DTO = clsCardDataAccess.GetCardByID(CardID);
            if (DTO == null)
                return null;


            clsCreditCard Card = DTO.Adapt<clsCreditCard>();
            Card._Mode = enMode.Update;
            return Card;
        }

        public static clsCreditCard GetCardByAccountID(int AccountID)
        {

            if (AccountID <= 0)
                throw new ArgumentException("Invalid Account ID.");


            CardDTO DTO = clsCardDataAccess.GetCardByAccountID(AccountID);
            if (DTO == null)
                return null;


            clsCreditCard Card = DTO.Adapt<clsCreditCard>();
            Card._Mode = enMode.Update;
            return Card;
        }

        bool Update_Card()
        {        
            CardDTO DTO = this.Adapt<CardDTO>();
            if (DTO == null)
                throw new ArgumentNullException(nameof(DTO));

            if (DTO.ID <= 0)
                throw new ArgumentException("Invalid Card ID.");

           
            return clsCardDataAccess.UpdateCard(DTO);
        }

        public bool Renew()
        {
            this.Expiration_Date = DateTime.Now.AddYears(3);
            return Update_Card();
        }

        public static bool Activate_Card(int CardID)
        {
            if (CardID <= 0)
                throw new ArgumentException("Invalid Card ID.");

            return clsCardDataAccess.Change_Card_Status(CardID, (int)enStatus.Active);
        }

        public static bool Freeze_Card(int CardID)
        {
            if (CardID <= 0)
                throw new ArgumentException("Invalid Card ID.");

            return clsCardDataAccess.Change_Card_Status(CardID, (int)enStatus.Frozen);
        }

        public static bool Cancel_Card(int CardID)
        {
            if (CardID <= 0)
                throw new ArgumentException("Invalid Card ID.");

            return clsCardDataAccess.Change_Card_Status(CardID, (int)enStatus.Cancelled);
        }

        public static bool Change_Status(int CardID,enStatus Status)
        {
            if (CardID <= 0)
                throw new ArgumentException("Invalid Card ID.");

            return clsCardDataAccess.Change_Card_Status(CardID,(int)enStatus.Cancelled);
        }

        public bool Cancel()
        {

            return clsCardDataAccess.Change_Card_Status(this.ID, (int)enStatus.Cancelled);
        }     
       
        public bool Save()
        {
            if (this._Mode == enMode.AddNew)

                return AddNewCard();
            else
                return Update_Card();
        }

    }
}
