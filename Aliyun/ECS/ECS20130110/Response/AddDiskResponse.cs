using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// AddDiskResponse.
    /// </summary>
    public class AddDiskResponse : AliyunResponse
    {
        /// <summary>
        /// 磁盘代号
        /// </summary>
        [XmlElement("DiskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// 请求的唯一ID，系统自动生成
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
