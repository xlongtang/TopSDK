using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AthenaItemSolutionAddResponse.
    /// </summary>
    public class AthenaItemSolutionAddResponse : TopResponse
    {
        /// <summary>
        /// 添加结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
