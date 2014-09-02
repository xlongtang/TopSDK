using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRegisterResponse.
    /// </summary>
    public class TmallEaiOrderRegisterResponse : TopResponse
    {
        /// <summary>
        /// 操作插入删除或者更新的记录数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 调用结果成功与否
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
