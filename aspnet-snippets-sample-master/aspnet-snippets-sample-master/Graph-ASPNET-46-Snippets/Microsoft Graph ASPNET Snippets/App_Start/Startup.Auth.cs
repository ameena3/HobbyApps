﻿/* 
*  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. 
*  See LICENSE in the source repository root for complete license information. 
*/

using System;
using System.Web;
using Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System.Configuration;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft_Graph_ASPNET_Snippets.TokenStorage;
using System.IdentityModel.Tokens;
using System.IdentityModel.Claims;
using Microsoft.Identity.Client;
using Microsoft_Graph_ASPNET_Snippets.Utils;

namespace Microsoft_Graph_ASPNET_Snippets
{
    public partial class Startup
    {

        // The appId is used by the application to uniquely identify itself to Azure AD.
        // The appSecret is the application's password.
        // The aadInstance is the instance of Azure, for example public Azure or Azure China.
        // The redirectUri is where users are redirected after sign in and consent.
        private static string appId = ConfigurationManager.AppSettings["ida:AppId"];
        private static string appSecret = ConfigurationManager.AppSettings["ida:AppSecret"];
        private static string aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
        private static string redirectUri = ConfigurationManager.AppSettings["ida:RedirectUri"];
        private static string nonAdminScopes = ConfigurationManager.AppSettings["ida:NonAdminScopes"];
        private static string adminScopes = ConfigurationManager.AppSettings["ida:AdminScopes"];
        private static string scopes = "openid email profile offline_access " + nonAdminScopes;
        private string graphScopes = adminScopes;

        public void ConfigureAuth(IAppBuilder app)
        {
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions());

            app.UseOpenIdConnectAuthentication(
                new OpenIdConnectAuthenticationOptions
                {

            // The `Authority` represents the Microsoft v2.0 authentication and authorization service.
            // The `Scope` describes the permissions that your app will need. See https://azure.microsoft.com/documentation/articles/active-directory-v2-scopes/                    
            ClientId = appId,
                    Authority = "https://login.microsoftonline.com/common/v2.0",
                    PostLogoutRedirectUri = redirectUri,
                    RedirectUri = redirectUri,
                    Scope = "openid email profile offline_access " + graphScopes,
                    TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                // In a real application you would use IssuerValidator for additional checks, 
                // like making sure the user's organization has signed up for your app.
                //     IssuerValidator = (issuer, token, tvp) =>
                //     {
                //         if (MyCustomTenantValidation(issuer)) 
                //             return issuer;
                //         else
                //             throw new SecurityTokenInvalidIssuerException("Invalid issuer");
                //     },
            },
                    Notifications = new OpenIdConnectAuthenticationNotifications
                    {
                        AuthorizationCodeReceived = async (context) =>
                        {
                            var code = context.Code;
                            string signedInUserID = context.AuthenticationTicket.Identity.FindFirst(ClaimTypes.NameIdentifier).Value;
                            ConfidentialClientApplication cca = new ConfidentialClientApplication(
                                appId,
                                redirectUri,
                                new ClientCredential(appSecret),
                                new SessionTokenCache(signedInUserID, context.OwinContext.Environment["System.Web.HttpContextBase"] as HttpContextBase));
                            string[] scopes = graphScopes.Split(new char[] { ' ' });

                            AuthenticationResult result = await cca.AcquireTokenByAuthorizationCodeAsync(scopes, code);
                        },
                        AuthenticationFailed = (context) =>
                        {
                            context.HandleResponse();
                            context.Response.Redirect("/Error?message=" + context.Exception.Message);
                            return Task.FromResult(0);
                        }
                    }
                });
        }
    }
}
