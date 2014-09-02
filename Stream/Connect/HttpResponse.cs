using System.IO;
using System.Net;
using System.Text;

namespace Top.Api.Stream.Connect
{
    public class HttpResponse
    {
        private HttpWebRequest con;
        private System.IO.Stream stream = null;
        private StreamReader reader = null;
        private HttpWebResponse rsp = null;

        public HttpResponse(HttpWebRequest con)
        {
            this.con = con;
            this.rsp = (HttpWebResponse)con.GetResponse();
            this.stream = rsp.GetResponseStream();
            this.reader = new StreamReader(stream, Encoding.UTF8);
        }

        public string GetResponseHeader(string name)
        {
            return con.Headers.Get(name);
        }

        public string GetMsg()
        {
            return reader.ReadLine();
        }

        public void Close()
        {
            // 释放资源
            if (this.reader != null) reader.Close();
            if (this.stream != null) stream.Close();
            if (this.rsp != null) rsp.Close();
        }
    }
}
