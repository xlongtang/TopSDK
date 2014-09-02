using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SellercatsListGetResponse.
    /// </summary>
    public class SellercatsListGetResponse : TopResponse
    {
        /// <summary>
        /// 卖家自定义类目
        /// </summary>
        [XmlArray("seller_cats")]
        [XmlArrayItem("seller_cat")]
        public List<SellerCat> SellerCats { get; set; }
    }
}
