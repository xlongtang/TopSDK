using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemAddResponse.
    /// </summary>
    public class WlbItemAddResponse : TopResponse
    {
        /// <summary>
        /// 新增的商品
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }
    }
}
