using System;
using System.Xml.Serialization;
using Top.Api;
using System.Collections.Generic;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Video Data Structure.
    /// </summary>
    [Serializable]
    public class Video : TopObject
    {
        /// <summary>
        /// 视频封面图片
        /// </summary>
        [XmlElement("CoverUrl")]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 视频描述
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 视频原始文件地址信息
        /// </summary>
        [XmlElement("InputFile")]
        public OSSFile InputFile { get; set; }

        /// <summary>
        /// 视频媒资Id
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// 视频标签列表
        /// </summary>
        [XmlArray("Tags")]
        [XmlArrayItem("VideoTag")]
        public List<VideoTag> Tags { get; set; }

        /// <summary>
        /// 视频标题
        /// </summary>
        [XmlElement("Title")]
        public string Title { get; set; }

        /// <summary>
        /// 视频固有特征信息
        /// </summary>
        [XmlElement("VideoFeatures")]
        public VideoFeatures VideoFeatures { get; set; }

        /// <summary>
        /// 视频的状态：1是正常,0是媒资已经被删除
        /// </summary>
        [XmlElement("VideoStatus")]
        public long VideoStatus { get; set; }
    }
}
