using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FavoriteSearchResponse.
    /// </summary>
    public class FavoriteSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回查询到的商品或店铺的数字id列表
        /// </summary>
        [XmlArray("collect_items")]
        [XmlArrayItem("collect_item")]
        public List<CollectItem> CollectItems { get; set; }

        /// <summary>
        /// 查询到的宝贝的收藏总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
