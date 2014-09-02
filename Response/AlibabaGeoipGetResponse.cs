using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaGeoipGetResponse.
    /// </summary>
    public class AlibabaGeoipGetResponse : TopResponse
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市id
        /// </summary>
        [XmlElement("cityid")]
        public string Cityid { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 国家编码
        /// </summary>
        [XmlElement("countryid")]
        public string Countryid { get; set; }

        /// <summary>
        /// 县
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 县ID
        /// </summary>
        [XmlElement("countyid")]
        public string Countyid { get; set; }

        /// <summary>
        /// IP地址字符串
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 运营商名称
        /// </summary>
        [XmlElement("isp")]
        public string Isp { get; set; }

        /// <summary>
        /// 运营商id
        /// </summary>
        [XmlElement("ispid")]
        public string Ispid { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [XmlElement("lang")]
        public string Lang { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// IP地址的整数值
        /// </summary>
        [XmlElement("lip")]
        public long Lip { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 地区名称
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 地区编码
        /// </summary>
        [XmlElement("regionid")]
        public string Regionid { get; set; }
    }
}
