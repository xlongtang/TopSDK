using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcUserCancelResponse.
    /// </summary>
    public class TmcUserCancelResponse : TopResponse
    {
        /// <summary>
        /// 是否成功,如果为false并且没有错误码，表示删除的用户不存在。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
