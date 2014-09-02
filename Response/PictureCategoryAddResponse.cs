using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureCategoryAddResponse.
    /// </summary>
    public class PictureCategoryAddResponse : TopResponse
    {
        /// <summary>
        /// 图片分类信息
        /// </summary>
        [XmlElement("picture_category")]
        public PictureCategory PictureCategory { get; set; }
    }
}
