using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class OrderRepository
    {
        public static NorthwindEntities _db = Connection.MyDB();

        public static List<Order> GetOrderByCustomerId(string Id)
        {
            return _db.Orders.Where(t => t.CustomerID == Id).ToList();
        }
    }
}
