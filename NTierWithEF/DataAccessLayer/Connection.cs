using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace DataAccessLayer
{
    public class Connection
    {
        private static NorthwindEntities _db = null;
        public static NorthwindEntities MyDB()
        {
            if (_db == null)
                _db = new NorthwindEntities();
            return _db;
        }
    }
}
