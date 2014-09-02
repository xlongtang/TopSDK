using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// LogisticsOrderstorePushResponse.
    /// </summary>
    public class LogisticsOrderstorePushResponse : TopResponse
    {
        /// <summary>
        /// 返回结果是否成功is_success
        /// </summary>
        [XmlElement("shipping")]
        public Shipping Shipping { get; set; }
    }
}
