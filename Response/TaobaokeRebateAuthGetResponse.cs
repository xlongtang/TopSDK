using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeRebateAuthGetResponse.
    /// </summary>
    public class TaobaokeRebateAuthGetResponse : TopResponse
    {
        /// <summary>
        /// 返利授权查询结果
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("taobaoke_authorize")]
        public List<TaobaokeAuthorize> Results { get; set; }
    }
}
