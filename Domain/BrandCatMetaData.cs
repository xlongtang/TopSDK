using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// BrandCatMetaData Data Structure.
    /// </summary>
    [Serializable]
    public class BrandCatMetaData : TopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 叶子类目id
        /// </summary>
        [XmlElement("cat_id")]
        public long CatId { get; set; }

        /// <summary>
        /// 以;隔开多个认证资料。:隔开资料ID与内容。如？1:产品包装图片;2:完整产品资质
        /// </summary>
        [XmlElement("certified_data")]
        public string CertifiedData { get; set; }

        /// <summary>
        /// 类目、品牌是否切入达尔文
        /// </summary>
        [XmlElement("is_darwin")]
        public bool IsDarwin { get; set; }
    }
}
