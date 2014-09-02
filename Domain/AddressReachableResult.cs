using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AddressReachableResult Data Structure.
    /// </summary>
    [Serializable]
    public class AddressReachableResult : TopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 物流公司编码ID
        /// </summary>
        [XmlElement("partner_id")]
        public long PartnerId { get; set; }

        /// <summary>
        /// 服务是否可达，      0 - 不可达      1 - 可达      2 - 不确定      3 - 未配置
        /// </summary>
        [XmlElement("reachable")]
        public long Reachable { get; set; }

        /// <summary>
        /// 服务对应的数字编码，如揽派范围对应88
        /// </summary>
        [XmlElement("service_type")]
        public long ServiceType { get; set; }
    }
}
