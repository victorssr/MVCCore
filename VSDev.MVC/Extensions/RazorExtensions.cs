using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;

namespace VSDev.MVC.Extensions
{
    public static class RazorExtensions
    {
        public static bool IfClaim(this RazorPage page, string claimType, string claimValue)
        {
            return CustomAuthorization.ValidarClaimsUsuario(page.Context, claimType, claimValue);
        }

        public static string IfClaimShow(this RazorPage page, string claimType, string claimValue)
        {
            return CustomAuthorization.ValidarClaimsUsuario(page.Context, claimType, claimValue) ? "" : "disabled";
        }

        public static IHtmlContent IfClaimShow(this IHtmlContent page, HttpContext context, string claimType, string claimValue)
        {
            return CustomAuthorization.ValidarClaimsUsuario(context, claimType, claimValue) ? page : null;
        }
    }
}