using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillBranchAccount Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillBranchAccount : TopObject
    {
        /// <summary>
        /// 已用单数
        /// </summary>
        [XmlElement("allocated_quantity")]
        public long AllocatedQuantity { get; set; }

        /// <summary>
        /// 网点ID
        /// </summary>
        [XmlElement("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// 物流服务商ID
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// 可用单数
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 当前网点下的发货地址
        /// </summary>
        [XmlArray("shipp_address_cols")]
        [XmlArrayItem("waybill_address")]
        public List<WaybillAddress> ShippAddressCols { get; set; }
    }
}
