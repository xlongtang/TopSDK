using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillSearchResponse.
    /// </summary>
    public class WlbWaybillSearchResponse : TopResponse
    {
        /// <summary>
        /// 查询相关数据(cp_type 1是直营，2是加盟 )
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("waybill_apply_subscription_info")]
        public List<WaybillApplySubscriptionInfo> Results { get; set; }
    }
}
