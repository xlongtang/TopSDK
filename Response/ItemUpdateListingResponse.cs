using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemUpdateListingResponse.
    /// </summary>
    public class ItemUpdateListingResponse : TopResponse
    {
        /// <summary>
        /// 上架后返回的商品信息：返回的结果就是:num_iid和modified
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
