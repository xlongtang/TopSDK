using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGroupMoveResponse.
    /// </summary>
    public class CrmGroupMoveResponse : TopResponse
    {
        /// <summary>
        /// 异步任务请求成功，是否执行完毕需要通过taobao.crm.grouptask.check检测
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
