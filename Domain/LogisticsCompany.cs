using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LogisticsCompany Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsCompany : TopObject
    {
        /// <summary>
        /// 物流公司代码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 物流公司标识
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物流公司简称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 运单号验证正则表达式
        /// </summary>
        [XmlElement("reg_mail_no")]
        public string RegMailNo { get; set; }
    }
}
