using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// XiamiSellerlist Data Structure.
    /// </summary>
    [Serializable]
    public class XiamiSellerlist : TopObject
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 卖家销售详情list
        /// </summary>
        [XmlArray("info")]
        [XmlArrayItem("xiami_sellerlist_info")]
        public List<XiamiSellerlistInfo> Info { get; set; }
    }
}
