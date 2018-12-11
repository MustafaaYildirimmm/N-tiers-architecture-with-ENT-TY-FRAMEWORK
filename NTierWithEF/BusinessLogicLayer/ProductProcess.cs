using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class ProductProcess
    {
        public static bool controlToSaveProduct(Product p)
        {
            ProductRepository pr = new ProductRepository();
            if (pr.SaveData(p) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
