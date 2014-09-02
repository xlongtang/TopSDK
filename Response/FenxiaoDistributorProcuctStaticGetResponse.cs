using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDistributorProcuctStaticGetResponse.
    /// </summary>
    public class FenxiaoDistributorProcuctStaticGetResponse : TopResponse
    {
        /// <summary>
        /// 分销商商品流量
        /// </summary>
        [XmlArray("distributor_item_flows")]
        [XmlArrayItem("distributor_item_flow")]
        public List<DistributorItemFlow> DistributorItemFlows { get; set; }

        /// <summary>
        /// 执行结果，true表示执行成功；false表示执行失败。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
