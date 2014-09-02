using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemBsellerAddResponse.
    /// </summary>
    public class ItemBsellerAddResponse : TopResponse
    {
        /// <summary>
        /// 新发布的商品
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
