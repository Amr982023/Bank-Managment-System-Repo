using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTOS;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsBeneficiaries
    {
        public static bool ISExist(BeneficiaryDTO DTO)
        {
           return clsBeneficiariesDataAccess.IsExist(DTO);
        }

        public static bool AddNewBeneficiary(BeneficiaryDTO DTO)
        {
            return clsBeneficiariesDataAccess.AddNewBeneficiary(DTO) != -1;
        }
        
    }
}
