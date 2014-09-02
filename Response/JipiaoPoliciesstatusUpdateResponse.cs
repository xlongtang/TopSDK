using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoPoliciesstatusUpdateResponse.
    /// </summary>
    public class JipiaoPoliciesstatusUpdateResponse : TopResponse
    {
        /// <summary>
        /// 代理商核对接收处理信息的时间序号
        /// </summary>
        [XmlElement("invoke_id")]
        public string InvokeId { get; set; }

        /// <summary>
        /// 机票政策状态更新任务提交结果，true，成功；false，失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
