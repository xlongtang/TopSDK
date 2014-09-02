using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductcatAddResponse.
    /// </summary>
    public class FenxiaoProductcatAddResponse : TopResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 产品线ID
        /// </summary>
        [XmlElement("product_line_id")]
        public long ProductLineId { get; set; }
    }
}
