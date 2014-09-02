using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelRoomImgUploadResponse.
    /// </summary>
    public class HotelRoomImgUploadResponse : TopResponse
    {
        /// <summary>
        /// 商品图片结构
        /// </summary>
        [XmlElement("room_image")]
        public RoomImage RoomImage { get; set; }
    }
}
