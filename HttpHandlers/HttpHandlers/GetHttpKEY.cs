using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandlers
{
    public class GetHttpKEY: IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            string a = request.QueryString["TextBox1"];
            string b = request.QueryString["TextBox2"];
            response.Write("GET-Http-KEY:ParmA = " + a + ", ParmB = " + b );
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}