using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CaipiaoSignstatusCheckResponse.
    /// </summary>
    public class CaipiaoSignstatusCheckResponse : TopResponse
    {
        /// <summary>
        /// 是否签署了支付宝代扣协议
        /// </summary>
        [XmlElement("sign")]
        public bool Sign { get; set; }

        /// <summary>
        /// 签署支付宝代扣协议的Url
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
