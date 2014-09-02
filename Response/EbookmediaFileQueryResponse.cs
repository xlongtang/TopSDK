using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookmediaFileQueryResponse.
    /// </summary>
    public class EbookmediaFileQueryResponse : TopResponse
    {
        /// <summary>
        /// 查询的结果集
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("ebook_media_resource")]
        public List<EbookMediaResource> Results { get; set; }
    }
}
