using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// DeleteVideoResponse.
    /// </summary>
    public class DeleteVideoResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
