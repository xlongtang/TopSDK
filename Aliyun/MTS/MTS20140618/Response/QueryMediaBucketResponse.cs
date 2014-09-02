using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// QueryMediaBucketResponse.
    /// </summary>
    public class QueryMediaBucketResponse : AliyunResponse
    {
        /// <summary>
        /// 当用户订购视频服务后，云视频服务会创建一个bucket供用户上传使用，用户使用MTS客户端SDK上传视频时指定到此bucket
        /// </summary>
        [XmlElement("BucketName")]
        public string BucketName { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
