using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoProductImageDeleteResponse.
    /// </summary>
    public class FenxiaoProductImageDeleteResponse : TopResponse
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
