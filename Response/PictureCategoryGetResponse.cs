using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureCategoryGetResponse.
    /// </summary>
    public class PictureCategoryGetResponse : TopResponse
    {
        /// <summary>
        /// 图片分类
        /// </summary>
        [XmlArray("picture_categories")]
        [XmlArrayItem("picture_category")]
        public List<PictureCategory> PictureCategories { get; set; }
    }
}
