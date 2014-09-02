using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmMembergradeSetResponse.
    /// </summary>
    public class CrmMembergradeSetResponse : TopResponse
    {
        /// <summary>
        /// 是否保存成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
