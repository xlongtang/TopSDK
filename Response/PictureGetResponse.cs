using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PictureGetResponse.
    /// </summary>
    public class PictureGetResponse : TopResponse
    {
        /// <summary>
        /// 图片信息列表
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("picture")]
        public List<Picture> Pictures { get; set; }

        /// <summary>
        /// 总的结果数
        /// </summary>
        [XmlElement("totalResults")]
        public long TotalResults { get; set; }
    }
}
