using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelUpdateResponse.
    /// </summary>
    public class HotelUpdateResponse : TopResponse
    {
        /// <summary>
        /// 酒店结构
        /// </summary>
        [XmlElement("hotel")]
        public Hotel Hotel { get; set; }
    }
}
