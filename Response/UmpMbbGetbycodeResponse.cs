using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpMbbGetbycodeResponse.
    /// </summary>
    public class UmpMbbGetbycodeResponse : TopResponse
    {
        /// <summary>
        /// 营销积木块的内容，通过ump sdk来进行处理
        /// </summary>
        [XmlElement("mbb")]
        public string Mbb { get; set; }
    }
}
