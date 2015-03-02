using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcMessagesProduceResponse.
    /// </summary>
    public class TmcMessagesProduceResponse : TopResponse
    {
        /// <summary>
        /// 是否全部成功
        /// </summary>
        [XmlElement("is_all_success")]
        public bool IsAllSuccess { get; set; }

        /// <summary>
        /// 发送结果，与发送时的参数顺序一致。如果is_all_success为true时，不用校验result是否成功
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("tmc_produce_result")]
        public List<TmcProduceResult> Results { get; set; }
    }
}
