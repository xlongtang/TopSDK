using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelSoldHotelsIncrementGetResponse.
    /// </summary>
    public class HotelSoldHotelsIncrementGetResponse : TopResponse
    {
        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 多个酒店结构
        /// </summary>
        [XmlArray("hotels")]
        [XmlArrayItem("hotel")]
        public List<Hotel> Hotels { get; set; }

        /// <summary>
        /// 符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
