using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangAbstractInitializeResponse.
    /// </summary>
    public class WangwangAbstractInitializeResponse : TopResponse
    {
        /// <summary>
        /// 当ret_code=-1时这个变量才有
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 0或-1表示成功或失败
        /// </summary>
        [XmlElement("ret_code")]
        public long RetCode { get; set; }
    }
}
