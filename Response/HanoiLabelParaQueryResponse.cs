using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelParaQueryResponse.
    /// </summary>
    public class HanoiLabelParaQueryResponse : TopResponse
    {
        /// <summary>
        /// 查询得到的标签参数列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("parameter_v_o")]
        public List<ParameterVO> Values { get; set; }
    }
}
