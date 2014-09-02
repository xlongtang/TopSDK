using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupLabelQueryResponse.
    /// </summary>
    public class HanoiGroupLabelQueryResponse : TopResponse
    {
        /// <summary>
        /// 分组内标签id及其优先级的列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("inner_label")]
        public List<InnerLabel> Values { get; set; }
    }
}
