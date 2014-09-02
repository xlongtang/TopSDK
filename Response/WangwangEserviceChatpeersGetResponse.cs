using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceChatpeersGetResponse.
    /// </summary>
    public class WangwangEserviceChatpeersGetResponse : TopResponse
    {
        /// <summary>
        /// 聊天对象ID列表
        /// </summary>
        [XmlArray("chatpeers")]
        [XmlArrayItem("chatpeer")]
        public List<Chatpeer> Chatpeers { get; set; }

        /// <summary>
        /// 成员数目。
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 返回码：  10000:成功；   60000：时间非法，包括1)时间段超过7天,或2)起始时间距今超过30天，或3)时间格式不对；   50000：聊天用户ID不是该店铺的帐号；   40000：系统错误，包括必填参数为空。
        /// </summary>
        [XmlElement("ret")]
        public long Ret { get; set; }
    }
}
