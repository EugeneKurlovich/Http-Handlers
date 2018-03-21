using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandlers 
{
    public class PostHttpKEY : IHttpHandler
    {
    public void ProcessRequest(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;
        string a = request.Form["TextBox1"].ToString();
        string b = request.Form["TextBox2"].ToString();
        response.Write("POST-Http-KEY:ParmA = " + a + ", ParmB = " + b);
    }

    public bool IsReusable
    {
        get { return false; }
    }
}
}