﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;


namespace Communicator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCallPOSTwebService_Click(object sender, EventArgs e)
        {
            try
            {
                string WebServiceURL = tbWebServiceURL.Text;

                // Convert our JSON in into bytes using ascii encoding
                ASCIIEncoding encoding = new ASCIIEncoding();
                string inputJSON="{  'insertId':'"+TextBox1.Text+"' ,  'insertName':'"+TextBox2.Text+"'}";

                byte[] data = encoding.GetBytes(inputJSON);

                //  HttpWebRequest 
                HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(WebServiceURL);
                webrequest.Method = "POST";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                webrequest.ContentLength = data.Length;

                //  Get stream data out of webrequest object
                Stream newStream = webrequest.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();

                //  Declare & read the response from service
                HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();

                // Fetch the response from the POST web service
                Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader loResponseStream = new StreamReader(webresponse.GetResponseStream(), enc);
                string result = loResponseStream.ReadToEnd();
                loResponseStream.Close();

                webresponse.Close();

                txtResult.Text = result;
            }
            catch (Exception ex)
            {
                txtResult.Text = "An exception was thrown: " + ex.Message;
            }
        }
    }
}