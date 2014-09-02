using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CaipiaoPresentItemsGetResponse.
    /// </summary>
    public class CaipiaoPresentItemsGetResponse : TopResponse
    {
        /// <summary>
        /// 查询的结果列表
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("lottery_wangcai_present")]
        public List<LotteryWangcaiPresent> Results { get; set; }

        /// <summary>
        /// 返回列表的大小
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
