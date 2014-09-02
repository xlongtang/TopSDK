using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TravelItemsUpdateResponse.
    /// </summary>
    public class TravelItemsUpdateResponse : TopResponse
    {
        /// <summary>
        /// 旅游商品结构。
        /// </summary>
        [XmlElement("travel_items")]
        public TravelItems TravelItems { get; set; }
    }
}
