using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// UpdateVideoResponse.
    /// </summary>
    public class UpdateVideoResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
