using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelRoomUpdateResponse.
    /// </summary>
    public class HotelRoomUpdateResponse : TopResponse
    {
        /// <summary>
        /// 商品结构
        /// </summary>
        [XmlElement("room")]
        public Room Room { get; set; }
    }
}
