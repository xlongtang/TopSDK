using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookLibsSearchResponse.
    /// </summary>
    public class EbookLibsSearchResponse : TopResponse
    {
        /// <summary>
        /// 查询的结果集
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("ebook_lib")]
        public List<EbookLib> Results { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
