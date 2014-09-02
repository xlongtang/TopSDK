using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using Top.Api.Util;

namespace Top.Api.Stream.Connect
{
    public class HttpClient
    {
        private ITopLogger log = new DefaultTopLogger();
        private IDictionary<string, string> parameters;
        private Configuration conf;

        public HttpClient(Configuration conf, IDictionary<string, string> parameters)
        {
            if (conf == null || parameters == null)
            {
                throw new Exception("conf and params is must not null");
            }
            this.conf = conf;
            this.parameters = parameters;
            System.Net.ServicePointManager.DefaultConnectionLimit = 128;
        }

        public HttpResponse Post()
        {

            int retriedCount;
            int retry = conf.GetHttpConnectRetryCount() + 1;
            HttpResponse resp = null;
            for (retriedCount = 1; retriedCount <= retry; retriedCount++)
            {
                try
                {
                    HttpWebRequest con = null;
                    System.IO.Stream outStream = null;
                    try
                    {
                        con = GetConnection(conf.GetConnectUrl(), conf.GetHttpConnectionTimeout(), conf.GetHttpReadTimeout());
                        con.KeepAlive = true;

                        SetHeaders(con, conf.GetRequestHeader());
                        con.Method = "POST";
                        con.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

                        string postParam = WebUtils.BuildQuery(parameters);
                        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(postParam);

                        outStream = con.GetRequestStream();
                        outStream.Write(bytes, 0, bytes.Length);
                        outStream.Close();

                        HttpWebResponse response = (HttpWebResponse)con.GetResponse();
                        HttpStatusCode responseCode = response.StatusCode;

                        if (HttpStatusCode.OK == responseCode)
                        {
                            log.Info("connect successful");

                            StringBuilder respHeader = new StringBuilder();
                            WebHeaderCollection responseHeaders = con.Headers;

                            foreach (string key in responseHeaders.AllKeys)
                            {
                                string[] values = responseHeaders.GetValues(key);

                                foreach (string value in values)
                                {
                                    if (key != null)
                                    {
                                        respHeader.Append(key).Append("=").Append(value);
                                    }
                                    else
                                    {
                                        respHeader.Append(value);
                                    }
                                    respHeader.Append(";");
                                }

                                log.Info("Response: " + respHeader.ToString());
                            }
                            resp = new HttpResponse(con);
                            return resp;
                        }
                        else if (HttpStatusCode.BadRequest == responseCode)
                        {   //参数校验出错
                            log.Info("Request param is invalid,errmsg is:" + con.Headers.Get(StreamConstants.ERR_MSG_HEADER));
                            throw new TopCometSysErrorException("Server response err msg:" + con.Headers.Get(StreamConstants.ERR_MSG_HEADER));
                        }
                        else if (HttpStatusCode.Forbidden == responseCode)
                        {//服务端在发布，需要休眠一段时间

                            log.Info("Server is deploying,sleep " + retriedCount * conf.GetHttpConnectRetryInterval() + " seconds");
                            if (retriedCount == conf.GetHttpConnectRetryCount())
                            {
                                log.Info("May be server occure some error,please contact top tech support");
                                throw new TopCometSysErrorException("May be server occure some error,please contact top tech support");
                            }
                            try
                            {
                                Thread.Sleep(retriedCount * conf.GetHttpConnectRetryInterval() * 1000);
                            }
                            catch (Exception e)
                            {
                                //ignore;
                            }
                            continue;
                        }
                    }
                    catch (Exception e)
                    {
                        log.Error(e.Message);                       
                    }
                    finally
                    {
                        try
                        {
                            if (outStream != null)
                            {
                                outStream.Close();
                            }
                        }
                        catch (Exception ignore)
                        {
                        }
                    }
                }
                catch (Exception ioe)
                {
                    // connection timeout or read timeout
                    if (retriedCount == conf.GetHttpConnectRetryCount())
                    {
                        throw new TopCometSysErrorException(ioe.Message);
                    }
                }
                try
                {
                    log.Info("Sleeping " + conf.GetHttpConnectRetryInterval() + " seconds until the next retry.");
                    Thread.Sleep(retriedCount * conf.GetHttpConnectRetryInterval() * 1000);
                }
                catch (Exception ignore)
                {
                    //nothing to do
                }
            }
            return resp;
        }

        private HttpWebRequest GetConnection(string url, int connTimeout, int readTimeout)
        {
            HttpWebRequest con = (HttpWebRequest)WebRequest.Create(url);
            if (connTimeout > 0)
            {
                con.Timeout = connTimeout * 1000;
            }

            if (readTimeout > 0)
            {
                con.ReadWriteTimeout = readTimeout * 1000;
            }

            con.AllowAutoRedirect = false;
            con.ServicePoint.Expect100Continue = false;

            return con;
        }

        /**
         * sets HTTP headers
         *
         * @param connection HttpURLConnection
         * @param reqHeader 
         */
        private void SetHeaders(HttpWebRequest connection, IDictionary<string, string> reqHeader)
        {
            if (reqHeader != null && reqHeader.Count > 0)
            {
                foreach (KeyValuePair<string, string> pair in reqHeader)
                {
                    connection.Headers.Add(pair.Key, pair.Value);
                }
            }
        }
    }

}
