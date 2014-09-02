using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AttributeVO Data Structure.
    /// </summary>
    [Serializable]
    public class AttributeVO : TopObject
    {
        /// <summary>
        /// 1 : java.lang.Integer    2 : java.lang.Short    3 : java.lang.Long    4 : java.lang.Double    5 : java.lang.Float   6 : java.lang.String   7 : java.util.Date
        /// </summary>
        [XmlElement("clazz_type")]
        public long ClazzType { get; set; }

        /// <summary>
        /// 属性编码CODE
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 属性描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 档案ID.档案定义了属性的取值范围。  可以通过document.get接口得到档案信息。  在根据ranges.get接口得到属性的取值范围。
        /// </summary>
        [XmlElement("document_id")]
        public long DocumentId { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 属性必填字段：当创建模板或者实施匹配时可能会用到必填参数。如果某个属性有必填参数，则在进行创建模板或者实时匹配时需要对这个对象的Value字段赋值。
        /// </summary>
        [XmlArray("param_keys")]
        [XmlArrayItem("param_key_v_o")]
        public List<ParamKeyVO> ParamKeys { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// Top 的访问权限。按位与。1：可读，2：可写，4：可规则计算
        /// </summary>
        [XmlElement("top_access")]
        public long TopAccess { get; set; }

        /// <summary>
        /// 属性所在的类型的唯一标识。  可以通过queryType接口查询到类型名称
        /// </summary>
        [XmlElement("type_id")]
        public long TypeId { get; set; }

        /// <summary>
        /// 指标单位。保留字段
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
