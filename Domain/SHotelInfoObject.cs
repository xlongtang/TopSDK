using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SHotelInfoObject Data Structure.
    /// </summary>
    [Serializable]
    public class SHotelInfoObject : TopObject
    {
        /// <summary>
        /// 酒店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 酒店品牌
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 市的code
        /// </summary>
        [XmlElement("city")]
        public long City { get; set; }

        /// <summary>
        /// 酒店装修时间
        /// </summary>
        [XmlElement("decorate_time")]
        public string DecorateTime { get; set; }

        /// <summary>
        /// 酒店描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 地区的值
        /// </summary>
        [XmlElement("district")]
        public long District { get; set; }

        /// <summary>
        /// H5的detail页面的URL
        /// </summary>
        [XmlElement("h5_detail_url")]
        public string H5DetailUrl { get; set; }

        /// <summary>
        /// 酒店设施
        /// </summary>
        [XmlElement("hotel_facilities")]
        public string HotelFacilities { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

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
        /// 酒店开业时间
        /// </summary>
        [XmlElement("opening_time")]
        public string OpeningTime { get; set; }

        /// <summary>
        /// 酒店detail页面的url
        /// </summary>
        [XmlElement("pc_detail_url")]
        public string PcDetailUrl { get; set; }

        /// <summary>
        /// 图片url，多张图片使用","隔开
        /// </summary>
        [XmlElement("pic_urls")]
        public string PicUrls { get; set; }

        /// <summary>
        /// 省的code
        /// </summary>
        [XmlElement("province")]
        public long Province { get; set; }

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
        /// 房型信息
        /// </summary>
        [XmlArray("rooms")]
        [XmlArrayItem("s_room_type")]
        public List<SRoomType> Rooms { get; set; }

        /// <summary>
        /// 服务设施
        /// </summary>
        [XmlElement("services")]
        public string Services { get; set; }

        /// <summary>
        /// 标准酒店ID
        /// </summary>
        [XmlElement("shid")]
        public long Shid { get; set; }

        /// <summary>
        /// 酒店星级，1-5星，0是客栈
        /// </summary>
        [XmlElement("star")]
        public string Star { get; set; }

        /// <summary>
        /// 酒店状态,0,营业中；-1，筹建中；-2，暂停营业；-3，已停业；
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 电话，包括三种类型：  1.固定电话，例如：0086-010-85322688  2.移动电话，例如：13869696363  3.400或800电话，例如：0086-4006123928
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// 酒店类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
