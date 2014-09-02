using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ParamKeyVO Data Structure.
    /// </summary>
    [Serializable]
    public class ParamKeyVO : TopObject
    {
        /// <summary>
        /// 同AttributeVO的clazzType:     1 : java.lang.Integer    2 : java.lang.Short    3 : java.lang.Long    4 : java.lang.Double    5 : java.lang.Float   6 : java.lang.String   7 : java.util.Date
        /// </summary>
        [XmlElement("clazz_type")]
        public long ClazzType { get; set; }

        /// <summary>
        /// 必填参数的CODE
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 必填参数可能有取值范围，如果此字段不为null则表示有取值范围
        /// </summary>
        [XmlElement("document_id")]
        public long DocumentId { get; set; }

        /// <summary>
        /// 必填参数唯一标识
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 必填参数的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 多个必填参数时_区分顺序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 必填参数的 类型：  0：创建模板时需要传入  1：创建模板时不需要传入，但是在进行实时匹配时需要传入
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 必填参数的值（模板创建、或者 实时匹配）
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
