using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SellercatsListUpdateResponse.
    /// </summary>
    public class SellercatsListUpdateResponse : TopResponse
    {
        /// <summary>
        /// 返回sellercat数据结构中的：cid,modified
        /// </summary>
        [XmlElement("seller_cat")]
        public SellerCat SellerCat { get; set; }
    }
}
