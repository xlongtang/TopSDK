using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TraderateExplainAddResponse.
    /// </summary>
    public class TraderateExplainAddResponse : TopResponse
    {
        /// <summary>
        /// 商城卖家给评价解释是否成功。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
