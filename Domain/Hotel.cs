using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Hotel Data Structure.
    /// </summary>
    [Serializable]
    public class Hotel : TopObject
    {
        /// <summary>
        /// 酒店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 某个卖家发布的酒店的别名(注：该字段将要废弃)
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 酒店审核被否决的原因
        /// </summary>
        [XmlElement("audit_deny_reason")]
        public string AuditDenyReason { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city")]
        public long City { get; set; }

        /// <summary>
        /// 城市中文名称
        /// </summary>
        [XmlElement("city_str")]
        public string CityStr { get; set; }

        /// <summary>
        /// 国家编码
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 国家中文名称
        /// </summary>
        [XmlElement("country_str")]
        public string CountryStr { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 装修时间
        /// </summary>
        [XmlElement("decorate_time")]
        public string DecorateTime { get; set; }

        /// <summary>
        /// 酒店介绍
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("district")]
        public long District { get; set; }

        /// <summary>
        /// 区域中文名称
        /// </summary>
        [XmlElement("district_str")]
        public string DistrictStr { get; set; }

        /// <summary>
        /// 酒店id
        /// </summary>
        [XmlElement("hid")]
        public long Hid { get; set; }

        /// <summary>
        /// 酒店级别
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 开业时间
        /// </summary>
        [XmlElement("opening_time")]
        public string OpeningTime { get; set; }

        /// <summary>
        /// 酒店定位
        /// </summary>
        [XmlElement("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// 酒店图片url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province")]
        public long Province { get; set; }

        /// <summary>
        /// 省份中文名称
        /// </summary>
        [XmlElement("province_str")]
        public string ProvinceStr { get; set; }

        /// <summary>
        /// 房型列表
        /// </summary>
        [XmlArray("room_types")]
        [XmlArrayItem("room_type")]
        public List<RoomType> RoomTypes { get; set; }

        /// <summary>
        /// 房间数
        /// </summary>
        [XmlElement("rooms")]
        public long Rooms { get; set; }

        /// <summary>
        /// 交通距离与设施服务。JSON格式串。
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }

        /// <summary>
        /// 状态。0：待审核，1：正常（审核通过），2：审核否决，3：停售
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 楼层数
        /// </summary>
        [XmlElement("storeys")]
        public long Storeys { get; set; }

        /// <summary>
        /// 酒店电话
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }
    }
}
