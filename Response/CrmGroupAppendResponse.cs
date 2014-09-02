using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGroupAppendResponse.
    /// </summary>
    public class CrmGroupAppendResponse : TopResponse
    {
        /// <summary>
        /// 异步任务请求成功，添加任务是否完成通过taobao.crm.grouptask.check检测
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
