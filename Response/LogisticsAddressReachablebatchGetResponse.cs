using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// LogisticsAddressReachablebatchGetResponse.
    /// </summary>
    public class LogisticsAddressReachablebatchGetResponse : TopResponse
    {
        /// <summary>
        /// 物流是否可达结果列表
        /// </summary>
        [XmlArray("reachable_results")]
        [XmlArrayItem("address_reachable_top_result")]
        public List<AddressReachableTopResult> ReachableResults { get; set; }
    }
}
