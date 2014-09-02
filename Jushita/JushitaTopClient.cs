using System.Collections.Generic;
using Top.Api.Request;

namespace Top.Api.Jushita
{
    /// <summary>
    /// 聚石塔专用TOP客户端。
    /// </summary>
    public class JushitaTopClient
    {
        private const string SYNC_CENTER_URL = "http://eai.taobao.com/api";

        private DefaultTopClient topClient;

        public JushitaTopClient(string serverUrl, string appKey, string appSecret)
        {
            this.topClient = new DefaultTopClient(serverUrl, appKey, appSecret);
            this.topClient.SetDisableParser(true);
        }

        public JushitaTopClient(string appKey, string appSecret)
            : this(SYNC_CENTER_URL, appKey, appSecret)
        {
        }

        public JushitaTopClient(string serverUrl, string appKey, string appSecret, int timeout)
            : this(serverUrl, appKey, appSecret)
        {
            this.topClient.SetTimeout(timeout);
        }

        public string execute(string apiName, IDictionary<string, string> parameters, string session)
        {
            JushitaRequest request = new JushitaRequest();
            request.ApiName = apiName;
            request.Parameters = parameters;
            JushitaResponse response = topClient.Execute(request, session);
            return response.Body;
        }
    }

    public class JushitaRequest : ITopRequest<JushitaResponse>
    {
        public string ApiName { get; set; }
        public IDictionary<string, string> Parameters { get; set; }

        public string GetApiName()
        {
            return this.ApiName;
        }

        public IDictionary<string, string> GetParameters()
        {
            return this.Parameters;
        }

        public void Validate()
        {
        }
    }

    public class JushitaResponse : TopResponse
    {
    }
}
