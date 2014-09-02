using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSuitespecsGetResponse.
    /// </summary>
    public class TmallProductSuitespecsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回一组产品规格信息。
        /// </summary>
        [XmlArray("product_specs")]
        [XmlArrayItem("product_spec")]
        public List<ProductSpec> ProductSpecs { get; set; }
    }
}
