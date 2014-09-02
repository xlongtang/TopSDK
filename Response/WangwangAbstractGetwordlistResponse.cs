using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangAbstractGetwordlistResponse.
    /// </summary>
    public class WangwangAbstractGetwordlistResponse : TopResponse
    {
        /// <summary>
        /// 例如单词长度太长等，ret_code=-1才有
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 0或-1，表示错误或正确，错误时有错误信息
        /// </summary>
        [XmlElement("ret_code")]
        public long RetCode { get; set; }

        /// <summary>
        /// 关键词列表，ret_code=0才有
        /// </summary>
        [XmlArray("word_lists")]
        [XmlArrayItem("word_list")]
        public List<WordList> WordLists { get; set; }
    }
}
