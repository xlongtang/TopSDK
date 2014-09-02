using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemcatsIncrementGetResponse.
    /// </summary>
    public class ItemcatsIncrementGetResponse : TopResponse
    {
        /// <summary>
        /// 增量类目信息
        /// </summary>
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<ItemCat> ItemCats { get; set; }

        /// <summary>
        /// 类目属性信息
        /// </summary>
        [XmlArray("item_props")]
        [XmlArrayItem("item_prop")]
        public List<ItemProp> ItemProps { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlArray("prop_values")]
        [XmlArrayItem("prop_value")]
        public List<PropValue> PropValues { get; set; }
    }
}
