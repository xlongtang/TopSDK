using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbNotifyMessageConfirmResponse.
    /// </summary>
    public class WlbNotifyMessageConfirmResponse : TopResponse
    {
        /// <summary>
        /// 物流宝消息确认时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
