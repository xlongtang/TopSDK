using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiOrderSingleGetResponse.
    /// </summary>
    public class WaimaiOrderSingleGetResponse : TopResponse
    {
        /// <summary>
        /// 订单详情
        /// </summary>
        [XmlElement("result")]
        public TakeoutThirdOrder Result { get; set; }
    }
}
