using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// DdAuctionRuleAddResponse.
    /// </summary>
    public class DdAuctionRuleAddResponse : TopResponse
    {
        /// <summary>
        /// 新增add规则ID
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }
    }
}
