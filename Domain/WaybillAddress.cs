using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillAddress Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillAddress : TopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address_detail")]
        public string AddressDetail { get; set; }

        /// <summary>
        /// --
        /// </summary>
        [XmlElement("address_format")]
        public string AddressFormat { get; set; }

        /// <summary>
        /// 区名称（三级地址）
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 三级地址代码
        /// </summary>
        [XmlElement("area_code")]
        public long AreaCode { get; set; }

        /// <summary>
        /// 市名称（二级地址）
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 二级地址代码
        /// </summary>
        [XmlElement("city_code")]
        public long CityCode { get; set; }

        /// <summary>
        /// 末级地址
        /// </summary>
        [XmlElement("division_id")]
        public long DivisionId { get; set; }

        /// <summary>
        /// 省名称（一级地址）
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 一级地址代码
        /// </summary>
        [XmlElement("province_code")]
        public long ProvinceCode { get; set; }

        /// <summary>
        /// 街道\镇名称（四级地址）
        /// </summary>
        [XmlElement("town")]
        public string Town { get; set; }

        /// <summary>
        /// 四级地址代码
        /// </summary>
        [XmlElement("town_code")]
        public long TownCode { get; set; }

        /// <summary>
        /// waybill 地址记录ID(非地址库ID)
        /// </summary>
        [XmlElement("waybill_address_id")]
        public long WaybillAddressId { get; set; }
    }
}
