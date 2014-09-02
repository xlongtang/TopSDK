using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDiscountAddResponse.
    /// </summary>
    public class FenxiaoDiscountAddResponse : TopResponse
    {
        /// <summary>
        /// 折扣ID
        /// </summary>
        [XmlElement("discount_id")]
        public long DiscountId { get; set; }
    }
}
