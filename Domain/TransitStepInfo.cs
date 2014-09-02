using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TransitStepInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransitStepInfo : TopObject
    {
        /// <summary>
        /// 节点说明 ，指明当前节点揽收、派送，签收。
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 地址地一
        /// </summary>
        [XmlElement("node_description")]
        public string NodeDescription { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 状态发生的时间
        /// </summary>
        [XmlElement("status_time")]
        public string StatusTime { get; set; }

        /// <summary>
        /// 时间。。
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
