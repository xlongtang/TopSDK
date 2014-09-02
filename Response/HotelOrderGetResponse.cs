using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelOrderGetResponse.
    /// </summary>
    public class HotelOrderGetResponse : TopResponse
    {
        /// <summary>
        /// 订单结构，是否返回入住人列表根据参数决定
        /// </summary>
        [XmlElement("hotel_order")]
        public HotelOrder HotelOrder { get; set; }
    }
}
