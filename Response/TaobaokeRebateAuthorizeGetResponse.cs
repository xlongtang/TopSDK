using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeRebateAuthorizeGetResponse.
    /// </summary>
    public class TaobaokeRebateAuthorizeGetResponse : TopResponse
    {
        /// <summary>
        /// 卖家是否同意返利.true:同意返利,false:拒绝返利
        /// </summary>
        [XmlElement("rebate")]
        public bool Rebate { get; set; }
    }
}
