using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TripJipiaoAgentOrderSuccessResponse.
    /// </summary>
    public class TripJipiaoAgentOrderSuccessResponse : TopResponse
    {
        /// <summary>
        /// 返回操作成功失败信息
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
