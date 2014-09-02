using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// DdAuctionRuleUpdateResponse.
    /// </summary>
    public class DdAuctionRuleUpdateResponse : TopResponse
    {
        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }
    }
}
