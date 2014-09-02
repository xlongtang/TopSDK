using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCloudtagsGroupAddResponse.
    /// </summary>
    public class WeitaoCloudtagsGroupAddResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 是否添加成功
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
