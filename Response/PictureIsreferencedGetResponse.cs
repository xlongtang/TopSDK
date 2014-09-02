using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureIsreferencedGetResponse.
    /// </summary>
    public class PictureIsreferencedGetResponse : TopResponse
    {
        /// <summary>
        /// 图片是否被引用
        /// </summary>
        [XmlElement("is_referenced")]
        public bool IsReferenced { get; set; }
    }
}
