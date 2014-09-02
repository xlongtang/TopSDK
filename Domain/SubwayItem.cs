using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubwayItem Data Structure.
    /// </summary>
    [Serializable]
    public class SubwayItem : TopObject
    {
        /// <summary>
        /// 扩展属性对象
        /// </summary>
        [XmlElement("extra_attributes")]
        public ExtraAttributes ExtraAttributes { get; set; }

        /// <summary>
        /// 商品信息在外部系统(淘宝主站)的数字id
        /// </summary>
        [XmlElement("num_id")]
        public long NumId { get; set; }

        /// <summary>
        /// 商品信息在外部系统（淘宝主站）的价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品信息在外部系统（淘宝主站）的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
