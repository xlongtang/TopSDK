using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FeedbackAddResponse.
    /// </summary>
    public class FeedbackAddResponse : TopResponse
    {
        /// <summary>
        /// 返回记录的时间
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
