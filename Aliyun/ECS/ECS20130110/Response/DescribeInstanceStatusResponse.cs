using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeInstanceStatusResponse.
    /// </summary>
    public class DescribeInstanceStatusResponse : AliyunResponse
    {
        /// <summary>
        /// 返回实例的状态信息列表
        /// </summary>
        [XmlArray("InstanceStatuses")]
        [XmlArrayItem("InstanceStatus")]
        public List<InstanceStatus> InstanceStatuses { get; set; }

        /// <summary>
        /// 实例列表的页码
        /// </summary>
        [XmlElement("PageNumber")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 输入时设置的每页行数
        /// </summary>
        [XmlElement("PageSize")]
        public long PageSize { get; set; }

        /// <summary>
        /// 请求的唯一ID，系统自动生成
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 实例总个数
        /// </summary>
        [XmlElement("TotalCount")]
        public long TotalCount { get; set; }
    }
}
