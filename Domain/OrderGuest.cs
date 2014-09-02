using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// OrderGuest Data Structure.
    /// </summary>
    [Serializable]
    public class OrderGuest : TopObject
    {
        /// <summary>
        /// 入住人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 酒店订单id
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 入住人序号
        /// </summary>
        [XmlElement("person_pos")]
        public long PersonPos { get; set; }

        /// <summary>
        /// 房间序号
        /// </summary>
        [XmlElement("room_pos")]
        public long RoomPos { get; set; }

        /// <summary>
        /// 入住人电话
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }
    }
}
