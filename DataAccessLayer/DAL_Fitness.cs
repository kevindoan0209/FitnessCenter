using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Fitness:DbConection
    {
        public int InsertFitnessCenter(string name, string tel, string email, string address, string facebook)
        {
            const String sqlCommand = "Insert into FitnessCenter (FitnessCenter_Name,FitnessCenter_Tel,FitnessCenter_Email,FitnessCenter_Address,FitnessCenter_Facebook) Values(@Name, @Tel, @Email, @Address, @Facebook)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Tel", tel);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Facebook", facebook);
            return command.ExecuteNonQuery();
        }

        public int UpdateFitnessCenter(string name, string tel, string email, string address, string facebook)
        {
            const String sqlCommand = "Update FitnessCenter set FitnessCenter_Name = @Name, FitnessCenter_Email = @Email, FitnessCenter_Tel = @Tel, FitnessCenter_Address = @Address, FitnessCenter_Facebook = @Facebook Where FitnessCenter_ID = '1'";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Tel", tel);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Facebook", facebook);
            return command.ExecuteNonQuery();
        }
    }
}
