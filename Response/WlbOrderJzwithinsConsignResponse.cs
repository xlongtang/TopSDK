using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderJzwithinsConsignResponse.
    /// </summary>
    public class WlbOrderJzwithinsConsignResponse : TopResponse
    {
        /// <summary>
        /// 发货成功或者失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 发货返回信息，如果发货错误则报出对应错误
        /// </summary>
        [XmlElement("result_info")]
        public string ResultInfo { get; set; }
    }
}
