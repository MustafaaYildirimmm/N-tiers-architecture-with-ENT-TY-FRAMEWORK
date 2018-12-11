using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class CategoryRepository
    {
        public static NorthwindEntities con = Connection.MyDB();
        public static List<Category> GetAllCategory()
        {
            return con.Categories.ToList();
        }
    }
}
