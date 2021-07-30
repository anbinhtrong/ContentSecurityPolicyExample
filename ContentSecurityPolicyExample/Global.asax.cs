using NWebsec.Csp;
using NWebsec.Mvc.HttpHeaders;
using NWebsec.Mvc.HttpHeaders.Csp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ContentSecurityPolicyExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        //{
        //    filters.Add(new SetNoCacheHttpHeadersAttribute());
        //    filters.Add(new XRobotsTagAttribute() { NoIndex = true, NoFollow = true });
        //    filters.Add(new XContentTypeOptionsAttribute());
        //    filters.Add(new XDownloadOptionsAttribute());
        //    filters.Add(new XFrameOptionsAttribute());
        //    filters.Add(new XXssProtectionAttribute());
        //    //CSP
        //    filters.Add(new CspAttribute());
        //    filters.Add(new CspDefaultSrcAttribute { Self = true });
        //    filters.Add(new CspScriptSrcAttribute { Self = true });
        //    //CSPReportOnly
        //    filters.Add(new CspReportOnlyAttribute());
        //    filters.Add(new CspScriptSrcReportOnlyAttribute { None = true});
        //}
    }
}
