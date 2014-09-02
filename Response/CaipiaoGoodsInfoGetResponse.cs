using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// CaipiaoGoodsInfoGetResponse.
    /// </summary>
    public class CaipiaoGoodsInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 查询的结果列表
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("lottery_wangcai_seller_goods_info")]
        public List<LotteryWangcaiSellerGoodsInfo> Results { get; set; }

        /// <summary>
        /// 返回列表的大小
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
