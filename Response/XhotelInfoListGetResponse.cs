using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// XhotelInfoListGetResponse.
    /// </summary>
    public class XhotelInfoListGetResponse : TopResponse
    {
        /// <summary>
        /// 标准酒店信息
        /// </summary>
        [XmlArray("hotels")]
        [XmlArrayItem("s_hotel_info_object")]
        public List<SHotelInfoObject> Hotels { get; set; }

        /// <summary>
        /// 酒店总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
