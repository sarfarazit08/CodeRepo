using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cryptography.Tamperproof
{
    public class basePage : System.Web.UI.Page
    {
        public basePage()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!Request.Url.AbsoluteUri.Contains("/login.aspx"))
            {
                tamperProof.ValidateQueryString();
            }
            
            base.OnLoad(e);
        }
    }
}