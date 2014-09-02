using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelSoldOrdersIncrementGetResponse.
    /// </summary>
    public class HotelSoldOrdersIncrementGetResponse : TopResponse
    {
        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 多个订单结构，是否返回入住人列表根据参数决定
        /// </summary>
        [XmlArray("hotel_orders")]
        [XmlArrayItem("hotel_order")]
        public List<HotelOrder> HotelOrders { get; set; }

        /// <summary>
        /// 搜索到的交易信息总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
