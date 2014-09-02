using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaXiamiApiContractSignResponse.
    /// </summary>
    public class AlibabaXiamiApiContractSignResponse : TopResponse
    {
        /// <summary>
        /// 签约链接
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
