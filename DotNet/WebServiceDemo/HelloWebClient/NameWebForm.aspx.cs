﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HelloWebClient.HelloWorldWebServiceReference;


namespace HelloWebClient
{
    public partial class NameWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HelloWorldWebServiceSoapClient client = new HelloWorldWebServiceReference.HelloWorldWebServiceSoapClient();
            
            lblResult.Text = client.HelloWorld(txtBoxName.Text);
            
        }
    }
}