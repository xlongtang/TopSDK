using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SpItemInfoListGetResponse.
    /// </summary>
    public class SpItemInfoListGetResponse : TopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("sp_item")]
        public List<SpItem> ItemList { get; set; }
    }
}
