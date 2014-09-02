using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlipayEbppBillPayurlGetResponse.
    /// </summary>
    public class AlipayEbppBillPayurlGetResponse : TopResponse
    {
        /// <summary>
        /// 付款页面地址
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }
    }
}
