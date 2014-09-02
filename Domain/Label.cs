using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Label Data Structure.
    /// </summary>
    [Serializable]
    public class Label : TopObject
    {
        /// <summary>
        /// 标签的业务状态
        /// </summary>
        [XmlElement("biz_status")]
        public long BizStatus { get; set; }

        /// <summary>
        /// 标签的编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 标签的描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 标签的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 标签最后一次修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 标签的id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 标签的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否开放（true开放）
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 使用场景
        /// </summary>
        [XmlElement("scene")]
        public long Scene { get; set; }

        /// <summary>
        /// 标签的模板id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
