using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplyUpdateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplyUpdateInfo : TopObject
    {
        /// <summary>
        /// --
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// --
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }

        /// <summary>
        /// --
        /// </summary>
        [XmlElement("trade_order_info")]
        public TradeOrderInfo TradeOrderInfo { get; set; }

        /// <summary>
        /// --
        /// </summary>
        [XmlElement("waybill_code")]
        public string WaybillCode { get; set; }
    }
}
