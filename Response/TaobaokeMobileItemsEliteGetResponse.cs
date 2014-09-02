using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeMobileItemsEliteGetResponse.
    /// </summary>
    public class TaobaokeMobileItemsEliteGetResponse : TopResponse
    {
        /// <summary>
        /// 淘宝客精品库商品
        /// </summary>
        [XmlArray("taobaoke_elite_items")]
        [XmlArrayItem("taobaoke_elite_item")]
        public List<TaobaokeEliteItem> TaobaokeEliteItems { get; set; }
    }
}
