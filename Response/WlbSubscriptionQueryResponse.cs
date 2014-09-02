using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbSubscriptionQueryResponse.
    /// </summary>
    public class WlbSubscriptionQueryResponse : TopResponse
    {
        /// <summary>
        /// 卖家定购的服务列表
        /// </summary>
        [XmlArray("seller_subscription_list")]
        [XmlArrayItem("wlb_seller_subscription")]
        public List<WlbSellerSubscription> SellerSubscriptionList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
