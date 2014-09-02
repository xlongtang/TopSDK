using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// UdpItemGetResponse.
    /// </summary>
    public class UdpItemGetResponse : TopResponse
    {
        /// <summary>
        /// 指标查询返回结果
        /// </summary>
        [XmlElement("content")]
        public TargetSearchTopResult Content { get; set; }
    }
}
