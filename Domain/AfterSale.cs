using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AfterSale Data Structure.
    /// </summary>
    [Serializable]
    public class AfterSale : TopObject
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("after_sale_id")]
        public long AfterSaleId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("after_sale_name")]
        public string AfterSaleName { get; set; }

        /// <summary>
        /// tfs地址
        /// </summary>
        [XmlElement("after_sale_path")]
        public string AfterSalePath { get; set; }
    }
}
