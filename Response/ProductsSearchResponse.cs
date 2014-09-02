using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ProductsSearchResponse.
    /// </summary>
    public class ProductsSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回具体信息为入参fields请求的字段信息
        /// </summary>
        [XmlArray("products")]
        [XmlArrayItem("product")]
        public List<Product> Products { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
