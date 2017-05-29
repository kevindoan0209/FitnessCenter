using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL_Items:DbConection
    {
        public int InsertItems(string name, string image, string details,int price,string company, string status,string note,int typeId)
        {
            const String sqlCommand = "Insert into Items(Items_Name,Items_Images,Items_Details,Items_Price,Items_Company,Items_Status,Items_Note,Items_Type_ID) Values(@Name, @Image, @Details, @Price, @Company, @Status, @Note, @TypeId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            command.Parameters.AddWithValue("@Details", details);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Company", company);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@TypeId", typeId);
            return command.ExecuteNonQuery();
        }

        public int InsertItemsNoImage(string name, string details, int price, string company, string status, string note, int typeId)
        {
            const String sqlCommand = "Insert into Items(Items_Name,Items_Details,Items_Price,Items_Company,Items_Status,Items_Note,Items_Type_ID) Values(@Name, @Details, @Price, @Company, @Status, @Note, @TypeId)";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Details", details);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Company", company);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@TypeId", typeId);
            return command.ExecuteNonQuery();
        }

        public int UpdateItems(int id,string name, string image, string details, int price, string company, string status, string note, int typeId)
        {
            const String sqlCommand = "Update Items set Items_Name = @Name, Items_Images = @Image, Items_Details = @Details,Items_Price = @Price,Items_Company = @Company, Items_Status = @Status, Items_Note = @Note, Items_Type_ID = @TypeId Where Items_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Image", convertImagetoByte(image));
            command.Parameters.AddWithValue("@Details", details);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Company", company);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@TypeId", typeId);
            return command.ExecuteNonQuery();
        }

        public int UpdateItemsNoImage(int id, string name, string details, int price, string company, string status, string note, int typeId)
        {
            const String sqlCommand = "Update Items set Items_Name = @Name, Items_Details = @Details,Items_Price = @Price,Items_Company = @Company, Items_Status = @Status, Items_Note = @Note, Items_Type_ID = @TypeId Where Items_ID = @Id";
            SqlCommand command = new SqlCommand(sqlCommand, connect());
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Details", details);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Company", company);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@Note", note);
            command.Parameters.AddWithValue("@TypeId", typeId);
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
    }
}
