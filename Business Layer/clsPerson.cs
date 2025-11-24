using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public abstract class clsPerson
    {  
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string NationalID { get; set; }
        public string Gender { get; set; }
        public clsAddress Address { get; set; }

        public static bool IsExist(string NationalID)
        {
            return clsPersonDataAccess.IsExist(NationalID);
        }

    }
}
