using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmGroupUpdateResponse.
    /// </summary>
    public class CrmGroupUpdateResponse : TopResponse
    {
        /// <summary>
        /// 分组修改是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
