using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebClient
{
    public partial class HelloWorldForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HelloServiceReference.HelloServiceClient client = new HelloServiceReference.HelloServiceClient("BasicHttpBinding_IHelloService");
             lblResult.Text = client.HelloMessage(txtBoxName.Text);
        }
    }
}