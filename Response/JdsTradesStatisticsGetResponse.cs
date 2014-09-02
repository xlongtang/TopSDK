using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JdsTradesStatisticsGetResponse.
    /// </summary>
    public class JdsTradesStatisticsGetResponse : TopResponse
    {
        /// <summary>
        /// 订单状态计数值
        /// </summary>
        [XmlArray("status_infos")]
        [XmlArrayItem("trade_stat")]
        public List<TradeStat> StatusInfos { get; set; }
    }
}
