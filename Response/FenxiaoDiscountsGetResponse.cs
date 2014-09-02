using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDiscountsGetResponse.
    /// </summary>
    public class FenxiaoDiscountsGetResponse : TopResponse
    {
        /// <summary>
        /// 折扣数据结构
        /// </summary>
        [XmlArray("discounts")]
        [XmlArrayItem("discount")]
        public List<Discount> Discounts { get; set; }

        /// <summary>
        /// 记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
