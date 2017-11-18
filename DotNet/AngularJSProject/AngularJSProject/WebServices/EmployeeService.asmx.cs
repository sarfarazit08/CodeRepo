using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace AngularJSProject.WebServices
{
    /// <summary>
    /// Summary description for EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {

        [WebMethod]
        public void getAllEmployee()
        {
            List<Employee> empList = new List<Employee>();

            Employee emp1 = new Employee() { EmpID = 633364, Name = "Sarfaraz", Age= 24, City = "Calcutta" };
            Employee emp2 = new Employee() { EmpID = 632364, Name = "Murari", Age = 24, City = "Pune" };
            Employee emp3 = new Employee() { EmpID = 632334, Name = "Abbas", Age = 24, City = "Gujrat" };
            Employee emp4 = new Employee() { EmpID = 632336, Name = "Suman", Age = 24, City = "Goa" };
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);

            JavaScriptSerializer js = new JavaScriptSerializer();

            Context.Response.Write(js.Serialize(empList));
        }
    }
}
