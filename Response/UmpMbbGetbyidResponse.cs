using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpMbbGetbyidResponse.
    /// </summary>
    public class UmpMbbGetbyidResponse : TopResponse
    {
        /// <summary>
        /// 营销积木块定义信息，可以通过ump sdk里面的MBB.fromJson来处理
        /// </summary>
        [XmlElement("mbb")]
        public string Mbb { get; set; }
    }
}
