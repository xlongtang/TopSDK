using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ShipFresh Data Structure.
    /// </summary>
    [Serializable]
    public class ShipFresh : TopObject
    {
        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 返回的地址信息
        /// </summary>
        [XmlElement("send_addr")]
        public string SendAddr { get; set; }

        /// <summary>
        /// 物流公司服务电话
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 旺旺ID
        /// </summary>
        [XmlElement("wangwang_id")]
        public string WangwangId { get; set; }
    }
}
