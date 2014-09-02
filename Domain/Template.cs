using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Template Data Structure.
    /// </summary>
    [Serializable]
    public class Template : TopObject
    {
        /// <summary>
        /// 模板的业务状态1 审核通过 0 创建
        /// </summary>
        [XmlElement("biz_status")]
        public long BizStatus { get; set; }

        /// <summary>
        /// 创建者id
        /// </summary>
        [XmlElement("creater")]
        public long Creater { get; set; }

        /// <summary>
        /// 模板的描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 模板的表达式
        /// </summary>
        [XmlElement("expression")]
        public string Expression { get; set; }

        /// <summary>
        /// 模板的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 模板最近一次修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 模板的Id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 模板的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
