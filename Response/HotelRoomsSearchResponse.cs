using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelRoomsSearchResponse.
    /// </summary>
    public class HotelRoomsSearchResponse : TopResponse
    {
        /// <summary>
        /// 多个商品结构。是否返回酒店信息、房型信息、房态列表、宝贝描述根据参数决定
        /// </summary>
        [XmlArray("rooms")]
        [XmlArrayItem("room")]
        public List<Room> Rooms { get; set; }

        /// <summary>
        /// 符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
