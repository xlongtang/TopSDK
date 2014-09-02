using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JaeClientInteractionVibrateResponse.
    /// </summary>
    public class JaeClientInteractionVibrateResponse : TopResponse
    {
        /// <summary>
        /// 没有返回结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
