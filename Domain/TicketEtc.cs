using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TicketEtc Data Structure.
    /// </summary>
    [Serializable]
    public class TicketEtc : TopObject
    {
        /// <summary>
        /// 商品电子凭证是否关联本地商户-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("association_status")]
        public bool AssociationStatus { get; set; }

        /// <summary>
        /// 商品电子凭证的自动退款比例-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("auto_refund")]
        public long AutoRefund { get; set; }

        /// <summary>
        /// 商品电子凭证的码商-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商品电子凭证的码商名-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("merchant_nick")]
        public string MerchantNick { get; set; }

        /// <summary>
        /// 商品电子凭证的码商-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// 商品电子凭证的过期退款比例-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("overdue_pay")]
        public long OverduePay { get; set; }

        /// <summary>
        /// 商品电子凭证是否核销打款-在门票商品为电子凭证时必选
        /// </summary>
        [XmlElement("verification_pay")]
        public bool VerificationPay { get; set; }
    }
}
