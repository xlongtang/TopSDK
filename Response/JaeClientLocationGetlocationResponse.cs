using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JaeClientLocationGetlocationResponse.
    /// </summary>
    public class JaeClientLocationGetlocationResponse : TopResponse
    {
        /// <summary>
        /// 定位精度
        /// </summary>
        [XmlElement("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        [XmlElement("areacode")]
        public string Areacode { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("citycode")]
        public string Citycode { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("cityname")]
        public string Cityname { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 地理信息描述
        /// </summary>
        [XmlElement("poi")]
        public string Poi { get; set; }
    }
}
