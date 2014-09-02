using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangAbstractLogqueryResponse.
    /// </summary>
    public class WangwangAbstractLogqueryResponse : TopResponse
    {
        /// <summary>
        /// 例如单词长度太长等。  当ret_code不为0时这个值存在。
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("from_id")]
        public string FromId { get; set; }

        /// <summary>
        /// 0或1  其他返回时，是由于用户名等参数设置有误等引起的远端服务错误
        /// </summary>
        [XmlElement("is_sliced")]
        public long IsSliced { get; set; }

        /// <summary>
        /// 消息列表
        /// </summary>
        [XmlArray("msg_lists")]
        [XmlArrayItem("msg_list")]
        public List<MsgList> MsgLists { get; set; }

        /// <summary>
        /// 当is_sliced为1时有效
        /// </summary>
        [XmlElement("next_key")]
        public string NextKey { get; set; }

        /// <summary>
        /// 0或-1，表示错误或正确，错误时有错误信息.  为-1时就只有error_msg字段是有效的。
        /// </summary>
        [XmlElement("ret_code")]
        public long RetCode { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("to_id")]
        public string ToId { get; set; }
    }
}
