using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductMatchSchemaGetResponse.
    /// </summary>
    public class TmallProductMatchSchemaGetResponse : TopResponse
    {
        /// <summary>
        /// 返回匹配product的规则文档
        /// </summary>
        [XmlElement("match_result")]
        public string MatchResult { get; set; }
    }
}
