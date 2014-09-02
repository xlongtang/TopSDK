using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.MTS.MTS20140618.Response
{
    /// <summary>
    /// SearchVideoListResponse.
    /// </summary>
    public class SearchVideoListResponse : AliyunResponse
    {
        /// <summary>
        /// 当前页面
        /// </summary>
        [XmlElement("PageNumber")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页查询时设置的每页行数
        /// </summary>
        [XmlElement("PageSize")]
        public long PageSize { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("TotalCount")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 视频列表
        /// </summary>
        [XmlArray("VideoList")]
        [XmlArrayItem("Video")]
        public List<Video> VideoList { get; set; }
    }
}
