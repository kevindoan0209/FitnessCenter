using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Membership:DbConection
    {
        public int InsertMembership(string name, int price, string note)
        {
            const String sqlCommand = "Insert into Membership (Membership_Name,Membership_Price,Membership_Note) Values(@Name, @Price, @Note)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }

        public int UpdateMembership(int id,string name, int price, string note)
        {
            const String sqlCommand = "Update Membership set Membership_Name =@Name, Membership_Price = @Price, Membership_Note = @Note Where Membership_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }
    }
}
