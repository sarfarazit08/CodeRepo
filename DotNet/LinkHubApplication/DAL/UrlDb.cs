using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


using BOL;


namespace DAL
{
    public class UrlDb
    {
        private LinkHubDbEntities db;
        public UrlDb()
        {
            db = new LinkHubDbEntities();
        }

        public IEnumerable<tbl_Url> GetAll()
        {
            return db.tbl_Url.ToList();
        }

        public tbl_Url GetById(int Id)
        {
            return db.tbl_Url.Find(Id);
        }

        public void Insert(tbl_Url url)
        {
            db.tbl_Url.Add(url);
            Save();
        }

        public void Delete(int Id)
        {
            tbl_Url url = db.tbl_Url.Find(Id);
            db.tbl_Url.Remove(url);
            Save();
        }

        public void Update(tbl_Url url)
        {
            db.Entry(url).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
