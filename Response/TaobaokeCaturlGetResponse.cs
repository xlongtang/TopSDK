using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeCaturlGetResponse.
    /// </summary>
    public class TaobaokeCaturlGetResponse : TopResponse
    {
        /// <summary>
        /// 只返回taobaoke_cat_click_url
        /// </summary>
        [XmlElement("taobaoke_item")]
        public TaobaokeItem TaobaokeItem { get; set; }
    }
}
