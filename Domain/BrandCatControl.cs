using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// BrandCatControl Data Structure.
    /// </summary>
    [Serializable]
    public class BrandCatControl : TopObject
    {
        /// <summary>
        /// 被管控的品牌的ID号码
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 被管控的品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 被管控的类目的ID号
        /// </summary>
        [XmlElement("cat_id")]
        public long CatId { get; set; }

        /// <summary>
        /// 被管控的类目的ID号
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }

        /// <summary>
        /// 以;隔开多个认证资料。:隔开资料ID与内容。如？1:产品包装图片;2:完整产品资质
        /// </summary>
        [XmlElement("certified_data")]
        public string CertifiedData { get; set; }
    }
}
