using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// DeliveryTemplatesGetResponse.
    /// </summary>
    public class DeliveryTemplatesGetResponse : TopResponse
    {
        /// <summary>
        /// 运费模板列表
        /// </summary>
        [XmlArray("delivery_templates")]
        [XmlArrayItem("delivery_template")]
        public List<DeliveryTemplate> DeliveryTemplates { get; set; }

        /// <summary>
        /// 获得到符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
