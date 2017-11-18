using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQ
{
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinqDataContext dbContext = new LinqDataContext();
            
            //Linq query using lambda expression
           // gvProductData.DataSource = Student.GetAllStudents().Where( student => student.Gender == "Male");//from store in dbContext.Stores select store;

            //Linq query
            gvProductData.DataSource = from student in Student.GetAllStudents() 
                                       where student.Gender == "Female"
                                       select  student;
            gvProductData.DataBind();
        }

        

       
    }
}