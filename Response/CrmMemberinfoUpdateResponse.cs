using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// CrmMemberinfoUpdateResponse.
    /// </summary>
    public class CrmMemberinfoUpdateResponse : TopResponse
    {
        /// <summary>
        /// 会员信息修改是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
