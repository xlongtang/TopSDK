using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// INCategoryBase Data Structure.
    /// </summary>
    [Serializable]
    public class INCategoryBase : TopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目展现量
        /// </summary>
        [XmlElement("category_pv")]
        public long CategoryPv { get; set; }

        /// <summary>
        /// 类目数据信息列表
        /// </summary>
        [XmlArray("in_record_base_list")]
        [XmlArrayItem("i_n_record_base")]
        public List<INRecordBase> InRecordBaseList { get; set; }
    }
}
