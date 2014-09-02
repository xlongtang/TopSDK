using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ImprFeedIdDO Data Structure.
    /// </summary>
    [Serializable]
    public class ImprFeedIdDO : TopObject
    {
        /// <summary>
        /// 存放主评和追评的评价标签信息  biz_type(1:主评 2:追评)
        /// </summary>
        [XmlArray("feed_info_list")]
        [XmlArrayItem("impr_feed_info_d_o")]
        public List<ImprFeedInfoDO> FeedInfoList { get; set; }

        /// <summary>
        /// 被评价者昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 评价结果（1好评 0中评 -1差评）
        /// </summary>
        [XmlElement("rate")]
        public long Rate { get; set; }
    }
}
