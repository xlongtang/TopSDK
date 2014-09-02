using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ShopcatsListGetResponse.
    /// </summary>
    public class ShopcatsListGetResponse : TopResponse
    {
        /// <summary>
        /// 店铺类目列表信息
        /// </summary>
        [XmlArray("shop_cats")]
        [XmlArrayItem("shop_cat")]
        public List<ShopCat> ShopCats { get; set; }
    }
}
