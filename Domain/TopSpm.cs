using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TopSpm Data Structure.
    /// </summary>
    [Serializable]
    public class TopSpm : TopObject
    {
        /// <summary>
        /// 为淘宝带来的支付宝成交金额
        /// </summary>
        [XmlElement("alipay_deal_amount")]
        public string AlipayDealAmount { get; set; }

        /// <summary>
        /// 为淘宝带来的支付宝成交笔数
        /// </summary>
        [XmlElement("alipay_deal_count")]
        public long AlipayDealCount { get; set; }

        /// <summary>
        /// 为淘宝带来的支付宝成交人数
        /// </summary>
        [XmlElement("alipay_uv")]
        public long AlipayUv { get; set; }

        /// <summary>
        /// SPM第四位编码（默认为TOP系统自动生成的0-9数字，ISV可以自行更改编码，但建议使用数字）
        /// </summary>
        [XmlElement("module")]
        public string Module { get; set; }

        /// <summary>
        /// SPM第三位编码（默认为TOP系统自动生成的0-9数字，ISV可以自行更改编码，但建议使用数字）
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 为淘宝带来的PV
        /// </summary>
        [XmlElement("pv")]
        public long Pv { get; set; }

        /// <summary>
        /// 为淘宝带来的UV
        /// </summary>
        [XmlElement("uv")]
        public long Uv { get; set; }
    }
}
