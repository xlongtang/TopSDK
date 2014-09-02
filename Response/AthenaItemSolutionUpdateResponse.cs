using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AthenaItemSolutionUpdateResponse.
    /// </summary>
    public class AthenaItemSolutionUpdateResponse : TopResponse
    {
        /// <summary>
        /// 添加结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
