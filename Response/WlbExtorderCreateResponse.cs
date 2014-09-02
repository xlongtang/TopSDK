using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbExtorderCreateResponse.
    /// </summary>
    public class WlbExtorderCreateResponse : TopResponse
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 物流宝外部订单创建成功后，返回物流宝的外部订单编号；如果订单创建失败，该字段为空。
        /// </summary>
        [XmlElement("ext_order_code")]
        public string ExtOrderCode { get; set; }
    }
}
