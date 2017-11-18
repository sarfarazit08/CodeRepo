using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cryptography
{
    public partial class Performance : System.Web.UI.Page
    {
        // Test with different plain text sizes
        //private const string plain_text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string plain_text = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create table to make display of result easier

            DataTable results = new DataTable();

            results.BeginInit();
            results.Columns.Add("Algorithm", typeof(string));
            results.Columns.Add("Ticks", typeof(Int64));
            results.Columns.Add("Seconds", typeof(Int32));
            results.Columns.Add("Milliseconds", typeof(Int32));
            results.EndInit();

            // By default, keyed hash algorithms generate a random 64 byte key when create a new instance

            TestPerformance(plain_text, new MD5CryptoServiceProvider(), results);
            TestPerformance(plain_text, new SHA1Cng(), results);
            TestPerformance(plain_text, new SHA1Managed(), results);
            TestPerformance(plain_text, new SHA256Managed(), results);
            TestPerformance(plain_text, new SHA384Managed(), results);
            TestPerformance(plain_text, new SHA512Managed(), results);
            TestPerformance(plain_text, new MACTripleDES(), results);
            TestPerformance(plain_text, new HMACMD5(), results);
            TestPerformance(plain_text, new HMACSHA256(), results);
            TestPerformance(plain_text, new HMACSHA384(), results);
            TestPerformance(plain_text, new HMACSHA512(), results);
            TestPerformance(plain_text, new HMACRIPEMD160(), results);

            // Bind results to the grid view
            gvResults.DataSource = results;
            gvResults.DataBind();


        }

        private void TestPerformance(string plain_text, MD5CryptoServiceProvider mD5CryptoServiceProvider, DataTable results)
        {
            throw new NotImplementedException();
        }
    }
}