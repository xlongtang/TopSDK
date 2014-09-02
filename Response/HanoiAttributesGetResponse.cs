using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiAttributesGetResponse.
    /// </summary>
    public class HanoiAttributesGetResponse : TopResponse
    {
        /// <summary>
        /// 如果查询时需要分页，则返回分页的信息
        /// </summary>
        [XmlElement("page_result")]
        public PageResult PageResult { get; set; }

        /// <summary>
        /// 返回查询的属性列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("attribute_v_o")]
        public List<AttributeVO> Values { get; set; }
    }
}
