using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemEbookSerialUpdateResponse.
    /// </summary>
    public class ItemEbookSerialUpdateResponse : TopResponse
    {
        /// <summary>
        /// 商品结构里的num_iid，modified
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
