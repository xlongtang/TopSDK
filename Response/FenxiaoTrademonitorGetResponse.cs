using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoTrademonitorGetResponse.
    /// </summary>
    public class FenxiaoTrademonitorGetResponse : TopResponse
    {
        /// <summary>
        /// 搜索到的经销商品订单数量
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// 经销商品订单监控信息
        /// </summary>
        [XmlArray("trade_monitors")]
        [XmlArrayItem("trade_monitor")]
        public List<TradeMonitor> TradeMonitors { get; set; }
    }
}
