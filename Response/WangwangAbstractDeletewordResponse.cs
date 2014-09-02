using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangAbstractDeletewordResponse.
    /// </summary>
    public class WangwangAbstractDeletewordResponse : TopResponse
    {
        /// <summary>
        /// 例如单词长度太长等
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 0或-1，表示错误或正确，错误时有错误信息
        /// </summary>
        [XmlElement("ret_code")]
        public long RetCode { get; set; }
    }
}
