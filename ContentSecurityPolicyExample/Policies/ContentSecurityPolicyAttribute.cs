using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ContentSecurityPolicyExample.Policies
{
    public sealed class ContentSecurityPolicyAttribute : FilterAttribute, IActionFilter
    {
        public string ScriptSource { get; set; }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var originalFilter = filterContext.HttpContext.Response.Filter;
            var policyBuilder = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(""))
            {
                policyBuilder.AppendFormat("script-src {0};", ScriptSource);
            }

            if (policyBuilder.Length > 0)
        {
                filterContext.HttpContext.Response.AppendHeader("Content-Security-Policy", policyBuilder.ToString());
            }
        }
    }
}