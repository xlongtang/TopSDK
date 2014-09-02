using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PartnerDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PartnerDetail : TopObject
    {
        /// <summary>
        /// 物流公司支付宝账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 物流公司代码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 物流公司id
        /// </summary>
        [XmlElement("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// 物流公司简称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 物流公司全名
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 运单号验证正则表达式
        /// </summary>
        [XmlElement("reg_mail_no")]
        public string RegMailNo { get; set; }

        /// <summary>
        /// 旺旺id
        /// </summary>
        [XmlElement("wangwang_id")]
        public string WangwangId { get; set; }
    }
}
