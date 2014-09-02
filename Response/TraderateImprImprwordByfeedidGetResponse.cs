using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TraderateImprImprwordByfeedidGetResponse.
    /// </summary>
    public class TraderateImprImprwordByfeedidGetResponse : TopResponse
    {
        /// <summary>
        /// 根据子订单和买家昵称找到的评价和印象词结果
        /// </summary>
        [XmlElement("impr_feed")]
        public ImprFeedIdDO ImprFeed { get; set; }
    }
}
