using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RpReturngoodsAgreeResponse.
    /// </summary>
    public class RpReturngoodsAgreeResponse : TopResponse
    {
        /// <summary>
        /// 同意退货返回对象
        /// </summary>
        [XmlElement("response")]
        public RefundBaseResponse Response { get; set; }
    }
}
