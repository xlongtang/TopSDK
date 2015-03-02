using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillIProductResponse.
    /// </summary>
    public class WlbWaybillIProductResponse : TopResponse
    {
        /// <summary>
        /// 产品类型返回
        /// </summary>
        [XmlArray("product_types")]
        [XmlArrayItem("waybill_product_type")]
        public List<WaybillProductType> ProductTypes { get; set; }
    }
}
