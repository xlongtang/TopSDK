using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// MediaFileDeleteResponse.
    /// </summary>
    public class MediaFileDeleteResponse : TopResponse
    {
        /// <summary>
        /// 全部删除成功返回“”，部分删除成功返回没有删除成功的id
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
