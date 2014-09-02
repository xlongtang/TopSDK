using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoPoliciesAddResponse.
    /// </summary>
    public class JipiaoPoliciesAddResponse : TopResponse
    {
        /// <summary>
        /// 当前调用生成的编号，方便与异步返回的结果对应
        /// </summary>
        [XmlElement("invoke_id")]
        public string InvokeId { get; set; }

        /// <summary>
        /// 机票政策上传结果，true，成功；false，失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
