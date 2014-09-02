using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderCreateResponse.
    /// </summary>
    public class WlbOrderCreateResponse : TopResponse
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 物流宝订单创建成功后，返回物流宝的订单编号；如果订单创建失败，该字段为空。
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }
    }
}
