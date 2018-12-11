using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class OrderDetailsRepository
    {
        public static NorthwindEntities _db = Connection.MyDB();
        public static List<Order_Detail> GetOrderDetailByCustomerId(string ID)
        {
            List<Order> OrderList = OrderRepository.GetOrderByCustomerId(ID);
            List<Order_Detail> OrdDetList = new List<Order_Detail>();
            foreach (Order ord in OrderList)
            {
                List<Order_Detail> list = _db.Order_Details.Where(t => t.OrderID == ord.OrderID).ToList();
                foreach (Order_Detail item in list)
                {
                    OrdDetList.Add(item);
                }
            }
            return OrdDetList;
        }
    }
}
