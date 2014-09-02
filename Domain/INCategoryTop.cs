using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// INCategoryTop Data Structure.
    /// </summary>
    [Serializable]
    public class INCategoryTop : TopObject
    {
        /// <summary>
        /// 子类目列表
        /// </summary>
        [XmlArray("category_child_top_list")]
        [XmlArrayItem("i_n_category_child_top")]
        public List<INCategoryChildTop> CategoryChildTopList { get; set; }

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

        /// <summary>
        /// 用户输入的词
        /// </summary>
        [XmlElement("categroy_word")]
        public string CategroyWord { get; set; }
    }
}
