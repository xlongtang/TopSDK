using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItemsPropValue Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItemsPropValue : TopObject
    {
        /// <summary>
        /// 商品所属叶子类目ID，旅游度假8个叶子类目。
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 属性值名称。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性ID。
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }

        /// <summary>
        /// 属性名称。
        /// </summary>
        [XmlElement("prop_name")]
        public string PropName { get; set; }

        /// <summary>
        /// 排列序号，表示同级类目的展现次序，如数值相等则按名称次序排列。取值范围:大于零的整数。
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }

        /// <summary>
        /// 属性值ID。
        /// </summary>
        [XmlElement("vid")]
        public long Vid { get; set; }
    }
}
