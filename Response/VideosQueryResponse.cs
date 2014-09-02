using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// VideosQueryResponse.
    /// </summary>
    public class VideosQueryResponse : TopResponse
    {
        /// <summary>
        /// 批量查询返回的视频列表，返回具体信息为入参fields请求的字段信息
        /// </summary>
        [XmlArray("video_items")]
        [XmlArrayItem("video_item")]
        public List<VideoItem> VideoItems { get; set; }
    }
}
