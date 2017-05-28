using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Membership
    {
        private static readonly DAL_Membership _membership = new DAL_Membership();

        public static int InsertMembership(string name, int price, string note)
        {
            return _membership.InsertMembership(name, price, note);
        }

        public static int UpdateMembership(int id, string name, int price, string note)
        {
            return _membership.UpdateMembership(id, name, price, note);
        }
    }
}
