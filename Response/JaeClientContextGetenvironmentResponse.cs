using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JaeClientContextGetenvironmentResponse.
    /// </summary>
    public class JaeClientContextGetenvironmentResponse : TopResponse
    {
        /// <summary>
        /// 返回当前webview的类型，tbwebview=1，jaewebview=2，三方webview=3.
        /// </summary>
        [XmlElement("env")]
        public long Env { get; set; }
    }
}
