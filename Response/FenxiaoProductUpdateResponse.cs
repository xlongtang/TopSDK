using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductUpdateResponse.
    /// </summary>
    public class FenxiaoProductUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新时间，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }
    }
}
