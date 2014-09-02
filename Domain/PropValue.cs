using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// PropValue Data Structure.
    /// </summary>
    [Serializable]
    public class PropValue : TopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 属性值feature
        /// </summary>
        [XmlArray("features")]
        [XmlArrayItem("feature")]
        public List<Feature> Features { get; set; }

        /// <summary>
        /// 是否为父类目属性
        /// </summary>
        [XmlElement("is_parent")]
        public bool IsParent { get; set; }

        /// <summary>
        /// 修改时间（类目增量专用）
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 三种枚举类型：modify，add，delete (增量类目专用)
        /// </summary>
        [XmlElement("modified_type")]
        public string ModifiedType { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性值别名
        /// </summary>
        [XmlElement("name_alias")]
        public string NameAlias { get; set; }

        /// <summary>
        /// 属性 ID
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }

        /// <summary>
        /// 属性名
        /// </summary>
        [XmlElement("prop_name")]
        public string PropName { get; set; }

        /// <summary>
        /// 排列序号。取值范围:大于零的整数
        /// </summary>
        [XmlElement("sort_order")]
        public long SortOrder { get; set; }

        /// <summary>
        /// 状态。可选值:normal(正常),deleted(删除)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 属性值ID
        /// </summary>
        [XmlElement("vid")]
        public long Vid { get; set; }
    }
}
