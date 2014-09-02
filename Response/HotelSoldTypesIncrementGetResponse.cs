using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelSoldTypesIncrementGetResponse.
    /// </summary>
    public class HotelSoldTypesIncrementGetResponse : TopResponse
    {
        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 多个房型结构
        /// </summary>
        [XmlArray("room_types")]
        [XmlArrayItem("room_type")]
        public List<RoomType> RoomTypes { get; set; }

        /// <summary>
        /// 符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
