using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AndroidCodes
{
    public class WebHelper
    {
        public static string HttpPost(string url, string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(str);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Flush();
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
            string retrunString = streamReader.ReadToEnd();
            streamReader.Close();
            responseStream.Close();
            return retrunString;
        }

        public static string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
            string retrunString = streamReader.ReadToEnd();
            streamReader.Close();
            responseStream.Close();
            return retrunString;
        }
    }
}
