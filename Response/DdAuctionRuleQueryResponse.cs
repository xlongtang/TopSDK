using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// DdAuctionRuleQueryResponse.
    /// </summary>
    public class DdAuctionRuleQueryResponse : TopResponse
    {
        /// <summary>
        /// auction rule vo
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("dd_top_auction_rule_v_o")]
        public List<DdTopAuctionRuleVO> Result { get; set; }
    }
}
