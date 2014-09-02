using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallBrandcatMetadataGetResponse.
    /// </summary>
    public class TmallBrandcatMetadataGetResponse : TopResponse
    {
        /// <summary>
        /// 类目、品牌下的达尔文元数据
        /// </summary>
        [XmlElement("brand_cat_meta_data")]
        public BrandCatMetaData BrandCatMetaData { get; set; }
    }
}
