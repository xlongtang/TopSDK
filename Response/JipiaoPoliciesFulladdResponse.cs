using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoPoliciesFulladdResponse.
    /// </summary>
    public class JipiaoPoliciesFulladdResponse : TopResponse
    {
        /// <summary>
        /// 此对象无效，只是空引用
        /// </summary>
        [XmlElement("empty")]
        public BatchPolicy Empty { get; set; }

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
