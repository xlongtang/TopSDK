using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDealerRequisitionorderGetResponse.
    /// </summary>
    public class FenxiaoDealerRequisitionorderGetResponse : TopResponse
    {
        /// <summary>
        /// 采购申请/经销采购单结果列表
        /// </summary>
        [XmlArray("dealer_orders")]
        [XmlArrayItem("dealer_order")]
        public List<DealerOrder> DealerOrders { get; set; }

        /// <summary>
        /// 按查询条件查到的记录总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
