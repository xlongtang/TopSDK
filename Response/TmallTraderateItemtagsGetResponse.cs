using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallTraderateItemtagsGetResponse.
    /// </summary>
    public class TmallTraderateItemtagsGetResponse : TopResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("tmall_rate_tag_detail")]
        public List<TmallRateTagDetail> Tags { get; set; }
    }
}
