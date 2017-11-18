using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cryptography
{
    public partial class TamperProofQueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "/hash/useTamperproofQuerystring.aspx?" + tamperProof.HashQueryString("username=Sophia&passkey=sophie@123");
        }
    }
}