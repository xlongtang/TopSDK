using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceAccountstatusGetResponse.
    /// </summary>
    public class WangwangEserviceAccountstatusGetResponse : TopResponse
    {
        /// <summary>
        /// 账号操作记录列表。
        /// </summary>
        [XmlArray("account_infos")]
        [XmlArrayItem("account_info")]
        public List<AccountInfo> AccountInfos { get; set; }

        /// <summary>
        /// 接口调用返回码。 0：成功。100：部分成功。
        /// </summary>
        [XmlElement("ret_code")]
        public long RetCode { get; set; }
    }
}
