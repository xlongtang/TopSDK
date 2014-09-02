using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// XhotelListSearchResponse.
    /// </summary>
    public class XhotelListSearchResponse : TopResponse
    {
        /// <summary>
        /// 渠道ID
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// h5的list的url
        /// </summary>
        [XmlElement("h5_list_url")]
        public string H5ListUrl { get; set; }

        /// <summary>
        /// 酒店list的url
        /// </summary>
        [XmlElement("hotel_list_url")]
        public string HotelListUrl { get; set; }

        /// <summary>
        /// 酒店列表结果集
        /// </summary>
        [XmlArray("hotels")]
        [XmlArrayItem("search_hotel_object")]
        public List<SearchHotelObject> Hotels { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 酒店总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
