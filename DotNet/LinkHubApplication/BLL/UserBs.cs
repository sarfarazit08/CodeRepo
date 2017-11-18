using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBs
    {
        private UserDb objDb;

        public UserBs()
        {
            objDb = new UserDb();
        }

        public IEnumerable<tbl_User> GetAll()
        {
            return objDb.GetAll();
        }

        public tbl_User GetById(int Id)
        {
            return objDb.GetById(Id);
        }

        public void Insert(tbl_User user)
        {
            objDb.Insert(user);
        }

        public void Delete(int Id)
        {
            objDb.Delete(Id);
        }

        public void Update(tbl_User user)
        {
            objDb.Update(user);
        }
    }
}
