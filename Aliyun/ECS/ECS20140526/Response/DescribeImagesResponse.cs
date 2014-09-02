using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeImagesResponse.
    /// </summary>
    public class DescribeImagesResponse : AliyunResponse
    {
        /// <summary>
        /// 镜像信息组成的集合
        /// </summary>
        [XmlArray("Images")]
        [XmlArrayItem("Image")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("PageNumber")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页最大行数，默认 10 行，最大值 50 行
        /// </summary>
        [XmlElement("PageSize")]
        public long PageSize { get; set; }

        /// <summary>
        /// 实例所属于的 Region ID
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 镜像总数
        /// </summary>
        [XmlElement("TotalCount")]
        public long TotalCount { get; set; }
    }
}
