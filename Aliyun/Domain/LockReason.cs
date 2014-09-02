using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// LockReason Data Structure.
    /// </summary>
    [Serializable]
    public class LockReason : TopObject
    {
        /// <summary>
        /// 操作锁的原因
        /// </summary>
        [XmlElement("LockReason")]
        public string LockReason_ { get; set; }
    }
}
