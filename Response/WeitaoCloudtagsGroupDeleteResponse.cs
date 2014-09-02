using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCloudtagsGroupDeleteResponse.
    /// </summary>
    public class WeitaoCloudtagsGroupDeleteResponse : TopResponse
    {
        /// <summary>
        /// 业务是否执行成功，result仅是系统调用是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
