using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelFixbookingResponse.
    /// </summary>
    public class HotelFixbookingResponse : TopResponse
    {
        /// <summary>
        /// 返回hid和时间
        /// </summary>
        [XmlElement("hotel")]
        public Hotel Hotel { get; set; }
    }
}
