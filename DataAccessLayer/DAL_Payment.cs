using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Payment:DbConection
    {
        public int InsertPayment(int cusId, DateTime startDate, DateTime endDate, int totalAmount , string note,DateTime expireDate)
        {
            const String sqlCommand = "Insert into Payment(Customer_ID,StartDate,EndDate,TotalAmount,Payment_Note,ExpireDate) Values(@CusId, @StartDate, @EndDate, @TotalAmount, @Note, @ExpireDate)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@CusId", cusId);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@TotalAmount", totalAmount);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@ExpireDate", expireDate);
            return command.ExecuteNonQuery();
        }

        public int UpdatePayment(int id, int cusId, DateTime startDate, DateTime endDate, int totalAmount, string note,DateTime expireDate)
        {
            const String sqlCommand = "Update Payment set StartDate = @StartDate,EndDate = @EndDate,TotalAmount = @TotalAmount, Payment_Note = @Note,ExpireDate = @ExpireDate  Where Payment_ID = @Id and Customer_ID = @CusId ";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@CusId", cusId);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@TotalAmount", totalAmount);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@ExpireDate", expireDate);
            return command.ExecuteNonQuery();
        }

        public int GetLastIdPayment()
        {
            const String sqlCommand = "SELECT IDENT_CURRENT('Payment') as LastID";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            int temp = int.Parse(command.ExecuteScalar().ToString());
            return temp;
        }

        public int DeletePayment(int cusId)
        {
            const String sqlCommand = "DELETE FROM Payment WHERE Customer_ID = @CusId";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@CusId", cusId);
            return command.ExecuteNonQuery();
        }

        public int GetTotalMoney(int memberTypeId)
        {
            const String sqlCommand = "Select Membership_Price from Membership where Membership_ID = @MemberTypeId";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@MemberTypeId", memberTypeId);
            int temp = int.Parse(command.ExecuteScalar().ToString());
            return temp;
        }
    }
}
