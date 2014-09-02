using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallBrandcatControlGetResponse.
    /// </summary>
    public class TmallBrandcatControlGetResponse : TopResponse
    {
        /// <summary>
        /// 被管控的类目和品牌信息。如何判断一个产品是否被管控，是去品牌的信息和类目信息做一个交集。
        /// </summary>
        [XmlElement("brand_cat_control_info")]
        public BrandCatControlInfo BrandCatControlInfo { get; set; }
    }
}
