using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandlers
{
    public class SumHttpKEY : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            try
            {
                int a = Convert.ToInt32(request.Form["TextBox1"]);
                int b = Convert.ToInt32(request.Form["TextBox2"]);
                int c = a + b;
                response.Write("Sum-Http-KEY: Result = " + c);
            }
            catch { response.Write("Значения должны быть численными"); }
           
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}