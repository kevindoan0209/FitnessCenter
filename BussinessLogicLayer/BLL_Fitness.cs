using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Fitness
    {
        private static readonly DAL_Fitness _fitness = new DAL_Fitness();

        public static int InsertFitnessCenter(string name, string tel, string email, string address, string facebook)
        {
            return _fitness.InsertFitnessCenter(name, tel, email, address, facebook);
        }

        public static int UpdateFitnessCenter(string name, string tel, string email, string address, string facebook)
        {
            return _fitness.UpdateFitnessCenter(name, tel, email, address, facebook);
        }
    }
}
