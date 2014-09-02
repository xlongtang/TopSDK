using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeInstanceTypesResponse.
    /// </summary>
    public class DescribeInstanceTypesResponse : AliyunResponse
    {
        /// <summary>
        /// 实例资源规格项的类型列表
        /// </summary>
        [XmlArray("InstanceTypes")]
        [XmlArrayItem("InstanceType")]
        public List<InstanceType> InstanceTypes { get; set; }

        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
