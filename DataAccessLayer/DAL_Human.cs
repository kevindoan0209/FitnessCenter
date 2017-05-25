﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Human:DbConection
    {
        public DataTable Login(string userName, string password)
        {
            const String sqlCommand = "select * from Account where Account_Password = @PassWord and Account_UserName = @UserName";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@PassWord", password);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public DataTable Select_Username(string username)
        {
            const String sqlCommand = "Select * from Account where Account_UserName = @Username";
            SqlCommand cm = new SqlCommand(sqlCommand, connect());
            cm.Parameters.AddWithValue("@Username", username);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public int InsertAccount(string name, string username, string password, string image, int type)
        {
            const String sqlCommand = "Insert into Account (Account_Name,Account_UserName,Account_Password,Account_Image,Account_Type_ID) Values(@Name, @Username, @Password, @Image, @Type)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }

        public int InsertAccountNoImage(string name, string username, string password, int type)
        {
            const String sqlCommand = "Insert into Account (Account_Name,Account_UserName,Account_Password,Account_Type_ID) Values(@Name, @Username, @Password, @Type)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }

        public int UpdateAccount(int id, string name, string username, string password, string image, int type)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name, Account_UserName = @Username, Account_Password = @Password,Account_Image = @Image, Account_Type_ID = @Type Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }

        public int UpdateAccountNoImage(int id, string name, string username, string password, int type)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name, Account_UserName = @Username, Account_Password = @Password, Account_Type_ID = @Type Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Type", type);
            return command.ExecuteNonQuery();
        }

        public int UpdateAccountPassword(int id, string name, string password)
        {
            const String sqlCommand = "Update Account set Account_Name = @Name, Account_Password = @Password Where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Password", password);
            return command.ExecuteNonQuery();
        }

        private byte[] convertImagetoByte(String image)
        {
            FileStream fs;
            fs = new FileStream(image, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        public int GetLastIdAccount()
        {
            const String sqlCommand = "SELECT IDENT_CURRENT('Account') as LastID";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            int temp = int.Parse(command.ExecuteScalar().ToString());
            return temp;
        }

        public DataTable Select_CheckUserNameSoftware(string username)
        {
            const String sqlCommand = "Select * from Account where Account_UserName = @Username and Account_Type_ID <= 3";
            SqlCommand cm = new SqlCommand(sqlCommand, connect());
            cm.Parameters.AddWithValue("@Username", username);
            SqlDataAdapter data = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }

        public int UpdateAccountStatus(int id, string status)
        {
            const String sqlCommand = "Update Account set Account_Status = @Status where Account_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Status", status);
            return command.ExecuteNonQuery();
        }     
    }
}
