using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSchemaMatchResponse.
    /// </summary>
    public class TmallProductSchemaMatchResponse : TopResponse
    {
        /// <summary>
        /// 返回匹配产品ID，部分类目可能返回多个产品ID，以逗号分隔。
        /// </summary>
        [XmlElement("match_result")]
        public string MatchResult { get; set; }
    }
}
