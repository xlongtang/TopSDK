using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SearchHotelObject Data Structure.
    /// </summary>
    [Serializable]
    public class SearchHotelObject : TopObject
    {
        /// <summary>
        /// 酒店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 酒店距离搜索中心点的距离，单位：米。注意：在设置了搜索中心点的情况下，才会计算出有效的距离；如果没有设置搜索中心点，则distance的值置为-1。
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// H5的detail页面的URL
        /// </summary>
        [XmlElement("h5_detail_url")]
        public string H5DetailUrl { get; set; }

        /// <summary>
        /// 酒店detail页面的url
        /// </summary>
        [XmlElement("hotel_detail_url")]
        public string HotelDetailUrl { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 星级/档次
        /// </summary>
        [XmlElement("level")]
        public NameValuePair Level { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lng")]
        public string Lng { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片url，多张图片使用","隔开
        /// </summary>
        [XmlElement("pic_urls")]
        public string PicUrls { get; set; }

        /// <summary>
        /// 酒店价格，注意：单位为分。如果price的值为-1，则表示此酒店下无可售的报价。
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        [XmlElement("rate_number")]
        public long RateNumber { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        [XmlElement("rate_score")]
        public string RateScore { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [XmlElement("sell")]
        public long Sell { get; set; }

        /// <summary>
        /// 服务设施
        /// </summary>
        [XmlArray("services")]
        [XmlArrayItem("name_value_pair")]
        public List<NameValuePair> Services { get; set; }

        /// <summary>
        /// 标准酒店ID
        /// </summary>
        [XmlElement("shid")]
        public long Shid { get; set; }

        /// <summary>
        /// 电话，包括三种类型：  1.固定电话，例如：0086-010-85322688  2.移动电话，例如：13869696363  3.400或800电话，例如：0086-4006123928
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }
    }
}
