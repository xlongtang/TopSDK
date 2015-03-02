using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplyCancelRequest Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplyCancelRequest : TopObject
    {
        /// <summary>
        /// TOP平台请求的ISV APPKEY
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// CP快递公司编码
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// ERP订单号或包裹号
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// 面单使用者编号
        /// </summary>
        [XmlElement("real_user_id")]
        public long RealUserId { get; set; }

        /// <summary>
        /// 申请者ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 交易订单列表
        /// </summary>
        [XmlArray("trade_order_list")]
        [XmlArrayItem("string")]
        public List<string> TradeOrderList { get; set; }

        /// <summary>
        /// 电子面单号码
        /// </summary>
        [XmlElement("waybill_code")]
        public string WaybillCode { get; set; }
    }
}
