using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Video Data Structure.
    /// </summary>
    [Serializable]
    public class Video : TopObject
    {
        /// <summary>
        /// 视频关联记录创建时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 视频关联记录的id，和商品相对应
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 视频记录关联的商品的数字id(注意：iid近期即将废弃，请用num_iid参数)
        /// </summary>
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 视频关联记录修改时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 视频记录所关联的商品的数字id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// video的url连接地址。淘秀里视频记录里面存储的url地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// video的id，对应于视频在淘秀的存储记录
        /// </summary>
        [XmlElement("video_id")]
        public long VideoId { get; set; }
    }
}
