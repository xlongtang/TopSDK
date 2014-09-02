using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// QueryVideoListByIdsResponse.
    /// </summary>
    public class QueryVideoListByIdsResponse : AliyunResponse
    {
        /// <summary>
        /// 不存在的视频ID列表
        /// </summary>
        [XmlArray("NonExistMids")]
        [XmlArrayItem("String")]
        public List<string> NonExistMids { get; set; }

        /// <summary>
        /// 不属于用户的视频ID列表
        /// </summary>
        [XmlArray("PermissionDeniedMids")]
        [XmlArrayItem("String")]
        public List<string> PermissionDeniedMids { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 视频列表
        /// </summary>
        [XmlArray("VideoList")]
        [XmlArrayItem("Video")]
        public List<Video> VideoList { get; set; }
    }
}
