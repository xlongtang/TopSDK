using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbExtorderCancleResponse.
    /// </summary>
    public class WlbExtorderCancleResponse : TopResponse
    {
        /// <summary>
        /// 错误编码列表
        /// </summary>
        [XmlElement("error_code_list")]
        public string ErrorCodeList { get; set; }

        /// <summary>
        /// 修改时间，只有在取消成功的情况下，才有效
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }
    }
}
