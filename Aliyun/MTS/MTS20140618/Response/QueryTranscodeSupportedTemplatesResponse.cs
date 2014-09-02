using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// QueryTranscodeSupportedTemplatesResponse.
    /// </summary>
    public class QueryTranscodeSupportedTemplatesResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 预处理状态，1表示正在预处理中，2表示预处理完成，3表示视频预处理失败
        /// </summary>
        [XmlElement("Status")]
        public long Status { get; set; }

        /// <summary>
        /// 视频预处理成功时返回的推荐模板，其余状态都返回NULL
        /// </summary>
        [XmlArray("TranscodeTemplates")]
        [XmlArrayItem("TranscodeTemplate")]
        public List<TranscodeTemplate> TranscodeTemplates { get; set; }
    }
}
