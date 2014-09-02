using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiTypesGetResponse.
    /// </summary>
    public class HanoiTypesGetResponse : TopResponse
    {
        /// <summary>
        /// 分页返回信息
        /// </summary>
        [XmlElement("page_result")]
        public PageResult PageResult { get; set; }

        /// <summary>
        /// 返回的类型列表信息。
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("type_v_o")]
        public List<TypeVO> Values { get; set; }
    }
}
