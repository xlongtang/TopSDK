using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Passerger Data Structure.
    /// </summary>
    [Serializable]
    public class Passerger : TopObject
    {
        /// <summary>
        /// 乘机人生日：yyyy-mm-dd
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 乘机人证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 乘机人证件类型：0，身份证；1，护照；2，学生证；3，军人证；4，回乡证；5，台胞证；6，港澳台胞；7，国际海员；8，外国人永久居留证；9，其它证件
        /// </summary>
        [XmlElement("cert_type")]
        public long CertType { get; set; }

        /// <summary>
        /// ei项
        /// </summary>
        [XmlElement("ei")]
        public string Ei { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 强制保险金额，单位：分
        /// </summary>
        [XmlElement("force_insure_price")]
        public long ForceInsurePrice { get; set; }

        /// <summary>
        /// 当前乘机人的保险分润金额，单位：分
        /// </summary>
        [XmlElement("insure_promotion_price")]
        public long InsurePromotionPrice { get; set; }

        /// <summary>
        /// 乘机人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 乘机人类型：0，成人；1，儿童；2，婴儿
        /// </summary>
        [XmlElement("passenger_type")]
        public long PassengerType { get; set; }

        /// <summary>
        /// pnr
        /// </summary>
        [XmlElement("pnr")]
        public string Pnr { get; set; }

        /// <summary>
        /// 票号
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 常旅客卡号
        /// </summary>
        [XmlElement("trip_card_no")]
        public string TripCardNo { get; set; }

        /// <summary>
        /// 退改签
        /// </summary>
        [XmlElement("tuigaiqian")]
        public string Tuigaiqian { get; set; }
    }
}
