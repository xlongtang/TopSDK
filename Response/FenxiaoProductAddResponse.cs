using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductAddResponse.
    /// </summary>
    public class FenxiaoProductAddResponse : TopResponse
    {
        /// <summary>
        /// 产品创建时间 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }
    }
}
