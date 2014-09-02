using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOutInventoryChangeNotifyResponse.
    /// </summary>
    public class WlbOutInventoryChangeNotifyResponse : TopResponse
    {
        /// <summary>
        /// 库存变化通知成功时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
