using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiTemplateListQueryResponse.
    /// </summary>
    public class HanoiTemplateListQueryResponse : TopResponse
    {
        /// <summary>
        /// 返回符合条件的记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 查询得到的模板列表
        /// </summary>
        [XmlArray("values")]
        [XmlArrayItem("template")]
        public List<Template> Values { get; set; }
    }
}
