using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// VideoItem Data Structure.
    /// </summary>
    [Serializable]
    public class VideoItem : TopObject
    {
        /// <summary>
        /// 视频封面url
        /// </summary>
        [XmlElement("cover_url")]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 视频描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 视频时长
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 是否允许他人观看
        /// </summary>
        [XmlElement("is_open_to_other")]
        public bool IsOpenToOther { get; set; }

        /// <summary>
        /// 视频状态：等待转码（1），转码中（2），转码失败（3），等待审核（4），未通过审核（5），通过审核（6）
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }

        /// <summary>
        /// 视频标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 视频标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 视频上传时间
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }

        /// <summary>
        /// 视频上传者数字id
        /// </summary>
        [XmlElement("uploader_id")]
        public long UploaderId { get; set; }

        /// <summary>
        /// 视频id
        /// </summary>
        [XmlElement("video_id")]
        public long VideoId { get; set; }

        /// <summary>
        /// 视频播放地址
        /// </summary>
        [XmlElement("video_play_info")]
        public VideoPlayInfo VideoPlayInfo { get; set; }
    }
}
