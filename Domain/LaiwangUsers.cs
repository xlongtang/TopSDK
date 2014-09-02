using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LaiwangUsers Data Structure.
    /// </summary>
    [Serializable]
    public class LaiwangUsers : TopObject
    {
        /// <summary>
        /// 拉取的OPENID个数，最大值为10000
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// OPENID列表数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 拉取列表的后一个用户的OPENID
        /// </summary>
        [XmlElement("next_openid")]
        public string NextOpenid { get; set; }

        /// <summary>
        /// 关注该公众账号的总用户数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
