using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.BSS.BSS20140714.Response
{
    /// <summary>
    /// SetResourceBusinessStatusResponse.
    /// </summary>
    public class SetResourceBusinessStatusResponse : AliyunResponse
    {
        /// <summary>
        /// 请求的唯一ID，系统自动生成
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
