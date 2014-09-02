using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallTraderateFeedsGetResponse.
    /// </summary>
    public class TmallTraderateFeedsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回评价信息
        /// </summary>
        [XmlElement("tmall_rate_info")]
        public TmallRateInfo TmallRateInfo { get; set; }
    }
}
