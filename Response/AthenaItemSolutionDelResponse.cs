using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AthenaItemSolutionDelResponse.
    /// </summary>
    public class AthenaItemSolutionDelResponse : TopResponse
    {
        /// <summary>
        /// 添加结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
