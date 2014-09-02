using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItemsProp Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItemsProp : TopObject
    {
        /// <summary>
        /// 商品所属叶子类目ID，旅游度假8个叶子类目
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 是否可枚举。可选值:true(是),false(否)。
        /// </summary>
        [XmlElement("is_enums")]
        public bool IsEnums { get; set; }

        /// <summary>
        /// 是否可输入。可选值:true(是),false(否)。
        /// </summary>
        [XmlElement("is_input")]
        public bool IsInput { get; set; }

        /// <summary>
        /// 是否销售属性。可选值:true(是),false(否)。
        /// </summary>
        [XmlElement("is_sale_prop")]
        public bool IsSaleProp { get; set; }

        /// <summary>
        /// 发布商品时是否可以多选。可选值: true (是) , false(否)。
        /// </summary>
        [XmlElement("multi")]
        public bool Multi { get; set; }

        /// <summary>
        /// 发布商品时是否必选。可选值: true (是) , false(否)
        /// </summary>
        [XmlElement("must")]
        public bool Must { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 旅游商品类目属性ID
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }

        /// <summary>
        /// 排列序号，表示同级类目的展现次序，如数值相等则按名称次序排列。取值范围:大于零的整数
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }

        /// <summary>
        /// 商品类目属性值集合。
        /// </summary>
        [XmlArray("travel_items_prop_values")]
        [XmlArrayItem("travel_items_prop_value")]
        public List<TravelItemsPropValue> TravelItemsPropValues { get; set; }
    }
}
