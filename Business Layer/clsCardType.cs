using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public static class clsCardType
    {
        public static DataTable Get_Card_Type_List()
        {
            return clsCardTypeDataAccess.Get_Credit_Card_Types_List();
        }

    }
}
