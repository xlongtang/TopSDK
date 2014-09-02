using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// AddVideoResponse.
    /// </summary>
    public class AddVideoResponse : AliyunResponse
    {
        /// <summary>
        /// 视频在媒资库中唯一媒资ID
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
