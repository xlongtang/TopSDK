using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemGetResponse.
    /// </summary>
    public class ItemGetResponse : TopResponse
    {
        /// <summary>
        /// 获取的商品 具体字段根据权限和设定的fields决定
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
