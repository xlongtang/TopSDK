using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// QueryTranscodeOutputResponse.
    /// </summary>
    public class QueryTranscodeOutputResponse : AliyunResponse
    {
        /// <summary>
        /// RequestId
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 转码输出列表
        /// </summary>
        [XmlArray("TranscodeOutputs")]
        [XmlArrayItem("TranscodeOutput")]
        public List<TranscodeOutput> TranscodeOutputs { get; set; }
    }
}
