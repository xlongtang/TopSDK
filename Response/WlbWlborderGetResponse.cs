using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWlborderGetResponse.
    /// </summary>
    public class WlbWlborderGetResponse : TopResponse
    {
        /// <summary>
        /// 物流宝订单详情
        /// </summary>
        [XmlElement("wlb_order")]
        public WlbOrder WlbOrder { get; set; }
    }
}
