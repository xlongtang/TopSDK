using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// JzPartner Data Structure.
    /// </summary>
    [Serializable]
    public class JzPartner : TopObject
    {
        /// <summary>
        /// 为1表明为商家自由物流，为0表明系统物流商
        /// </summary>
        [XmlElement("is_virtual_tp")]
        public bool IsVirtualTp { get; set; }

        /// <summary>
        /// 目前该服务商对应的服务类型
        /// </summary>
        [XmlElement("service_type")]
        public long ServiceType { get; set; }

        /// <summary>
        /// 标示服务商在对应服务类型下标示编码
        /// </summary>
        [XmlElement("tp_code")]
        public string TpCode { get; set; }

        /// <summary>
        /// 标示服务商名称
        /// </summary>
        [XmlElement("tp_name")]
        public string TpName { get; set; }
    }
}
