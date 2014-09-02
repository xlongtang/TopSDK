using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemProp Data Structure.
    /// </summary>
    [Serializable]
    public class ItemProp : TopObject
    {
        /// <summary>
        /// 子属性的模板（卖家自行输入属性时需要用到）
        /// </summary>
        [XmlElement("child_template")]
        public string ChildTemplate { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 属性的feature列表
        /// </summary>
        [XmlArray("features")]
        [XmlArrayItem("feature")]
        public List<Feature> Features { get; set; }

        /// <summary>
        /// 是否允许别名。可选值：true（是），false（否）
        /// </summary>
        [XmlElement("is_allow_alias")]
        public bool IsAllowAlias { get; set; }

        /// <summary>
        /// 是否颜色属性。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("is_color_prop")]
        public bool IsColorProp { get; set; }

        /// <summary>
        /// 是否是可枚举属性。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("is_enum_prop")]
        public bool IsEnumProp { get; set; }

        /// <summary>
        /// 在is_enum_prop是true的前提下，是否是卖家可以自行输入的属性（注：如果is_enum_prop返回false，该参数统一返回false）。可选值:true(是),false(否)。<b>对于品牌和型号属性（包括子属性）：如果用户是C卖家，则可自定义属性；如果是B卖家，则不可自定义属性，而必须要授权的属性。</b>
        /// </summary>
        [XmlElement("is_input_prop")]
        public bool IsInputProp { get; set; }

        /// <summary>
        /// 是否商品属性。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("is_item_prop")]
        public bool IsItemProp { get; set; }

        /// <summary>
        /// 是否关键属性。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("is_key_prop")]
        public bool IsKeyProp { get; set; }

        /// <summary>
        /// 是否销售属性。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("is_sale_prop")]
        public bool IsSaleProp { get; set; }

        /// <summary>
        /// 属性修改时间（增量类目专用）
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 三种枚举类型：modify，add，delete（增量类目专用）
        /// </summary>
        [XmlElement("modified_type")]
        public string ModifiedType { get; set; }

        /// <summary>
        /// 发布产品或商品时是否可以多选。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("multi")]
        public bool Multi { get; set; }

        /// <summary>
        /// 发布产品或商品时是否为必选属性。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("must")]
        public bool Must { get; set; }

        /// <summary>
        /// 属性名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 上级属性ID
        /// </summary>
        [XmlElement("parent_pid")]
        public long ParentPid { get; set; }

        /// <summary>
        /// 上级属性值ID
        /// </summary>
        [XmlElement("parent_vid")]
        public long ParentVid { get; set; }

        /// <summary>
        /// 属性 ID 例：品牌的PID=20000
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("prop_values")]
        [XmlArrayItem("prop_value")]
        public List<PropValue> PropValues { get; set; }

        /// <summary>
        /// 发布产品或商品时是否为必选属性(与must相同)。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 排列序号。取值范围:大于零的整排列序号。取值范围:大于零的整数
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }

        /// <summary>
        /// 状态。可选值:normal(正常),deleted(删除)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 属性值类型。可选值：  multiCheck(枚举多选)  optional(枚举单选)  multiCheckText(枚举可输入多选)  optionalText(枚举可输入单选)  text(非枚举可输入)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
