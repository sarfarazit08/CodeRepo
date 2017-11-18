using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using Mvc4App.Models;

namespace Mvc4App
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterMicrosoftClient(
                clientId: "abc",
                clientSecret: "abc");

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "YhnZrEq8XdH4DSoTsAHMeUFeb",
                consumerSecret: "PHBVXrvDTHASPpNW0Xl6fKs4CCwOzWu5rf4I9SlcazQKOJ46oL");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "301361393545364",
                appSecret: "297d87aced08f914ccc4306121c04bb5");

            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
