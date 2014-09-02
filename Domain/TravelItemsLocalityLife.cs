using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItemsLocalityLife Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItemsLocalityLife : TopObject
    {
        /// <summary>
        /// 表示是否使用邮寄 0: 代表不使用邮寄； 1：代表使用邮寄；如果不设置这个值，代表不使用邮寄。
        /// </summary>
        [XmlElement("choose_logis")]
        public long ChooseLogis { get; set; }

        /// <summary>
        /// 电子交易凭证有效期，有三种格式：如果有效期为起止日期类型，此值为2012-08-06,2012-08-16 如果有效期为【购买成功日至】类型则格式为2012-08-16 ；如果有效期为天数类型则格式为15
        /// </summary>
        [XmlElement("expirydate")]
        public string Expirydate { get; set; }

        /// <summary>
        /// 格式为 码商id:nick
        /// </summary>
        [XmlElement("merchant")]
        public string Merchant { get; set; }

        /// <summary>
        /// 网点ID,在参数empty_fields里设置locality_life.network_id可删除网点ID。
        /// </summary>
        [XmlElement("network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// 电子凭证售中自动退款比例。
        /// </summary>
        [XmlElement("onsale_auto_refund_ratio")]
        public long OnsaleAutoRefundRatio { get; set; }

        /// <summary>
        /// 退款比例，百分比%前的数字，1-100的正整数值；在参数empty_fields里设置travel_items_locality_life.refund_ratio可删除退款比例。
        /// </summary>
        [XmlElement("refund_ratio")]
        public long RefundRatio { get; set; }

        /// <summary>
        /// 核销打款:1代表核销打款,0代表非核销打款; 在参数empty_fields里设置travel_items_locality_life.verification可删除核销打款。
        /// </summary>
        [XmlElement("verification")]
        public string Verification { get; set; }
    }
}
