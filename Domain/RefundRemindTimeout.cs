using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundRemindTimeout Data Structure.
    /// </summary>
    [Serializable]
    public class RefundRemindTimeout : TopObject
    {
        /// <summary>
        /// 是否存在超时。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("exist_timeout")]
        public bool ExistTimeout { get; set; }

        /// <summary>
        /// 提醒的类型（退款详情中提示信息的类型）
        /// </summary>
        [XmlElement("remind_type")]
        public long RemindType { get; set; }

        /// <summary>
        /// 超时时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("timeout")]
        public string Timeout { get; set; }
    }
}
