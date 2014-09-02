using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UicWeiboprofileUpdateResponse.
    /// </summary>
    public class UicWeiboprofileUpdateResponse : TopResponse
    {
        /// <summary>
        /// 1表示正常，2表示参数错误，3表示系统异常
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }
    }
}
