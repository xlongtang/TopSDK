using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// XhotelCityGetResponse.
    /// </summary>
    public class XhotelCityGetResponse : TopResponse
    {
        /// <summary>
        /// 酒店区域的数据列表
        /// </summary>
        [XmlArray("divisions")]
        [XmlArrayItem("hotel_division")]
        public List<HotelDivision> Divisions { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// 城市数据的版本。所有城市数据有一个统一的版本，与入参start和count无关。 ISV可通过版本判断城市数据是否有更新。判断方法如下：ISV在第一次拉取数据时请将version保存在本地；以后再调用接口时请比较本地version与接口返回的version。如果本地version小于于接口返回version，则说明城市数据有更新；如果本地version等于接口返回version，则说明城市数据无更新，不需要再继续拉取城市数据。
        /// </summary>
        [XmlElement("version")]
        public long Version { get; set; }
    }
}
