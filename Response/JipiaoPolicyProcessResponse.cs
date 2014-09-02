using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoPolicyProcessResponse.
    /// </summary>
    public class JipiaoPolicyProcessResponse : TopResponse
    {
        /// <summary>
        /// 机票政策添加返回状态，true，成功；false，失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回政策主键id(机票系统唯一id)
        /// </summary>
        [XmlElement("policy_id")]
        public long PolicyId { get; set; }
    }
}
