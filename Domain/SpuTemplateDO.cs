using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SpuTemplateDO Data Structure.
    /// </summary>
    [Serializable]
    public class SpuTemplateDO : TopObject
    {
        /// <summary>
        /// 产品绑定属性，内容为属性ID(PID)的列表,绑定属性肯定在类目上有，对应属性的类目特征，子属性请根据PID到类目上去取
        /// </summary>
        [XmlArray("affect_properties")]
        [XmlArrayItem("number")]
        public List<long> AffectProperties { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 品类ID，和类目ID类似
        /// </summary>
        [XmlElement("commodity_id")]
        public long CommodityId { get; set; }

        /// <summary>
        /// 过滤属性，内容有属性ID(PID)列表，很重要的属性，filter_properties包含的属性，必须填写
        /// </summary>
        [XmlArray("filter_properties")]
        [XmlArrayItem("number")]
        public List<long> FilterProperties { get; set; }

        /// <summary>
        /// 产品关键属性，内容为属性ID(PID)的列表，注意关键属性可以在类目上不存在。不存在的PID，默认为输入，没有子属性。属性名称在prop_name_str中取
        /// </summary>
        [XmlArray("key_properties")]
        [XmlArrayItem("number")]
        public List<long> KeyProperties { get; set; }

        /// <summary>
        /// 预留
        /// </summary>
        [XmlElement("prop_features")]
        public string PropFeatures { get; set; }

        /// <summary>
        /// 属性名称扁平化结构，只保证不在类目上的CP有值
        /// </summary>
        [XmlElement("prop_name_str")]
        public string PropNameStr { get; set; }

        /// <summary>
        /// 模板ID，发布产品，必须放到Product中
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
