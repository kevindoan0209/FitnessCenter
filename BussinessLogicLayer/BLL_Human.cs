using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Human
    {
        private static readonly DAL_Human _human = new DAL_Human();
        public static DataTable Login(string userName, string passWord)
        {
            return _human.Login(userName, passWord);
        }

        public static int InsertAccount(string name, string username, string password, string image, int type)
        {
            return _human.InsertAccount(name, username, password, image, type);
        }

        public static int InsertAccountNoImage(string name, string username, string password, int type)
        {
            return _human.InsertAccountNoImage(name, username, password, type);
        }

        public static int UpdateAccount(int id, string name, string username, string password, string image, int type)
        {
            return _human.UpdateAccount(id, name, username, password, image, type);
        }

        public static int UpdateAccountNoImage(int id, string name, string username, string password, int type)
        {
            return _human.UpdateAccountNoImage(id, name, username, password, type);
        }

        public static int UpdateAccountPassword(int id, string name, string password)
        {
            return _human.UpdateAccountPassword(id, name, password);
        }

        public static DataTable Select_Username(string username)
        {
            return _human.Select_Username(username);
        }

        public static DataTable Select_CheckUserNameSoftware(string username)
        {
            return _human.Select_CheckUserNameSoftware(username);
        }

        public static int UpdateAccountStatus(int id, string status)
        {
            return _human.UpdateAccountStatus(id, status);
        }

        public static int GetLastIdAccount()
        {
            return _human.GetLastIdAccount();
        }
        public static int GetLastIdCustomer()
        {
            return _human.GetLastIdCustomer();
        }

        public static int InsertCustomerImage(string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, DateTime startDate, DateTime endDate, string image)
        {
            return _human.InsertCustomerImage(name, age, sex, email, phone, job, address, memberId, note, startDate, endDate, image);
        }
        public static int InsertCustomerNoImage(string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, DateTime startDate, DateTime endDate)
        {
            return _human.InsertCustomerNoImage(name, age, sex, email, phone, job, address, memberId, note, startDate, endDate);
        }

        public static int UpdateCustomerImage(int id, string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, DateTime startDate, DateTime endDate, string image)
        {
            return _human.UpdateCustomerImage(id, name, age, sex, email, phone, job, address, memberId, note, startDate, endDate, image);
        }
        public static int UpdateCustomerNoImage(int id, string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, DateTime startDate, DateTime endDate)
        {
            return _human.UpdateCustomerNoImage(id, name, age, sex, email, phone, job, address, memberId, note, startDate, endDate);
        }



    }
}
