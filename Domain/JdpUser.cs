using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// JdpUser Data Structure.
    /// </summary>
    [Serializable]
    public class JdpUser : TopObject
    {
        /// <summary>
        /// rds数据库的实例名
        /// </summary>
        [XmlElement("rds_name")]
        public string RdsName { get; set; }

        /// <summary>
        /// 0:暂停  1：正常  2：sessoin失效，停止  3：已删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
