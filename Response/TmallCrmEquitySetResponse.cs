using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallCrmEquitySetResponse.
    /// </summary>
    public class TmallCrmEquitySetResponse : TopResponse
    {
        /// <summary>
        /// true：成功 false：失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
