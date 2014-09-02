using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// MarketingPromotionsGetResponse.
    /// </summary>
    public class MarketingPromotionsGetResponse : TopResponse
    {
        /// <summary>
        /// 商品对应的所有优惠列表
        /// </summary>
        [XmlArray("promotions")]
        [XmlArrayItem("promotion")]
        public List<Promotion> Promotions { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
