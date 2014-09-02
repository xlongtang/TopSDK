using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// HanoiLabelGroup Data Structure.
    /// </summary>
    [Serializable]
    public class HanoiLabelGroup : TopObject
    {
        /// <summary>
        /// 分组的业务状态
        /// </summary>
        [XmlElement("biz_status")]
        public long BizStatus { get; set; }

        /// <summary>
        /// 分组的编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 分组的描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 分组创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 分组最后一次修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 标签组的Id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 分组的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签组的开放策略（true开放）
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 应用场景
        /// </summary>
        [XmlElement("scene")]
        public long Scene { get; set; }

        /// <summary>
        /// 分组的类型，分组类标签的关系，0互斥、1共存
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
