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
        /// 区域编码
        /// </summary>
        [XmlElement("division_id")]
        public long DivisionId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 物流公司代号
        /// </summary>
        [XmlElement("partner_code")]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 物流公司编码ID
        /// </summary>
        [XmlElement("partner_id")]
        public long PartnerId { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 服务是否可达，    0 - 不可达    1 - 可达    2 - 不确定    3 - 未配置
        /// </summary>
        [XmlElement("reachable")]
        public long Reachable { get; set; }

        /// <summary>
        /// 服务对应的数字编码，如揽派范围对应88
        /// </summary>
        [XmlElement("service_type")]
        public long ServiceType { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
