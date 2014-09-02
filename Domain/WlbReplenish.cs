using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbReplenish Data Structure.
    /// </summary>
    [Serializable]
    public class WlbReplenish : TopObject
    {
        /// <summary>
        /// 根据历史统计值计算出来的预期值  WarnByLast3Days=1; ByLast3Days=3;  ByLast10Days=10;  ByLast30Days=30;  ByLast90Days=90  WarnByLast3Days为按照过去3天的发出的件数来统计的达到安全库存的天数；其它4项分别为按照过去3、10、30、90天发出的商品件数，现有库存可以维持的天数
        /// </summary>
        [XmlElement("estimate_value")]
        public string EstimateValue { get; set; }

        /// <summary>
        /// 订单历史统计值  Last3DaysTotal=3; Last10DaysTotal=10;  Last30DaysTotal=30; Last90DaysTotal=90  分别为过去3、10、30、90天发出的商品件数
        /// </summary>
        [XmlElement("history_value")]
        public string HistoryValue { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 补货周期（单位：天）
        /// </summary>
        [XmlElement("retrieval_count")]
        public long RetrievalCount { get; set; }

        /// <summary>
        /// 可销售库存数
        /// </summary>
        [XmlElement("sell_count")]
        public long SellCount { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 在途库存数
        /// </summary>
        [XmlElement("transport_count")]
        public long TransportCount { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 安全库存
        /// </summary>
        [XmlElement("warn_count")]
        public long WarnCount { get; set; }
    }
}
