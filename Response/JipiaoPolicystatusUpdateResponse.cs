using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoPolicystatusUpdateResponse.
    /// </summary>
    public class JipiaoPolicystatusUpdateResponse : TopResponse
    {
        /// <summary>
        /// 机票政策状态更新结果，true，成功；false，失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
