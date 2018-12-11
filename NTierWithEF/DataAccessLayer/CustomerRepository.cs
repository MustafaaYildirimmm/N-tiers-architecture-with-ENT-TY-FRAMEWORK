using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class CustomerRepository : IRepository
    {
        public static NorthwindEntities Con = Connection.MyDB();
        public List<Customer> GetAll()
        {
            return Con.Customers.ToList();
        }

        public int SaveData(object nesne)
        {
            throw new NotImplementedException();
        }
    }
}
