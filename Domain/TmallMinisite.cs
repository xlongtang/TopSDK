using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallMinisite Data Structure.
    /// </summary>
    [Serializable]
    public class TmallMinisite : TopObject
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 店铺优惠信息
        /// </summary>
        [XmlElement("promotions")]
        public string Promotions { get; set; }

        /// <summary>
        /// 店铺名字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
