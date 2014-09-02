using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ShoprecommendShopsGetResponse.
    /// </summary>
    public class ShoprecommendShopsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回与店铺关联的店铺集
        /// </summary>
        [XmlArray("favorite_shops")]
        [XmlArrayItem("favorite_shop")]
        public List<FavoriteShop> FavoriteShops { get; set; }
    }
}
