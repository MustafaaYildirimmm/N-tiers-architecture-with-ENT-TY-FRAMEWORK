using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    interface IRepository
    {
        List<Customer> GetAll();
        int SaveData(object nesne);
    }
}
