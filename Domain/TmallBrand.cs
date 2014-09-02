using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallBrand Data Structure.
    /// </summary>
    [Serializable]
    public class TmallBrand : TopObject
    {
        /// <summary>
        /// 搜索品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 搜索品牌名字
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
