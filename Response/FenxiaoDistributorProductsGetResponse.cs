using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoDistributorProductsGetResponse.
    /// </summary>
    public class FenxiaoDistributorProductsGetResponse : TopResponse
    {
        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 产品对象记录集。返回 FenxiaoProduct 包含的字段信息。
        /// </summary>
        [XmlArray("products")]
        [XmlArrayItem("fenxiao_product")]
        public List<FenxiaoProduct> Products { get; set; }
    }
}
