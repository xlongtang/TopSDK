using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupListQueryResponse.
    /// </summary>
    public class HanoiGroupListQueryResponse : TopResponse
    {
        /// <summary>
        /// 符合条件的记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 查询得到的分组列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("hanoi_label_group")]
        public List<HanoiLabelGroup> Values { get; set; }
    }
}
