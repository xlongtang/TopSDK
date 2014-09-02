using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SpItemInfoListAdvancedGetResponse.
    /// </summary>
    public class SpItemInfoListAdvancedGetResponse : TopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("sp_item_info")]
        public List<SpItemInfo> ItemList { get; set; }
    }
}
