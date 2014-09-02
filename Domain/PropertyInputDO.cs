using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PropertyInputDO Data Structure.
    /// </summary>
    [Serializable]
    public class PropertyInputDO : TopObject
    {
        /// <summary>
        /// property_id对应的属性是否可输入
        /// </summary>
        [XmlElement("is_allow_input")]
        public bool IsAllowInput { get; set; }

        /// <summary>
        /// 如果property_id对应的属性是子属性，is_root_allow_input标识该子属性的顶级父属性是否可输入。否则is_root_allow_input和is_allow_input  值是一样的。目前只有品牌会出现父属性不可输入，子属性可输入的情况
        /// </summary>
        [XmlElement("is_root_allow_input")]
        public bool IsRootAllowInput { get; set; }

        /// <summary>
        /// property_id对应的属性是不是子属性
        /// </summary>
        [XmlElement("is_sub_property")]
        public bool IsSubProperty { get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [XmlElement("property_id")]
        public long PropertyId { get; set; }
    }
}
