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
        /// 收货网点信息
        /// </summary>
        [XmlElement("consignee_branch_code")]
        public string ConsigneeBranchCode { get; set; }

        /// <summary>
        /// 收货网点编码
        /// </summary>
        [XmlElement("consignee_branch_name")]
        public string ConsigneeBranchName { get; set; }

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
        /// 挑拣规则（大头笔信息）
        /// </summary>
        [XmlElement("short_address")]
        public string ShortAddress { get; set; }

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
