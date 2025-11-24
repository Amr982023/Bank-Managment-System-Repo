using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public static class clsCreditCardNetworks
    {
        public static DataTable Get_Credit_Card_Networks_List()
        {
            return clsCreditCardNetworksDataAccess.Get_Credit_Card_Networks_List();
        }
    }
}
