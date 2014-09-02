using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CaipiaoPresentWinItemsGetResponse.
    /// </summary>
    public class CaipiaoPresentWinItemsGetResponse : TopResponse
    {
        /// <summary>
        /// 查询的结果集
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("lottery_wangcai_present")]
        public List<LotteryWangcaiPresent> Results { get; set; }

        /// <summary>
        /// 查询的结果集大小
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
