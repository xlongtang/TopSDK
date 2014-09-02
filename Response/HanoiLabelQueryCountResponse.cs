using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelQueryCountResponse.
    /// </summary>
    public class HanoiLabelQueryCountResponse : TopResponse
    {
        /// <summary>
        /// 查询结果包含的信息
        /// </summary>
        [XmlElement("template_result")]
        public TemplateResult TemplateResult { get; set; }

        /// <summary>
        /// 查询的结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
