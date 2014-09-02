using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGroupAddResponse.
    /// </summary>
    public class CrmGroupAddResponse : TopResponse
    {
        /// <summary>
        /// 新增分组的id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 添加分组是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
