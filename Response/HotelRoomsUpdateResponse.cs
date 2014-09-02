using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelRoomsUpdateResponse.
    /// </summary>
    public class HotelRoomsUpdateResponse : TopResponse
    {
        /// <summary>
        /// 成功的gid list
        /// </summary>
        [XmlArray("gids")]
        [XmlArrayItem("string")]
        public List<string> Gids { get; set; }
    }
}
