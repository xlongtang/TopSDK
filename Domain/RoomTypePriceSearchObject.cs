using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// RoomTypePriceSearchObject Data Structure.
    /// </summary>
    [Serializable]
    public class RoomTypePriceSearchObject : TopObject
    {
        /// <summary>
        /// 房型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// rate列表
        /// </summary>
        [XmlArray("rates")]
        [XmlArrayItem("hotel_price_rate")]
        public List<HotelPriceRate> Rates { get; set; }

        /// <summary>
        /// 标准酒店id
        /// </summary>
        [XmlElement("srid")]
        public long Srid { get; set; }
    }
}
