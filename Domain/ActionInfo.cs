using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ActionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActionInfo : TopObject
    {
        /// <summary>
        /// 动作编码
        /// </summary>
        [XmlElement("action_code")]
        public string ActionCode { get; set; }

        /// <summary>
        /// 动作申请人
        /// </summary>
        [XmlElement("applier")]
        public string Applier { get; set; }

        /// <summary>
        /// 动作的id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 动作的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 动作状态 0：审核中 1：审核通过，正常
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 动作审核人
        /// </summary>
        [XmlElement("verifier")]
        public string Verifier { get; set; }
    }
}
