using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// RebootInstanceResponse.
    /// </summary>
    public class RebootInstanceResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
