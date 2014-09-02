using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemCsellerAddResponse.
    /// </summary>
    public class ItemCsellerAddResponse : TopResponse
    {
        /// <summary>
        /// 新发布的商品
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
