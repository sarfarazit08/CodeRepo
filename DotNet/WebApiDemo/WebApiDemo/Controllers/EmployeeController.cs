using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApiDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                return db.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                return db.Employees.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Post([FromBody] Employee employee)
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            } 
        }
    }
}
