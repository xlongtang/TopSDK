using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcMessagesConsumeResponse.
    /// </summary>
    public class TmcMessagesConsumeResponse : TopResponse
    {
        /// <summary>
        /// 消息列表
        /// </summary>
        [XmlArray("messages")]
        [XmlArrayItem("tmc_message")]
        public List<TmcMessage> Messages { get; set; }
    }
}
