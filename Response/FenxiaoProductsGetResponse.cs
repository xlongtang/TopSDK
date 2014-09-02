using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductsGetResponse.
    /// </summary>
    public class FenxiaoProductsGetResponse : TopResponse
    {
        /// <summary>
        /// 产品对象记录集。返回 FenxiaoProduct 包含的字段信息。
        /// </summary>
        [XmlArray("products")]
        [XmlArrayItem("fenxiao_product")]
        public List<FenxiaoProduct> Products { get; set; }

        /// <summary>
        /// 查询结果记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
