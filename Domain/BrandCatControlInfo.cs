using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// BrandCatControlInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandCatControlInfo : TopObject
    {
        /// <summary>
        /// 管控的品牌类目信息，一组列表
        /// </summary>
        [XmlArray("brand_cat_controls")]
        [XmlArrayItem("brand_cat_control")]
        public List<BrandCatControl> BrandCatControls { get; set; }
    }
}
