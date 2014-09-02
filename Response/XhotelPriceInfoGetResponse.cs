using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// XhotelPriceInfoGetResponse.
    /// </summary>
    public class XhotelPriceInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 酒店价格信息对象
        /// </summary>
        [XmlArray("hotel_prices")]
        [XmlArrayItem("hotel_price_search_object")]
        public List<HotelPriceSearchObject> HotelPrices { get; set; }

        /// <summary>
        /// 返回的信息总条数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
