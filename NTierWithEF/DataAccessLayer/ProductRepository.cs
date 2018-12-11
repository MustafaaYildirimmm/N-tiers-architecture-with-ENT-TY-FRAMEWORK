using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class ProductRepository : IRepository
    {
        public static NorthwindEntities con = Connection.MyDB();
        public List<Product> GetAll()
        {
            return con.Products.ToList();
                 
        }

        public int SaveData(object nesne)
        {
            Product p = (Product)nesne;
            con.Products.Add(p);
            return con.SaveChanges();
        }

        List<Customer> IRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
