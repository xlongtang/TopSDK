using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureCategoryUpdateResponse.
    /// </summary>
    public class PictureCategoryUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新图片分类是否成功
        /// </summary>
        [XmlElement("done")]
        public bool Done { get; set; }
    }
}
