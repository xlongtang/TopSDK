using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallTraderateCattagsGetResponse.
    /// </summary>
    public class TmallTraderateCattagsGetResponse : TopResponse
    {
        /// <summary>
        /// 该类目下的标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("tmall_rate_tag")]
        public List<TmallRateTag> Tags { get; set; }
    }
}
