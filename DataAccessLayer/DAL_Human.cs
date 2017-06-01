using System;
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

        public DataTable LockAccess(int Id, string password)
        {
            const String sqlCommand = "select * from Account where Account_Password = @PassWord and Account_Id = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", Id);
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
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
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

        public int GetLastIdCustomer()
        {
            const String sqlCommand = "SELECT IDENT_CURRENT('Customer') as LastID";
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

        public int InsertCustomerNoImage(string name, DateTime age, string sex, string email, string phone, string job, string address,int memberId, string note, DateTime startDate, DateTime endDate)
        {
            const String sqlCommand = "Insert into Customer (Customer_Name,Customer_Age,Customer_Sex,Customer_Email,Customer_Phone,Customer_Job,Customer_Address,Membership_ID,Customer_Note,Customer_StartDate,Customer_EndDate) Values(@Name, @Age, @Sex, @Email, @Phone, @Job, @Address, @MemberId, @Note, @StartDate, @EndDate)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            return command.ExecuteNonQuery();
        }

        public int InsertCustomerImage(string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, DateTime startDate, DateTime endDate,string image)
        {
            const String sqlCommand = "Insert into Customer (Customer_Name,Customer_Age,Customer_Sex,Customer_Email,Customer_Phone,Customer_Job,Customer_Address,Membership_ID,Customer_Note,Customer_StartDate,Customer_EndDate,Customer_Image) Values(@Name, @Age, @Sex, @Email, @Phone, @Job, @Address, @MemberId, @Note, @StartDate, @EndDate,@Image)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            return command.ExecuteNonQuery();
        }

        public int UpdateCustomerNoImage(int id,string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, DateTime startDate, DateTime endDate)
        {
            const String sqlCommand = "Update Customer set Customer_Name = @Name,Customer_Age = @Age,Customer_Sex = @Sex, Customer_Email = @Email,Customer_Phone = @Phone,Customer_Job = @Job,Customer_Address = @Address,Membership_ID = @MemberId,Customer_Note = @Note, Customer_StartDate = @StartDate, Customer_EndDate = @EndDate Where Customer_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            return command.ExecuteNonQuery();
        }
        public int UpdateCustomerImage(int id, string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, DateTime startDate, DateTime endDate,string image)
        {
            const String sqlCommand = "Update Customer set Customer_Name = @Name,Customer_Age = @Age,Customer_Sex = @Sex, Customer_Email = @Email,Customer_Phone = @Phone,Customer_Job = @Job,Customer_Address = @Address,Membership_ID = @MemberId,Customer_Note = @Note, Customer_StartDate = @StartDate, Customer_EndDate = @EndDate,Customer_Image = @Image Where Customer_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            return command.ExecuteNonQuery();
        }

        public int UpdateCustomerExpire(int id,int memberId, DateTime startDate, DateTime endDate)
        {
            const String sqlCommand = "Update Customer set Membership_ID = @MemberId, Customer_StartDate = @StartDate, Customer_EndDate = @EndDate Where Customer_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            return command.ExecuteNonQuery();
        }

        public int UpdateCustomerNoImageNoDate(int id, string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note)
        {
            const String sqlCommand = "Update Customer set Customer_Name = @Name,Customer_Age = @Age,Customer_Sex = @Sex, Customer_Email = @Email,Customer_Phone = @Phone,Customer_Job = @Job,Customer_Address = @Address,Membership_ID = @MemberId,Customer_Note = @Note Where Customer_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@Note", note);
            return command.ExecuteNonQuery();
        }
        public int UpdateCustomerImageNoDate(int id, string name, DateTime age, string sex, string email, string phone, string job, string address, int memberId, string note, string image)
        {
            const String sqlCommand = "Update Customer set Customer_Name = @Name,Customer_Age = @Age,Customer_Sex = @Sex, Customer_Email = @Email,Customer_Phone = @Phone,Customer_Job = @Job,Customer_Address = @Address,Membership_ID = @MemberId,Customer_Note = @Note,Customer_Image = @Image Where Customer_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Job", job);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            return command.ExecuteNonQuery();
        }

        public DataTable ExpireMember(DateTime endDate)
        {
            const String sqlCommand = "Select * from Customer where Customer_EndDate <= '@EndDate'";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@EndDate", endDate);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
