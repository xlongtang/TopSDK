using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TripJipiaoNsearchOwSearchResponse.
    /// </summary>
    public class TripJipiaoNsearchOwSearchResponse : TopResponse
    {
        /// <summary>
        /// 航班搜索结果对象
        /// </summary>
        [XmlElement("result")]
        public AtNSearchResult Result { get; set; }
    }
}
