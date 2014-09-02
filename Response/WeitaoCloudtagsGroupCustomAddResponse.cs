using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCloudtagsGroupCustomAddResponse.
    /// </summary>
    public class WeitaoCloudtagsGroupCustomAddResponse : TopResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 新创建的自定义分组id，未生效。
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
