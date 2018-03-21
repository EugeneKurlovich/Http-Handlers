using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HttpHandlers
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50228/get?TextBox1=" + TextBox1.Text + "&TextBox2=" + TextBox2.Text );
            rq.Method = "GET";
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
            rdr.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50228/post");
            string data = String.Format("TextBox1={0}&TextBox2={1}", TextBox1.Text,TextBox2.Text);
            byte[] databyte = Encoding.UTF8.GetBytes(data);           
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = databyte.Length;
            rq.MaximumResponseHeadersLength = 100;
            rq.Method = "POST";
            rq.GetRequestStream().Write(databyte, 0, databyte.Length);
            rq.GetRequestStream().Close();
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
            rdr.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50228/put");
            string data = String.Format("TextBox1={0}&TextBox2={1}", TextBox1.Text, TextBox2.Text);
            byte[] databyte = Encoding.UTF8.GetBytes(data);
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = databyte.Length;
            rq.MaximumResponseHeadersLength = 100;
            rq.Method = "PUT";
            rq.GetRequestStream().Write(databyte, 0, databyte.Length);
            rq.GetRequestStream().Close();
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
            rdr.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50228/getStandartHandler");
                rq.Method = "GET";
                HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
                StreamReader rdr = new StreamReader(rs.GetResponseStream());
                Response.Write(rdr.ReadToEnd());
            }
            catch(WebException we)
            {
                Response.Write(we.Status);
                Response.Write("<br />" + we.Message);
                Response.Write("<br />" + we.TargetSite);
                Response.Write("<br />" + we.Source);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50228/sum");
            string data = String.Format("TextBox1={0}&TextBox2={1}", TextBox1.Text, TextBox2.Text);
            byte[] databyte = Encoding.UTF8.GetBytes(data);
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = databyte.Length;
            rq.MaximumResponseHeadersLength = 100;
            rq.Method = "POST";
            rq.GetRequestStream().Write(databyte, 0, databyte.Length);
            rq.GetRequestStream().Close();
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
            rdr.Close();
        }
    }
}