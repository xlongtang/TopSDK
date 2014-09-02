using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderCancelResponse.
    /// </summary>
    public class WlbOrderCancelResponse : TopResponse
    {
        /// <summary>
        /// 错误编码列表
        /// </summary>
        [XmlElement("error_code_list")]
        public string ErrorCodeList { get; set; }

        /// <summary>
        /// 修改时间，只有在取消成功的情况下，才可以做
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }
    }
}
