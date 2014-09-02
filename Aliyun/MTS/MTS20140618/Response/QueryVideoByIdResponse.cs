using System;
using System.Xml.Serialization;
using Aliyun.Api;
using Aliyun.Api.Domain;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// QueryVideoByIdResponse.
    /// </summary>
    public class QueryVideoByIdResponse : AliyunResponse
    {
        /// <summary>
        /// RequestId
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 视频信息
        /// </summary>
        [XmlElement("Video")]
        public Video Video { get; set; }
    }
}
