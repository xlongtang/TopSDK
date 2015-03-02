using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillICancelResponse.
    /// </summary>
    public class WlbWaybillICancelResponse : TopResponse
    {
        /// <summary>
        /// 调用取消是否成功
        /// </summary>
        [XmlElement("cancel_result")]
        public bool CancelResult { get; set; }
    }
}
