using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaXiamiApiContractIssignResponse.
    /// </summary>
    public class AlibabaXiamiApiContractIssignResponse : TopResponse
    {
        /// <summary>
        /// 是否已经签约
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
