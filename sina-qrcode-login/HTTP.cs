using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace sina_qrcode_login
{
    class HTTP
    {
        public static string Post(string url, string content)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";

            #region 添加Post 参数  
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        public static string Get(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        public static string GetMiddleString(string SumString, string LeftString, string RightString)
        {
            if (string.IsNullOrEmpty(SumString)) return "";
            if (string.IsNullOrEmpty(LeftString)) return "";
            if (string.IsNullOrEmpty(RightString)) return "";

            int LeftIndex = SumString.IndexOf(LeftString);
            if (LeftIndex == -1) return "";
            LeftIndex = LeftIndex + LeftString.Length;
            int RightIndex = SumString.IndexOf(RightString, LeftIndex);
            if (RightIndex == -1) return "";
            return SumString.Substring(LeftIndex, RightIndex - LeftIndex);
        }
    }
}
