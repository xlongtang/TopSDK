using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TopShopGroupByCity Data Structure.
    /// </summary>
    [Serializable]
    public class TopShopGroupByCity : TopObject
    {
        /// <summary>
        /// 城市id
        /// </summary>
        [XmlElement("cityid")]
        public long Cityid { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("cityname")]
        public string Cityname { get; set; }

        /// <summary>
        /// 店铺list
        /// </summary>
        [XmlArray("shoplist")]
        [XmlArrayItem("top_shop")]
        public List<TopShop> Shoplist { get; set; }
    }
}
