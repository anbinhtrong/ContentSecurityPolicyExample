using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ContentSecurityPolicyExample
{
    public class CspFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //filterContext.HttpContext.Response.Filter = new SomeHTMLFilter(filterContext.HttpContext.Response.Filter);
            var header = filterContext.HttpContext.Response.Headers.Get("Content-Security-Policy");
            if(!header.Contains("script-src 'self' 'unsafe-inline'"))
            {
                header = header.Replace("script-src 'self'", "script-src 'self' 'unsafe-inline'");
                filterContext.HttpContext.Response.Headers.Remove("Content-Security-Policy");
                filterContext.HttpContext.Response.Headers.Add("Content-Security-Policy", header);
            }
            base.OnActionExecuting(filterContext);
        }
    }

    public class SomeHTMLFilter : MemoryStream
    {
        private readonly Stream _outputStream;
        public SomeHTMLFilter(Stream outputStream)
        {
            _outputStream = outputStream;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _outputStream.Write(buffer, 0, buffer.Length);
        }

        public override void Close()
        {
            var buffer = Encoding.UTF8.GetBytes("Hello World");
            _outputStream.Write(buffer, 0, buffer.Length);
            base.Close();
        }
    }
}