using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// INCategoryChildTop Data Structure.
    /// </summary>
    [Serializable]
    public class INCategoryChildTop : TopObject
    {
        /// <summary>
        /// 类目属性描述
        /// </summary>
        [XmlElement("category_desc")]
        public string CategoryDesc { get; set; }

        /// <summary>
        /// 类目对象id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目属性对象列表
        /// </summary>
        [XmlArray("category_properties_list")]
        [XmlArrayItem("i_n_category_properties")]
        public List<INCategoryProperties> CategoryPropertiesList { get; set; }
    }
}
