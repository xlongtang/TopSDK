using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// QueryTranscodeJobListResponse.
    /// </summary>
    public class QueryTranscodeJobListResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 视频转码任务列表
        /// </summary>
        [XmlArray("TranscodeJobs")]
        [XmlArrayItem("VideoTranscodeJob")]
        public List<VideoTranscodeJob> TranscodeJobs { get; set; }
    }
}
