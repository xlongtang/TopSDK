using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// VideosDeleteResponse.
    /// </summary>
    public class VideosDeleteResponse : TopResponse
    {
        /// <summary>
        /// 全部删除成功返回true，不支持部分删除
        /// </summary>
        [XmlElement("model")]
        public bool Model { get; set; }
    }
}
