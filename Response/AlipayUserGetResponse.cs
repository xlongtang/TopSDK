using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AlipayUserGetResponse.
    /// </summary>
    public class AlipayUserGetResponse : TopResponse
    {
        /// <summary>
        /// 支付宝用户信息
        /// </summary>
        [XmlElement("alipay_user_detail")]
        public AlipayUserDetail AlipayUserDetail { get; set; }
    }
}
