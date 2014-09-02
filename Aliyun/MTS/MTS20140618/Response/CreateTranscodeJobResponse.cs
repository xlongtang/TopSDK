using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// CreateTranscodeJobResponse.
    /// </summary>
    public class CreateTranscodeJobResponse : AliyunResponse
    {
        /// <summary>
        /// 转码任务ID
        /// </summary>
        [XmlElement("JobId")]
        public string JobId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
