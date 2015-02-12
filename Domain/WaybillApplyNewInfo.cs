using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplyNewInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplyNewInfo : TopObject
    {
        /// <summary>
        /// 包裹对应的派件（收件）物流服务商网点（分支机构）代码
        /// </summary>
        [XmlElement("consignee_branch_code")]
        public string ConsigneeBranchCode { get; set; }

        /// <summary>
        /// 包裹对应的派件（收件）物流服务商网点（分支机构）名称
        /// </summary>
        [XmlElement("consignee_branch_name")]
        public string ConsigneeBranchName { get; set; }

        /// <summary>
        /// 预留字段
        /// </summary>
        [XmlElement("feature")]
        public string Feature { get; set; }

        /// <summary>
        /// --
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }

        /// <summary>
        /// 面单号对应的物流服务商网点（分支机构）代码
        /// </summary>
        [XmlElement("shipping_branch_code")]
        public string ShippingBranchCode { get; set; }

        /// <summary>
        /// 面单号对于的物流服务商网点（分支机构）名称
        /// </summary>
        [XmlElement("shipping_branch_name")]
        public string ShippingBranchName { get; set; }

        /// <summary>
        /// 根据收货地址返回大头笔信息
        /// </summary>
        [XmlElement("short_address")]
        public string ShortAddress { get; set; }

        /// <summary>
        /// 面单对应的订单列
        /// </summary>
        [XmlElement("trade_order_info")]
        public TradeOrderInfo TradeOrderInfo { get; set; }

        /// <summary>
        /// 返回的面单号
        /// </summary>
        [XmlElement("waybill_code")]
        public string WaybillCode { get; set; }
    }
}
