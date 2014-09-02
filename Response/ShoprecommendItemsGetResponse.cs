using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ShoprecommendItemsGetResponse.
    /// </summary>
    public class ShoprecommendItemsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回与店铺关联的宝贝集合
        /// </summary>
        [XmlArray("favorite_items")]
        [XmlArrayItem("favorite_item")]
        public List<FavoriteItem> FavoriteItems { get; set; }
    }
}
