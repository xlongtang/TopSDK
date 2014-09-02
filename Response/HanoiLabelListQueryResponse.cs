using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelListQueryResponse.
    /// </summary>
    public class HanoiLabelListQueryResponse : TopResponse
    {
        /// <summary>
        /// 符合条件的记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 查询的结果列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("label")]
        public List<Label> Values { get; set; }
    }
}
