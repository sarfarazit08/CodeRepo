using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Cryptography
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string plain_text = "This is simple plane text to be hashed";

            SHA512Managed hashSvc = new SHA512Managed();

            // SHA512 returns 512 bits (8 bits/byte, 64 bytes) for the hash
            byte[] hash = hashSvc.ComputeHash(Encoding.UTF8.GetBytes(plain_text));

            // This converts the 64 byte hash into the string hex representation of byte values
            // (shown by default as hex charachter per byte) that looks like "AM-3F-C5-8V-F3...",
            // each pair represents the byte value of 0-255. Removing the "-" separator creates 
            // a 128 charachter string representation in hex.

            string hex = BitConverter.ToString(hash).Replace("-", "");

            Response.Write("Plain text : " + plain_text + "<br/> Hash value : " + hex);

        }
    }
}