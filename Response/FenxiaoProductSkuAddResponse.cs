using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductSkuAddResponse.
    /// </summary>
    public class FenxiaoProductSkuAddResponse : TopResponse
    {
        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
