using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Payment
    {
        private static readonly DAL_Payment _payment = new DAL_Payment();
        public static int InsertPayment(int cusId, DateTime startDate, DateTime endDate, int totalAmount, string note)
        {
            return _payment.InsertPayment(cusId, startDate, endDate, totalAmount, note);
        }

        public static int UpdatePayment(int id, int cusId, DateTime startDate, DateTime endDate, int totalAmount, string note)
        {
            return _payment.UpdatePayment(id, cusId, startDate, endDate, totalAmount, note);
        }

        public static int GetLastIdPayment()
        {
            return _payment.GetLastIdPayment();
        }

        public static int DeletePayment(int cusId)
        {
            return _payment.DeletePayment(cusId);
        }
    }
}
