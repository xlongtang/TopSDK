using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TaobaokeMobileUrlConvertResponse.
    /// </summary>
    public class TaobaokeMobileUrlConvertResponse : TopResponse
    {
        /// <summary>
        /// 只返回click_url
        /// </summary>
        [XmlElement("taobaoke_item")]
        public TaobaokeItem TaobaokeItem { get; set; }
    }
}
