using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace Cryptography.Tamperproof
{
    public static class tamperProof
    {
        private const string qString = "val";
        private const string qString_with_separator = "&" + qString;

        private static string ComputeHash(string data)
        {

            // Add some "entropy" by also using the session id
            // HttpSessionState objSession = HttpContext.Current.Session;
            // data += objSession.SessionID;
            // objSession["A"] = 5; //set a variable else the session id will change.
               
            // Get bytes from plain text
            byte[] plain_text_bytes = Encoding.UTF8.GetBytes(data);

            // Read the key to use from web.config
            HMACSHA1 hashAlg = new HMACSHA1(conversions.HexToByteArray(WebConfigurationManager.AppSettings["Key64"]));

            // Don't just use hashing as hashing algo could be guessed and the corresponding hash 
            // could be generated for the modified data that will match
            // SHA1 hashAlg = new SHA1();

            byte[] hash = hashAlg.ComputeHash(plain_text_bytes);

            return conversions.ByteArrayToHex(hash);
        }

        public static string HashQueryString(string queryString)
        {

        }

        internal static void ValidateQueryString()
        {
            throw new NotImplementedException();
        }
    }
}