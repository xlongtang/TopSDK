using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlipayEbppOweBillUploadResponse.
    /// </summary>
    public class AlipayEbppOweBillUploadResponse : TopResponse
    {
        /// <summary>
        /// 出账机构
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构
        /// </summary>
        [XmlElement("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [XmlElement("sub_order_type")]
        public string SubOrderType { get; set; }
    }
}
