using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// HotelPriceSearchObject Data Structure.
    /// </summary>
    [Serializable]
    public class HotelPriceSearchObject : TopObject
    {
        /// <summary>
        /// 结束 时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 最低价
        /// </summary>
        [XmlElement("low_price")]
        public long LowPrice { get; set; }

        /// <summary>
        /// 房型价格信息
        /// </summary>
        [XmlArray("rooms")]
        [XmlArrayItem("room_type_price_search_object")]
        public List<RoomTypePriceSearchObject> Rooms { get; set; }

        /// <summary>
        /// 标准酒店id
        /// </summary>
        [XmlElement("shid")]
        public long Shid { get; set; }

        /// <summary>
        /// 开始 时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
