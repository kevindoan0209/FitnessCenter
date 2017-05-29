using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BLL_Items
    {
        private static readonly DAL_Items _items = new DAL_Items();

        public static int InsertItems(string name, string image, string details, int price, string company, string status, string note, int typeId)
        {
            return _items.InsertItems(name, image, details, price, company, status, note, typeId);
        }

        public static int InsertItemsNoImage(string name, string details, int price, string company, string status, string note, int typeId)
        {
            return _items.InsertItemsNoImage(name, details, price, company, status, note, typeId);
        }

        public static int UpdateItems(int id,string name, string image, string details, int price, string company, string status, string note, int typeId)
        {
            return _items.UpdateItems(id,name, image, details, price, company, status, note, typeId);
        }

        public static int UpdateItemsNoImage(int id, string name, string details, int price, string company, string status, string note, int typeId)
        {
            return _items.UpdateItemsNoImage(id,name, details, price, company, status, note, typeId);
        }
    }
}
