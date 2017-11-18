using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cryptography.Tamperproof
{
    public partial class useTamperproofQueryString : basePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("username = "+ Request.QueryString["username"]);
            Response.Write("passkey = "+ Request.QueryString["passkey"]);
        }
    }
}