using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbTmsOrder Data Structure.
    /// </summary>
    [Serializable]
    public class WlbTmsOrder : TopObject
    {
        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 物流订单编号
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 物流订单的所有者ID,货主
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
