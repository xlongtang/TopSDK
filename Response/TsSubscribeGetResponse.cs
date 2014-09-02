using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TsSubscribeGetResponse.
    /// </summary>
    public class TsSubscribeGetResponse : TopResponse
    {
        /// <summary>
        /// 订购关系对象
        /// </summary>
        [XmlElement("service_subscribe")]
        public ServiceSubscribe ServiceSubscribe { get; set; }
    }
}
