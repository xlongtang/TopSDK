using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// DdAuctionRuleDeleteResponse.
    /// </summary>
    public class DdAuctionRuleDeleteResponse : TopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
