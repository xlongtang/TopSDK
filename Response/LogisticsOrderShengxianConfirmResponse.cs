using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// LogisticsOrderShengxianConfirmResponse.
    /// </summary>
    public class LogisticsOrderShengxianConfirmResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 发货成功后，返回承运商的信息
        /// </summary>
        [XmlElement("ship_fresh")]
        public ShipFresh ShipFresh { get; set; }
    }
}
