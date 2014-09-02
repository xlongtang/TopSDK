using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// HotelDivision Data Structure.
    /// </summary>
    [Serializable]
    public class HotelDivision : TopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("code")]
        public long Code { get; set; }

        /// <summary>
        /// 层级，1：国家，2：州省，3：城市，4：区县
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父行政区编码，例如杭州市(330100)的父行政区为浙江省(330000)。注意：如果parent_code的值为0，表示该行政区为最高级别的行政区，没有父行政区。
        /// </summary>
        [XmlElement("parent_code")]
        public long ParentCode { get; set; }

        /// <summary>
        /// 0：国内；1：国外
        /// </summary>
        [XmlElement("region")]
        public long Region { get; set; }

        /// <summary>
        /// code是否可用来搜索酒店，true：code可直接用于搜索酒店，false: code不可直接用于搜索酒店。
        /// </summary>
        [XmlElement("searchable")]
        public bool Searchable { get; set; }

        /// <summary>
        /// 类型，0：普通，1：景点,cityTag，如千岛湖
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
