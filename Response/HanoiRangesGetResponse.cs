using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiRangesGetResponse.
    /// </summary>
    public class HanoiRangesGetResponse : TopResponse
    {
        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("page_result")]
        public PageResult PageResult { get; set; }

        /// <summary>
        /// 取值范围列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("range_v_o")]
        public List<RangeVO> Values { get; set; }
    }
}
